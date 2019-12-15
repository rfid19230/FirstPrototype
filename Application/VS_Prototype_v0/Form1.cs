// Необходимые зависимости
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_Prototype_v0
{
    public partial class Form1 : Form
    {
        // Список используемых команд
        // '0' : Команда подтверждения установки соединения Arduino и компьютера
        // '1' : Команда разрыва соединения между Arduino и компьютером
        // '2' : Команда, получаемая при прикладывании пропуска и свидетельствующая о том, что доступ разрешен
        // '3' : Команда, получаемая при прикладывании пропуска и свидетельствующая о том, что доступ запрещен
        // '4' : Команда, получаемая при повторном прикладывании пропуска и свидетельствующая об окончании работы пользователя с системой
        // '5' : Команда, получаемая при прикладывании ценности и свидетельствующая о ее взятии
        // '6' : Команда, получаемая при прикладывании ценности и свидетельствующая о ее возврате
        // '7' : Команда, получаемая при прикладывании ценности, данные о которой отсутствуют в базе
        const string COMMAND_CONNECT = "0";
        const string COMMAND_DISCONNECT = "1";
        const string COMMAND_VALID_PASS = "2";
        const string COMMAND_INVALID_PASS = "3";
        const string COMMAND_END_SESSION = "4";
        const string COMMAND_VALUE_TAKEN = "5";
        const string COMMAND_VALUE_RETURNED = "6";
        const string COMMAND_INVALID_VALUE = "7";
        // Переменная, используемая для хранения uid пропуска сотрудника, открывшего систему
        public string currentUid = "";
        // Строка подключения к Oracle
        const string oracleConnectionString = @"DATA SOURCE=localhost:1521/XE;PASSWORD=19230;PERSIST SECURITY INFO=True;USER ID=rfid";

        /// <summary>
        /// Конструктор главной формы
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            // заполнение списка доступных COM портов
            string[] serialPorts = new string[255];
            for (int i = 1; i < 256; ++i)
            {
                serialPorts[i - 1] = "COM" + i.ToString();
            }
            chosenPortComboBox.Items.AddRange(serialPorts);
            int defaultChosenPort = 3;
            chosenPortComboBox.SelectedIndex = defaultChosenPort - 1;
            // Вывод информации о работе программы
            string info = "Приложение запущено: Успешно\r\n";
            toDebugTextBox(info);
        }

        /// <summary>
        /// Действия, выполняемые при нажатии кнопки "Подключение"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void connectButton_Click(object sender, EventArgs e)
        {
            // Выбор номера используемого порта
            serialPort.PortName = chosenPortComboBox.Text;
            // Открытие порта с обработкой исключений, возникающих при невозможности открытия
            try
            {
                serialPort.Open();
            }
            catch (Exception exception)
            {
                string info = "Подключение к порту " + serialPort.PortName + ": Не удалось\r\n";
                toDebugTextBox(info);
            }
            // При успешном открытии 
            if (serialPort.IsOpen)
            {
                // Отправка команды подключния на Arduino
                serialPort.Write(COMMAND_DISCONNECT);
                serialPort.Write(COMMAND_CONNECT);
                // Вывод информации о работе программы
                string info = "Подключение к порту " + serialPort.PortName + ": Успешно\r\n";
                toDebugTextBox(info);
                connectionStateLabel.BackColor = Color.Lime;
                connectionStateLabel.Text = "Подключено";
                connectButton.Enabled = false;
                disconnectButton.Enabled = true;
                chosenPortComboBox.Enabled = false;
            }
        }

        /// <summary>
        /// Действия, выполняемые при нажатии кнопки "Отключение"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void disconnectButton_Click(object sender, EventArgs e)
        {
            // Отправка на Arduino команды разрыва соединения
            serialPort.Write(COMMAND_DISCONNECT);
            // Закрытие порта
            try
            {
                serialPort.Close();
            }
            catch (Exception exception)
            {

            }
            // Вывод информации о работе программы
            string info = "Отключение порта " + serialPort.PortName + ": Успешно\r\n";
            toDebugTextBox(info);
            connectionStateLabel.BackColor = Color.Red;
            connectionStateLabel.Text = "Отключено";
            connectButton.Enabled = true;
            disconnectButton.Enabled = false;
            chosenPortComboBox.Enabled = true;

            currentUid = "";
        }

        /// <summary>
        /// Действия, выполняемые при получении данных от Arduino. 
        /// Основная функция программы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            // Считывание размера uid прочитанной метки
            int uidSize = Convert.ToInt32(serialPort.ReadLine());
            // Считывание uid метки
            string uid = "";
            for (int i = 0; i < uidSize; ++i)
            {
                // Обработка очередного байта uid
                string rawUidByte = serialPort.ReadLine();
                string uidByte = rawUidByte.Substring(0, rawUidByte.Length - 1);
                if (uidByte.Length == 1)
                {
                    uidByte = "0" + uidByte;
                }
                uid += uidByte;
            }

            // Вывод информации о работе программы
            string uidInfo = "Считана RFID-метка: uidSize = " + uidSize.ToString() + ", uid = " + uid + "\r\n";
            toDebugTextBox(uidInfo);

            // Анализ прочитанной метки и выбор дальнейших действий
            if (currentUid == "")
            {
                // Считанный uid рассматривается как пропуск
                string passInfo = "Рассматривается как пропуск\r\n";
                toDebugTextBox(passInfo);

                // Обращение в БД для проверки прав доступа
                if (isValidPass(uid))
                {
                    // Если доступ разрешен - отправка команды на открытие замка, запоминание текущего id пропуска
                    currentUid = uid;
                    serialPort.Write(COMMAND_VALID_PASS);
                    // Вывод информации о работе программы
                    string info = "Выполнен запрос в БД. Доступ разрешен, замок открыт\r\n";
                    toDebugTextBox(info);
                }
                else
                {
                    // Если доступ запрещен
                    serialPort.Write(COMMAND_INVALID_PASS);
                    // Вывод информации о работе программы
                    string info = "Выполнен запрос в БД. Доступ не разрешен, замок не открыт\r\n";
                    toDebugTextBox(info);
                }
            }
            else
            {
                // Идет процесс взятия и возврата вещей
                // Проверка на завершение процесса взятия и возврата вещей
                if (currentUid == uid)
                {
                    // Повторное прикладывание пропуска - признак завершения процесса взятия вещей
                    // Сброс текущего uid
                    currentUid = "";
                    // Отправка команды завершения сеанса взятия и возврата вещей
                    serialPort.Write(COMMAND_END_SESSION);
                    // Вывод информации о работе программы
                    string info = "Повторное прикладывание пропуска. Конец взятия и возврата вещей\r\n";
                    toDebugTextBox(info);
                }
                else
                {
                    // Считанный uid рассматривается как ценность
                    string valueInfo = "Рассматривается как ценность\r\n";
                    toDebugTextBox(valueInfo);

                    // Проверка ценности
                    if (isValidValue(uid))
                    {
                        // Информация о ценности есть в БД
                        string validValueInfo = "Выполнен запрос в БД. Ценность найдена в списке\r\n";
                        toDebugTextBox(validValueInfo);

                        // Проверка, взяте или возврат
                        string action = actionWithValue(currentUid, uid);
                        //
                        if (action == "taking")
                        {
                            // Если возврат, отправка соответствующей команды на Arduino
                            serialPort.Write(COMMAND_VALUE_TAKEN);
                            // Вывод информации о работе программы
                            string info = "Выполнен запрос в БД. Действие - взятие\r\n";
                            toDebugTextBox(info);
                            // Внесение изменений в БД
                            changeTakenValues(currentUid, uid, action);
                            // Отображение изменений
                            if (autoRefreshTakenValuesInfoCheckBox.Checked)
                            {
                                selectFromTable("takenvalues_info", getTakenValuesInfoFields());
                            }
                        }
                        else
                        {
                            if (action == "returning")
                            {
                                // Если озврат, отправка соответствующей команды на Arduino
                                serialPort.Write(COMMAND_VALUE_RETURNED);
                                // Вывод информации о работе программы
                                string info = "Выполнен запрос в БД. Действие - возврат\r\n";
                                toDebugTextBox(info);
                                // Внесение изменений в БД
                                changeTakenValues(currentUid, uid, action);
                                // Отображение изменений
                                if (autoRefreshTakenValuesInfoCheckBox.Checked)
                                {
                                    Invoke(new Action(() => selectFromTable("takenvalues_info", getTakenValuesInfoFields())));
                                }
                            }
                        }
                    }
                    else
                    {
                        // Информация о ценности отсутствует в БД
                        serialPort.Write(COMMAND_INVALID_VALUE);
                        // Вывод информации о работе программы
                        string info = "Выполнен запрос в БД. Ценность не найдена в списке\r\n";
                        toDebugTextBox(info);
                    }
                }
            }
        }

        /// <summary>
        /// Действия, выполняемые при закрытии формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Если СОМ порт открыт
            if (serialPort.IsOpen)
            {
                // Отправка на Arduino комнады разрыва соединения
                serialPort.Write(COMMAND_DISCONNECT);
                currentUid = "";
                // Закрытие порта
                serialPort.Close();
                // Вывод информации о работе программы
                string info = "Отключение порта " + serialPort.PortName + ": Успешно\r\n";
                toDebugTextBox(info);
            }

            string text = "Приложение закрыто: Успешно";
            toDebugTextBox(text);
        }

        /// <summary>
        /// Функция, выполняющая вывод информации о работе програамы в специальное окно
        /// </summary>
        /// <param name="info">Строка с информацией, которую необходимо вывести</param>
        void toDebugTextBox(string info)
        {
            // Проверка, из какого потока вызывается функция
            if (InvokeRequired)
            {
                // Если не из главного
                Invoke(new Action(() => debugTextBox.Text += info));

                if (debugTextBox.Text.Length >= 0.95 * debugTextBox.MaxLength)
                {
                    Invoke(new Action(() => debugTextBox.Clear()));
                    string text = "debugTextBox был очищен во избежание переполнения\r\n";
                    Invoke(new Action(() => debugTextBox.Text += text));
                }
            }
            else
            {
                // Если из главного
                debugTextBox.Text += info;

                if (debugTextBox.Text.Length >= 0.95 * debugTextBox.MaxLength)
                {
                    debugTextBox.Clear();
                    string text = "debugTextBox был очищен во избежание переполнения\r\n";
                    debugTextBox.Text += text;
                }
            }
        }

        /// <summary>
        /// Действия, выполняемые при загрузке главной формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Вывод содержимого всех таблиц на всех вкладках
            string[] usersConditions = { "", "", "", "" };
            selectFromTable("users", usersConditions);

            string[] closetsConditions = { "", "", "", "" };
            selectFromTable("closets", closetsConditions);

            string[] materialValuesConditions = { "", "", "" };
            selectFromTable("material_values", materialValuesConditions);

            string[] takenValuesInfoViewConditions = { "", "", "", "", "", "", "", "", "", "", "" };
            selectFromTable("takenvalues_info", takenValuesInfoViewConditions);
        }

        /// <summary>
        /// Функция, выполняющая проверку наличия прав доступа у приложившего пропуск
        /// </summary>
        /// <param name="passUid">Uid пропуска</param>
        /// <returns>Возвращает true при наличии прав доступа, в противном случае false</returns>
        private bool isValidPass(string passUid)
        {
            bool result = false;
            // Создание подключения к БД с использованием строки подключения
            using (OracleConnection oracleConnection = new OracleConnection(oracleConnectionString))
            {
                try
                {
                    // Открытие соединения
                    oracleConnection.Open();
                    // Формирование запроса в БД
                    string queryString = "SELECT * FROM users WHERE u_id = " + "'" + passUid + "'";
                    OracleCommand oracleCommand = new OracleCommand(queryString, oracleConnection);

                    try
                    {
                        // Выполнение запроса
                        OracleDataReader reader = oracleCommand.ExecuteReader();
                        if (reader.HasRows)
                        {
                            // Права доступа есть
                            result = true;
                        }
                    }
                    catch (Exception readException)
                    {
                        // При ошибке выполнения запроса
                        toDebugTextBox("Ошибка при выполнении запроса\r\n" + queryString + "\r\n");
                    }
                }
                catch (Exception connectException)
                {
                    // При ошибке подключения к БД
                    toDebugTextBox("Ошибка при подключении к БД\r\n");
                }
            }

            return result;
        }

        /// <summary>
        /// Функция, выполняющая проверку на наличии информации о ценности в БД
        /// </summary>
        /// <param name="valueUid">Uid ценности</param>
        /// <returns>Возвращает true при наличии информации о ценности в БД, в противном случае false</returns>
        private bool isValidValue(string valueUid)
        {
            bool result = false;
            // Создание подключения к БД с использованием строки подключения
            using (OracleConnection oracleConnection = new OracleConnection(oracleConnectionString))
            {
                try
                {
                    // Открытие соединения с БД
                    oracleConnection.Open();
                    // Формирование запроса в БД
                    string queryString = "SELECT * FROM material_values WHERE mv_id = " + "'" + valueUid + "'";
                    OracleCommand oracleCommand = new OracleCommand(queryString, oracleConnection);

                    try
                    {
                        // Выполнение запроса
                        OracleDataReader reader = oracleCommand.ExecuteReader();
                        if (reader.HasRows)
                        {
                            // При наличии информации о ценности
                            result = true;
                        }
                    }
                    catch (Exception readException)
                    {
                        // При ошибке выполнения запроса
                        toDebugTextBox("Ошибка при выполнении запроса\r\n" + queryString + "\r\n");
                    }
                }
                catch (Exception connectException)
                {
                    // ПРи ошибке подключения к БД
                    toDebugTextBox("Ошибка при подключении к БД\r\n");
                }
            }

            return result;
        }

        /// <summary>
        /// Функция, определяющая тип действия с ценностью
        /// </summary>
        /// <param name="passUid">Uid пропуска</param>
        /// <param name="valueUid">Uid ценности</param>
        /// <returns>Возвращает строку "taking" при взятии, строку "returning" при возвртае, "error" при ошибке</returns>
        private string actionWithValue(string passUid, string valueUid)
        {
            string result = "";
            // Создание подключения к БД с помошью строки подключения
            using (OracleConnection oracleConnection = new OracleConnection(oracleConnectionString))
            {
                try
                {
                    // Открытие соединения с БД
                    oracleConnection.Open();
                    // Формирование запроса в БД
                    string queryString = "SELECT * FROM taken_values WHERE tv_return IS NULL and tv_value = " + "'" + valueUid + "'" + " and tv_user = " + "'" + passUid + "'";
                    OracleCommand oracleCommand = new OracleCommand(queryString, oracleConnection);

                    try
                    {
                        // Выполнение запроса
                        OracleDataReader reader = oracleCommand.ExecuteReader();
                        if (reader.HasRows)
                        {
                            // Взятие
                            result = "returning";
                        }
                        else
                        {
                            // Возврат
                            result = "taking";
                        }
                    }
                    catch (Exception readException)
                    {
                        // При ошибке выполения вопроса
                        toDebugTextBox("Ошибка при выполнении запроса\r\n" + queryString + "\r\n");
                        result = "error";
                    }
                }
                catch (Exception connectException)
                {
                    // При ошибке подключения
                    toDebugTextBox("Ошибка при подключении к БД\r\n");
                    result = "error";
                }
            }
            return result;
        }

        /// <summary>
        /// Функция вносит изменения в БД при взятии и возврате ценностей
        /// </summary>
        /// <param name="passUid">Uid пропуска</param>
        /// <param name="valueUid">Uid ценности</param>
        /// <param name="action">Действие</param>
        private void changeTakenValues(string passUid, string valueUid, string action)
        {
            // Создание соединения с БД с использованием строки подключения
            using (OracleConnection oracleConnection = new OracleConnection(oracleConnectionString))
            {
                try
                {
                    // Открытие соединения
                    oracleConnection.Open();
                    // Формирование запроса в зависимости от действия
                    string queryString = "";
                    if (action == "taking")
                    {
                        // При взятии
                        queryString = "INSERT INTO taken_values (tv_user, tv_value, tv_take, tv_return) VALUES (:1, :2, sysdate, NULL)";
                    }
                    if (action == "returning")
                    {
                        // При возврате
                        queryString = "UPDATE taken_values SET tv_return = sysdate WHERE tv_return IS NULL and tv_user = :1 and tv_value = :2";
                    }
                    OracleCommand oracleCommand = new OracleCommand(queryString, oracleConnection);
                    oracleCommand.Parameters.Add(":1", OracleDbType.Varchar2, 20).Value = passUid;
                    oracleCommand.Parameters.Add(":2", OracleDbType.Varchar2, 20).Value = valueUid;

                    try
                    {
                        // Выполнение запроса
                        oracleCommand.ExecuteNonQuery();
                        toDebugTextBox("Выполнен запрос в БД. Обновлена таблица taken_values\r\n");
                    }
                    catch (Exception readException)
                    {
                        // При ошибке выполнения запроса
                        toDebugTextBox("Ошибка при выполнении запроса\r\n" + queryString + "\r\n");
                    }
                }
                catch (Exception connectException)
                {
                    // При ошибке подключения
                    toDebugTextBox("Ошибка при подключении к БД\r\n");
                }
            }
        }

        /// <summary>
        /// Функция проверяет возможность подключения к БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkDbConnectionButton_Click(object sender, EventArgs e)
        {
            // Создание подключения к БД с помощью строки подключения
            using (OracleConnection oracleConnection = new OracleConnection(oracleConnectionString))
            {
                try
                {
                    // Открытие соединения
                    oracleConnection.Open();
                    toDebugTextBox("БД на связи\r\n");
                }
                catch (Exception connectException)
                {
                    // При ошибке открытия соединения
                    toDebugTextBox("Ошибка при подключении к БД\r\n");
                }
            }
        }

        /// <summary>
        /// Действия при нажатии на кнопку ручной отправки запросов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void executeQueryButton_Click(object sender, EventArgs e)
        {
            // Создание соединения с БД с использованием строки подключения
            using (OracleConnection oracleConnection = new OracleConnection(oracleConnectionString))
            {
                try
                {
                    // Открытие соединения
                    oracleConnection.Open();
                    // Считывание введенного запроса
                    string queryString = queryTextBox.Text;
                    OracleCommand oracleCommand = new OracleCommand(queryString, oracleConnection);

                    try
                    {
                        // Выполнение запроса
                        oracleCommand.ExecuteNonQuery();
                        toDebugTextBox("Запрос успешно выполнен\r\n");
                    }
                    catch (Exception exception)
                    {
                        // При ошибке выполнения запроса
                        toDebugTextBox("Ошибка при выполнении запроса\r\n" + queryString + "\r\n" + exception.Message + "\r\n");
                    }
                }
                catch (Exception connectException)
                {
                    // При ошибке подключения
                    toDebugTextBox("Ошибка при подключении к БД\r\n");
                }
            }
        }

        /// <summary>
        /// Действия при нажатии на кнопку очистки окна вывода информации о работе программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearDebugTextBoxButton_Click(object sender, EventArgs e)
        {
            debugTextBox.Clear();
        }

        /// <summary>
        /// Действия при нажатии на кнопку очистки окна ручного ввода запросов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearQueryTextBox_Click(object sender, EventArgs e)
        {
            queryTextBox.Clear();
        }

        /// <summary>
        /// Функция, выполняющая выборку информации из таблиц БД и вывод выбранных данных
        /// </summary>
        /// <param name="table">Имя таблицы</param>
        /// <param name="conditions">Условия выбора в виде массива строк, каждая строка отвечает за условие на одно поле таблицы</param>
        private void selectFromTable(string table, string[] conditions)
        {
            // Создание соединения с БД с использованием строки подключения
            using (OracleConnection oracleConnection = new OracleConnection(oracleConnectionString))
            {
                try
                {
                    // Открытие соединения
                    oracleConnection.Open();
                    // Начало формирования запроса
                    string queryString = "SELECT * FROM " + table;
                    // Проверка, есть ли условия и на какие конкретно поля
                    bool noConditions = true;
                    for (int i = 0; i < conditions.Length && noConditions; ++i)
                    {
                        if (conditions[i] != "")
                        {
                            noConditions = false;
                        }
                    }

                    // При налачии условий
                    if (!(noConditions))
                    {
                        queryString += " WHERE";
                        bool andRequired = false;
                        switch (table)
                        {
                            // Добавление условий на поля таблиц в зависимости от таблиц и полей, на которые есть условия
                            case "users":
                                {
                                    if (conditions[0] != "")
                                    {
                                        queryString += " u_id = '" + conditions[0] + "'";
                                        andRequired = true;
                                    }

                                    if (conditions[1] != "")
                                    {
                                        if (andRequired) queryString += " AND";
                                        queryString += " u_f = '" + conditions[1] + "'";
                                        andRequired = true;
                                    }

                                    if (conditions[2] != "")
                                    {
                                        if (andRequired) queryString += " AND";
                                        queryString += " u_io = '" + conditions[2] + "'";
                                        andRequired = true;
                                    }

                                    if (conditions[3] != "")
                                    {
                                        if (andRequired) queryString += " AND";
                                        queryString += " u_post = '" + conditions[3] + "'";
                                    }

                                    break;
                                }

                            case "closets":
                                {
                                    if (conditions[0] != "")
                                    {
                                        queryString += " c_id = '" + conditions[0] + "'";
                                        andRequired = true;
                                    }

                                    if (conditions[1] != "")
                                    {
                                        if (andRequired) queryString += " AND";
                                        queryString += " c_building = '" + conditions[1] + "'";
                                        andRequired = true;
                                    }

                                    if (conditions[2] != "")
                                    {
                                        if (andRequired) queryString += " AND";
                                        queryString += " c_floor = '" + conditions[2] + "'";
                                        andRequired = true;
                                    }

                                    if (conditions[3] != "")
                                    {
                                        if (andRequired) queryString += " AND";
                                        queryString += " c_description = '" + conditions[3] + "'";
                                    }

                                    break;
                                }

                            case "material_values":
                                {
                                    if (conditions[0] != "")
                                    {
                                        queryString += " mv_id = '" + conditions[0] + "'";
                                        andRequired = true;
                                    }

                                    if (conditions[1] != "")
                                    {
                                        if (andRequired) queryString += " AND";
                                        queryString += " mv_description = '" + conditions[1] + "'";
                                        andRequired = true;
                                    }

                                    if (conditions[2] != "")
                                    {
                                        if (andRequired) queryString += " AND";
                                        queryString += " mv_closet = '" + conditions[2] + "'";
                                        andRequired = true;
                                    }

                                    break;
                                }

                            case "takenvalues_info":
                                {
                                    if (conditions[0] != "")
                                    {
                                        queryString += " u_id = '" + conditions[0] + "'";
                                        andRequired = true;
                                    }

                                    if (conditions[1] != "")
                                    {
                                        if (andRequired) queryString += " AND";
                                        queryString += " u_f = '" + conditions[1] + "'";
                                        andRequired = true;
                                    }

                                    if (conditions[2] != "")
                                    {
                                        if (andRequired) queryString += " AND";
                                        queryString += " u_io = '" + conditions[2] + "'";
                                        andRequired = true;
                                    }

                                    if (conditions[3] != "")
                                    {
                                        queryString += " u_post = '" + conditions[3] + "'";
                                        andRequired = true;
                                    }

                                    if (conditions[4] != "")
                                    {
                                        if (andRequired) queryString += " AND";
                                        queryString += " mv_id = '" + conditions[4] + "'";
                                        andRequired = true;
                                    }

                                    if (conditions[5] != "")
                                    {
                                        if (andRequired) queryString += " AND";
                                        queryString += " mv_description = '" + conditions[5] + "'";
                                        andRequired = true;
                                    }

                                    if (conditions[6] != "")
                                    {
                                        queryString += " mv_closet = '" + conditions[6] + "'";
                                        andRequired = true;
                                    }

                                    if (conditions[7] != "")
                                    {
                                        if (andRequired) queryString += " AND";
                                        queryString += " tv_take > '" + conditions[7] + "'";
                                        andRequired = true;
                                    }

                                    if (conditions[8] != "")
                                    {
                                        if (andRequired) queryString += " AND";
                                        queryString += " tv_take < '" + conditions[8] + "'";
                                        andRequired = true;
                                    }

                                    if (conditions[9] != "")
                                    {
                                        queryString += " tv_return > '" + conditions[9] + "'";
                                        andRequired = true;
                                    }

                                    if (conditions[10] != "")
                                    {
                                        if (andRequired) queryString += " AND";
                                        queryString += " tv_return < '" + conditions[10] + "'";
                                        andRequired = true;
                                    }

                                    break;
                                }
                        }
                    }
                    // Окончание формирования запроса
                    OracleCommand oracleCommand = new OracleCommand(queryString, oracleConnection);

                    try
                    {
                        // Выполнение запроса
                        OracleDataReader reader = oracleCommand.ExecuteReader();

                        switch (table)
                        {
                            // Изменение отображения информации в таблице в зависимости от введенных условий
                            case "users":
                                {
                                    while (usersView.Rows.Count != 0)
                                    {
                                        Invoke(new Action(() => usersView.Rows.Remove(usersView.Rows[usersView.Rows.Count - 1])));
                                    }

                                    break;
                                }

                            case "closets":
                                {
                                    while (closetsView.Rows.Count != 0)
                                    {
                                        Invoke(new Action(() => closetsView.Rows.Remove(closetsView.Rows[closetsView.Rows.Count - 1])));
                                    }

                                    break;
                                }

                            case "material_values":
                                {
                                    while (materialValuesView.Rows.Count != 0)
                                    {
                                        Invoke(new Action(() => materialValuesView.Rows.Remove(materialValuesView.Rows[materialValuesView.Rows.Count - 1])));
                                    }

                                    break;
                                }

                            case "takenvalues_info":
                                {
                                    while (takenValuesInfoView.Rows.Count != 0)
                                    {
                                        Invoke(new Action(() => takenValuesInfoView.Rows.Remove(takenValuesInfoView.Rows[takenValuesInfoView.Rows.Count - 1])));
                                    }

                                    break;
                                }
                        }

                        if (reader.HasRows)
                        {
                            // Заполнение нужной таблицы
                            while (reader.Read())
                            {
                                DataGridViewRow row = new DataGridViewRow();

                                switch (table)
                                {
                                    case "users":
                                        {
                                            row.CreateCells(usersView);

                                            row.Cells[0].Value = reader.GetValue(0);
                                            row.Cells[1].Value = reader.GetValue(1);
                                            row.Cells[2].Value = reader.GetValue(2);
                                            row.Cells[3].Value = reader.GetValue(3);

                                            Invoke(new Action(() => usersView.Rows.Add(row)));

                                            break;
                                        }

                                    case "closets":
                                        {
                                            row.CreateCells(closetsView);

                                            row.Cells[0].Value = reader.GetValue(0);
                                            row.Cells[1].Value = reader.GetValue(1);
                                            row.Cells[2].Value = reader.GetValue(2);
                                            row.Cells[3].Value = reader.GetValue(3);

                                            Invoke(new Action(() => closetsView.Rows.Add(row)));

                                            break;
                                        }

                                    case "material_values":
                                        {
                                            row.CreateCells(materialValuesView);

                                            row.Cells[0].Value = reader.GetValue(0);
                                            row.Cells[1].Value = reader.GetValue(1);
                                            row.Cells[2].Value = reader.GetValue(2);

                                            Invoke(new Action(() => materialValuesView.Rows.Add(row)));

                                            break;
                                        }

                                    case "takenvalues_info":
                                        {
                                            row.CreateCells(takenValuesInfoView);

                                            row.Cells[0].Value = reader.GetValue(0);
                                            row.Cells[1].Value = reader.GetValue(1);
                                            row.Cells[2].Value = reader.GetValue(2);
                                            row.Cells[3].Value = reader.GetValue(3);
                                            row.Cells[4].Value = reader.GetValue(4);
                                            row.Cells[5].Value = reader.GetValue(5);
                                            row.Cells[6].Value = reader.GetValue(6);
                                            row.Cells[7].Value = reader.GetValue(7);
                                            row.Cells[8].Value = reader.GetValue(8);

                                            Invoke(new Action(() => takenValuesInfoView.Rows.Add(row)));

                                            break;
                                        }
                                }
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                        // При ошибке выполнения запроса
                        toDebugTextBox("Ошибка при выполнении запроса\r\n" + queryString + "\r\n" + exception.Message + "\r\n");
                    }
                }
                catch (Exception connectException)
                {
                    // При ошибке подключения к БД
                    toDebugTextBox("Ошибка при подключении к БД\r\n");
                }
            }
        }

        /// <summary>
        /// Функция, выполняющая добавление информации в таблицу
        /// </summary>
        /// <param name="table">Имя таблицы</param>
        /// <param name="values">Данные для добавления в виде массива строк, каждая строка отвечает за одно поле таблицы</param>
        private void insertIntoTable(string table, string[] values)
        {
            // Создание подключения с БД с использованием строки подключения
            using (OracleConnection oracleConnection = new OracleConnection(oracleConnectionString))
            {
                try
                {
                    // Открытие соединения
                    oracleConnection.Open();
                    // Формирование запроса
                    string queryString = "INSERT INTO " + table + " VALUES (";
                    for (int i = 0; i < values.Length; ++i)
                    {
                        if (i != 0)
                        {
                            queryString += ", ";
                        }
                        queryString += "'" + values[i] + "'";
                    }
                    queryString += ")";

                    OracleCommand oracleCommand = new OracleCommand(queryString, oracleConnection);

                    try
                    {
                        // Выполнение запроса
                        oracleCommand.ExecuteNonQuery();    
                    }
                    catch (Exception exception)
                    {
                        // При ошибке выполнения запроса
                        toDebugTextBox("Ошибка при выполнении запроса\r\n" + queryString + "\r\n" + exception.Message + "\r\n");
                    }
                }
                catch (Exception connectException)
                {
                    // При ошибке подключения к БД
                    toDebugTextBox("Ошибка при подключении к БД\r\n");
                }
            }
        }

        /// <summary>
        /// Функция, выполняющая изменение информации в таблице
        /// </summary>
        /// <param name="table">Имя таблицы</param>
        /// <param name="oldValues">Старые значения полей в виде массива строк</param>
        /// <param name="newValues">Новые значения полей в виде массива строк</param>
        private void updateTable(string table, string[] oldValues, string[] newValues)
        {
            // Проверка на наличие изменений
            bool noChanges = true;
            bool[] changes = new bool[oldValues.Length];

            for (int i = 0; i < oldValues.Length; ++i)
            {
                if (oldValues[i] == newValues[i])
                {
                    changes[i] = false;
                }
                else
                {
                    changes[i] = true;
                    noChanges = false;
                }
            }

            if (!(noChanges))
            {
                // Создание соединения с БД с использованием строки подключения
                using (OracleConnection oracleConnection = new OracleConnection(oracleConnectionString))
                {
                    try
                    {
                        // Открытие соединения
                        oracleConnection.Open();
                        OracleCommand cmd;

                        switch (table)
                        {
                            // Формирование запроса в зависимости от таблицы и изменившихся полей
                            case "users":
                                {
                                    if (changes[0])
                                    {
                                        insertIntoTable("users", newValues);
                                        cmd = new OracleCommand("UPDATE taken_values SET tv_user = '" + newValues[0] + "' WHERE tv_user = '" + oldValues[0] + "'", oracleConnection);
                                        cmd.ExecuteNonQuery();
                                        cmd = new OracleCommand("DELETE FROM users WHERE u_id = '" + oldValues[0] + "'", oracleConnection);
                                        cmd.ExecuteNonQuery();                                        
                                    }
                                    else
                                    {
                                        cmd = new OracleCommand("UPDATE users set u_f = '" + newValues[1] + "', u_io = '" + newValues[2] + "', u_post = '" + newValues[3] + "' WHERE u_id = '" + oldValues[0] + "'", oracleConnection);
                                        cmd.ExecuteNonQuery();
                                    }

                                    break;
                                }

                            case "closets":
                                {
                                    if (changes[0])
                                    {
                                        insertIntoTable("closets", newValues);
                                        cmd = new OracleCommand("UPDATE material_values SET mv_closet = '" + newValues[0] + "' WHERE mv_closet = '" + oldValues[0] + "'", oracleConnection);
                                        cmd.ExecuteNonQuery();
                                        cmd = new OracleCommand("DELETE FROM closets WHERE c_id = '" + oldValues[0] + "'", oracleConnection);
                                        cmd.ExecuteNonQuery();
                                    }
                                    else
                                    {
                                        cmd = new OracleCommand("UPDATE closets SET c_building = '" + newValues[1] + "', c_floor = '" + newValues[2] + "', c_description = '" + newValues[3] + "' WHERE c_id = '" + oldValues[0] + "'", oracleConnection);
                                        cmd.ExecuteNonQuery();
                                    }

                                    break;
                                }

                            case "material_values":
                                {
                                    if (changes[0])
                                    {
                                        insertIntoTable("material_values", newValues);
                                        cmd = new OracleCommand("UPDATE taken_values SET tv_value = '" + newValues[0] + "' WHERE tv_value = '" + oldValues[0] + "'", oracleConnection);
                                        cmd.ExecuteNonQuery();
                                        cmd = new OracleCommand("DELETE FROM material_values WHERE mv_id = '" + oldValues[0] + "'", oracleConnection);
                                        cmd.ExecuteNonQuery();
                                    }
                                    else
                                    {
                                        cmd = new OracleCommand("UPDATE material_values SET mv_description = '" + newValues[1] + "', mv_closet = '" + newValues[2] + "' WHERE mv_id = '" + oldValues[0] + "'", oracleConnection);
                                        cmd.ExecuteNonQuery();
                                    }

                                    break;
                                }

                            case "taken_values":
                                {
                                    cmd = new OracleCommand("UPDATE taken_values SET tv_return = sysdate WHERE tv_return IS NULL and tv_user = '" + oldValues[0] + "' and tv_value = '" + oldValues[1] + "'", oracleConnection);
                                    cmd.ExecuteNonQuery();
                                    break;
                                }
                        }
                    }
                    catch (Exception connectException)
                    {
                        // При ошибке выполнения
                        toDebugTextBox("Ошибка при подключении к БД или выполнении запроса типа UPDATE\r\n");
                    }
                }
            }
        }

        /// <summary>
        /// Функция, выполняющая удаление строк из таблиц
        /// </summary>
        /// <param name="table">Имя таблицы</param>
        /// <param name="rows">Коллекция строк, которые нужно удалить</param>
        private void deleteFromTable(string table, DataGridViewSelectedRowCollection rows)
        {
            // Создание подключения к БД с использованием строки подключения
            using (OracleConnection oracleConnection = new OracleConnection(oracleConnectionString))
            {
                try
                {
                    // Открытие соединения с БД
                    oracleConnection.Open();
                    OracleCommand cmd;
                    // Последовательное удаление указанных строк указанной таблицы
                    foreach (DataGridViewRow row in rows)
                    {
                        switch (table)
                        {
                            case "users":
                                {
                                    cmd = new OracleCommand("DELETE FROM taken_values WHERE tv_user = '" + row.Cells[0].Value.ToString() + "'");
                                    cmd.ExecuteNonQuery();
                                    cmd = new OracleCommand("DELETE FROM users WHERE u_id = '" + row.Cells[0].Value.ToString() + "'");
                                    cmd.ExecuteNonQuery();
                                    break;
                                }

                            case "closets":
                                {
                                    cmd = new OracleCommand("DELETE FROM material_values WHERE mv_closet = '" + row.Cells[0].Value.ToString() + "'");
                                    cmd.ExecuteNonQuery();
                                    cmd = new OracleCommand("DELETE FROM closets WHERE c_id = '" + row.Cells[0].Value.ToString() + "'");
                                    cmd.ExecuteNonQuery();
                                    break;
                                }

                            case "material_values":
                                {
                                    cmd = new OracleCommand("DELETE FROM taken_values WHERE tv_value = '" + row.Cells[0].Value.ToString() + "'");
                                    cmd.ExecuteNonQuery();
                                    cmd = new OracleCommand("DELETE FROM material_values WHERE mv_id = '" + row.Cells[0].Value.ToString() + "'");
                                    cmd.ExecuteNonQuery();
                                    break;
                                }

                            case "taken_values":
                                {
                                    if (row.Cells[8].Value.ToString() != "")
                                    {
                                        string queryString = "DELETE FROM taken_values WHERE" +
                                                             " tv_user = '" + row.Cells[0].Value.ToString() + "'" +
                                                             " and tv_value = '" + row.Cells[4].Value.ToString() + "'" +
                                                             " and to_char(tv_take) = '" + row.Cells[7].Value.ToString() + "'" +
                                                             " and to_char(tv_return) = '" + row.Cells[8].Value.ToString() + "'";
                                        cmd = new OracleCommand(queryString, oracleConnection);
                                        cmd.ExecuteNonQuery();
                                    }
                                    break;
                                }
                        }
                    }
                }
                catch (Exception connectException)
                {
                    // При ошибке
                    toDebugTextBox("Ошибка при подключении к БД или выполнении запроса типа DELETE\r\n");
                }
            }
        }

        /// <summary>
        /// Действия при нажатии на кнопку ОК на вкладке Взятые вещи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void takenValuesInfoCommitButton_Click(object sender, EventArgs e)
        {
            // Если выбрана опция Просмотр
            if (takenValuesInfoSelectRadioButton.Checked)
            {
                selectFromTable("takenvalues_info", getTakenValuesInfoFields());
            }
            // Если выбрана опция Удаление
            if (takenValuesInfoDeleteRadioButton.Checked)
            {
                deleteFromTable("taken_values", takenValuesInfoView.SelectedRows);
                if (autoRefreshTakenValuesInfoCheckBox.Checked) selectFromTable("takenvalues_info", getTakenValuesInfoFields());
            }
        }

        /// <summary>
        /// Действия при нажатии на кнопку Обновить на вкладке взятые вещи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshTakenValuesInfoViewButton_Click(object sender, EventArgs e)
        {
            selectFromTable("takenvalues_info", getTakenValuesInfoFields());
        }

        /// <summary>
        /// Действия при выборе опции Автообновление на вкладке Взятые вещи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoRefreshTakenValuesInfoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (autoRefreshTakenValuesInfoCheckBox.Checked)
            {
                refreshTakenValuesInfoViewButton.Enabled = false;
                selectFromTable("takenvalues_info", getTakenValuesInfoFields());
            }
            else
            {
                refreshTakenValuesInfoViewButton.Enabled = true;
            }
        }

        /// <summary>
        /// Действия при нажатии на кнопку ОК на вкладке Шкафы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closetsCommitButton_Click(object sender, EventArgs e)
        {
            // Если выбрана опция Просмотр
            if (closetsSelectRadioButton.Checked)
            {
                selectFromTable("closets", getClosetsFields());
            }
            // Если выбрана опция Добавление
            if (closetsInsertRadioButton.Checked)
            {
                insertIntoTable("closets", getClosetsFields());

                if (autoRefreshClosetsCheckBox.Checked)
                {
                    selectFromTable("closets", getClosetsFields());
                }
            }
            // Если выбрана опция Редактирование
            if (closetsUpdateRadioButton.Checked)
            {
                int currentRow = closetsView.CurrentRow.Index;
                if (currentRow != -1)
                {
                    string[] oldValues = {closetsView.Rows[currentRow].Cells[0].Value.ToString(), closetsView.Rows[currentRow].Cells[1].Value.ToString(),
                                          closetsView.Rows[currentRow].Cells[2].Value.ToString(),closetsView.Rows[currentRow].Cells[3].Value.ToString()};
                    string[] newValues = getClosetsFields();
                    updateTable("closets", oldValues, newValues);

                    if (autoRefreshClosetsCheckBox.Checked) selectFromTable("closets", getClosetsFields());
                    if (autoRefreshMaterialValuesCheckBox.Checked) selectFromTable("material_values", getMaterialValuesFields());
                    if (autoRefreshTakenValuesInfoCheckBox.Checked) selectFromTable("takenvalues_info", getTakenValuesInfoFields());
                }
            }
            // Если выбрана опция удаление
            if (closetsDeleteRadioButton.Checked)
            {
                deleteFromTable("closets", closetsView.SelectedRows);
                if (autoRefreshClosetsCheckBox.Checked) selectFromTable("closets", getClosetsFields());
                if (autoRefreshMaterialValuesCheckBox.Checked) selectFromTable("material_values", getMaterialValuesFields());
                if (autoRefreshTakenValuesInfoCheckBox.Checked) selectFromTable("takenvalues_info", getTakenValuesInfoFields());
            }
        }

        /// <summary>
        /// Действия при нажатии на кнопку Обновить на вкладке Шкафы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshClosetsButton_Click(object sender, EventArgs e)
        {
            selectFromTable("closets", getClosetsFields());
        }

        /// <summary>
        /// Действия при выборе опции Автообновление на вкладке Шкафы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoRefreshClosetsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (autoRefreshClosetsCheckBox.Checked)
            {
                refreshClosetsButton.Enabled = false;
                selectFromTable("closets", getClosetsFields());
            }
            else
            {
                refreshClosetsButton.Enabled = true;
            }
        }

        /// <summary>
        /// Действия при нажатии на кнопку ОК на вкладке Ценности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialValuesCommitButton_Click(object sender, EventArgs e)
        {
            // Если выбрана опция Просмотр
            if (materialValuesSelectRadioButton.Checked)
            {
                selectFromTable("material_values", getMaterialValuesFields());
            }
            // Если выбрано опция Добавление
            if (materialValuesInsertRadioButton.Checked)
            {
                insertIntoTable("material_values", getMaterialValuesFields());

                if (autoRefreshMaterialValuesCheckBox.Checked)
                {
                    selectFromTable("material_values", getMaterialValuesFields());
                }
            }
            // Если выбрана опция Редактирование
            if (materialValuesUpdateRadioButton.Checked)
            {
                int currentRow = materialValuesView.CurrentRow.Index;
                if (currentRow != -1)
                {
                    string[] oldValues = {materialValuesView.Rows[currentRow].Cells[0].Value.ToString(), materialValuesView.Rows[currentRow].Cells[1].Value.ToString(),
                                      materialValuesView.Rows[currentRow].Cells[2].Value.ToString()};
                    string[] newValues = getMaterialValuesFields();
                    updateTable("material_values", oldValues, newValues);

                    if (autoRefreshMaterialValuesCheckBox.Checked) selectFromTable("material_values", getMaterialValuesFields());
                    if (autoRefreshTakenValuesInfoCheckBox.Checked) selectFromTable("takenvalues_info", getTakenValuesInfoFields());
                }
            }
            // Если выбрана опция Удаление
            if (materialValuesDeleteRadioButton.Checked)
            {
                deleteFromTable("material_values", materialValuesView.SelectedRows);
                if (autoRefreshMaterialValuesCheckBox.Checked) selectFromTable("material_values", getMaterialValuesFields());
                if (autoRefreshTakenValuesInfoCheckBox.Checked) selectFromTable("takenvalues_info", getTakenValuesInfoFields());
            }
        }

        /// <summary>
        /// Функция для получения значений, введенных в покна ввода текста на вкладке Пользователи
        /// </summary>
        /// <returns>Возвращает массив строк, содержащих значения окон для ввода текста</returns>
        private string[] getUsersFields()
        {
            string[] fields = { usersIdTextBox.Text, usersFTextBox.Text, usersIoTextBox.Text, usersPostTextBox.Text };
            return fields;
        }

        /// <summary>
        /// Функция для получения значений, введенных в покна ввода текста на вкладке Шкафы
        /// </summary>
        /// <returns>Возвращает массив строк, содержащих значения окон для ввода текста</returns>
        private string[] getClosetsFields()
        {
            string[] fields = {closetsIdTextBox.Text, closetsBuildingTextBox.Text,
                                       closetsFloorTextBox.Text, closetsDescriptionTextBox.Text};
            return fields;
        }

        /// <summary>
        /// Функция для получения значений, введенных в покна ввода текста на вкладке Ценности
        /// </summary>
        /// <returns>Возвращает массив строк, содержащих значения окон для ввода текста</returns>
        private string[] getMaterialValuesFields()
        {
            string[] fields = { materialValuesIdTextBox.Text, materialValuesDescriptionTextBox.Text, materialValuesClosetIdTextBox.Text };
            return fields;
        }

        /// <summary>
        /// Функция для получения значений, введенных в покна ввода текста на вкладке Взятые вещи
        /// </summary>
        /// <returns>Возвращает массив строк, содержащих значения окон для ввода текста</returns>
        private string[] getTakenValuesInfoFields()
        {
            string[] fields = {takenValuesInfoUidTextBox.Text, takenValuesInfoFTextBox.Text, takenValuesInfoIoTextBox.Text,
                                   takenValuesInfoPostTextBox.Text, takenValuesInfoVidTextBox.Text, takenValuesInfoVdescriptionTextBox.Text,
                                   takenValuesInfoCidTextBox.Text, takenValuesInfoTakeFromTextBox.Text, takenValuesInfoTakeToTextBox.Text,
                                   takenValuesInfoReturnFromTextBox.Text, takenValuesInfoReturnToTextBox.Text};
            return fields;
        }

        /// <summary>
        /// Действия при нажатии кнопки Обновить на вкладке Ценности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshMaterialValuesButton_Click(object sender, EventArgs e)
        {
            selectFromTable("material_values", getMaterialValuesFields());
        }

        /// <summary>
        /// Действия при выборе опции Автообновление на вкладке Ценности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoRefreshMaterialValuesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (autoRefreshMaterialValuesCheckBox.Checked)
            {
                refreshMaterialValuesButton.Enabled = false;
                selectFromTable("material_values", getMaterialValuesFields());
            }
            else
            {
                refreshMaterialValuesButton.Enabled = true;
            }
        }

        /// <summary>
        /// Действия при нажатии кнопки ОК на вкладке Пользователи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void usersCommitButton_Click(object sender, EventArgs e)
        {
            // Если выбрана опция Просмотр
            if (usersSelectRadioButton.Checked)
            {
                selectFromTable("users", getUsersFields());
            }
            // Если выбрана опция Добавление
            if (usersInsertRadioButton.Checked)
            {
                insertIntoTable("users", getUsersFields());

                if (autoRefreshUsersView.Checked)
                {
                    selectFromTable("users", getUsersFields());
                }
            }
            // Если выбрана опция Редактирование
            if (usersUpdateRadioButton.Checked)
            {
                int currentRow = usersView.CurrentRow.Index;
                if (currentRow != -1)
                {
                    string[] oldValues = {usersView.Rows[currentRow].Cells[0].Value.ToString(), usersView.Rows[currentRow].Cells[1].Value.ToString(),
                                      usersView.Rows[currentRow].Cells[2].Value.ToString(),usersView.Rows[currentRow].Cells[3].Value.ToString()};
                    string[] newValues = getUsersFields();
                    updateTable("users", oldValues, newValues);

                    if (autoRefreshUsersView.Checked) selectFromTable("users", getUsersFields());
                    if (autoRefreshTakenValuesInfoCheckBox.Checked) selectFromTable("takenvalues_info", getTakenValuesInfoFields());
                }
            }
            // Если выбрана опция Удаление
            if (usersDeleteRadioButton.Checked)
            {
                deleteFromTable("users", usersView.SelectedRows);
                if (autoRefreshUsersView.Checked) selectFromTable("users", getUsersFields());
                if (autoRefreshTakenValuesInfoCheckBox.Checked) selectFromTable("takenvalues_info", getTakenValuesInfoFields());
            }
        }

        /// <summary>
        /// Действия при нажатии кнопки Обновить на вкладке Пользователи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshUsersView_Click(object sender, EventArgs e)
        {
            selectFromTable("users", getUsersFields());
        }

        /// <summary>
        ///  Действия при выборе опции Автообновление на вкладке Пользователи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoRefreshUsersView_CheckedChanged(object sender, EventArgs e)
        {
            if (autoRefreshUsersView.Checked)
            {
                refreshUsersView.Enabled = false;
                selectFromTable("users", getUsersFields());
            }
            else
            {
                refreshUsersView.Enabled = true;
            }
        }

        // Серия функций, описывающих действия при выборе опций Просмотр, Добавление, Редактирование, Удаление на вкладке Шкафы
        private void closetsSelectRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            closetsIdTextBox.Clear();
            closetsBuildingTextBox.Clear();
            closetsFloorTextBox.Clear();
            closetsDescriptionTextBox.Clear();
        }

        private void closetsInsertRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            closetsIdTextBox.Clear();
            closetsBuildingTextBox.Clear();
            closetsFloorTextBox.Clear();
            closetsDescriptionTextBox.Clear();
        }

        private void closetsUpdateRadioButton_CheckedChanged(object sender, EventArgs e)
        {                   
            if (closetsUpdateRadioButton.Checked)
            {
                closetsView.MultiSelect = false;
                closetsView.Rows[closetsView.CurrentRow.Index].Selected = false;
            }
            else
            {
                closetsView.MultiSelect = true;
            }

            closetsIdTextBox.Clear();
            closetsBuildingTextBox.Clear();
            closetsFloorTextBox.Clear();
            closetsDescriptionTextBox.Clear();
        }

        private void closetsDeleteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            closetsIdTextBox.Clear();
            closetsBuildingTextBox.Clear();
            closetsFloorTextBox.Clear();
            closetsDescriptionTextBox.Clear();
        }

        // Серия функций, описывающих действия при выборе опций Просмотр, Добавление, Редактирование, Удаление на вкладке Ценности
        private void materialValuesSelectRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            materialValuesIdTextBox.Clear();
            materialValuesDescriptionTextBox.Clear();
            materialValuesClosetIdTextBox.Clear();
        }

        private void materialValuesInsertRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            materialValuesIdTextBox.Clear();
            materialValuesDescriptionTextBox.Clear();
            materialValuesClosetIdTextBox.Clear();
        }

        private void materialValuesUpdateRadioButton_CheckedChanged(object sender, EventArgs e)
        {          
            if (materialValuesUpdateRadioButton.Checked)
            {
                materialValuesView.MultiSelect = false;
                materialValuesView.Rows[materialValuesView.CurrentRow.Index].Selected = false;
            }
            else
            {
                materialValuesView.MultiSelect = true;
            }

            materialValuesIdTextBox.Clear();
            materialValuesDescriptionTextBox.Clear();
            materialValuesClosetIdTextBox.Clear();
        }

        private void materialValuesDeleteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            materialValuesIdTextBox.Clear();
            materialValuesDescriptionTextBox.Clear();
            materialValuesClosetIdTextBox.Clear();
        }

        // Серия функций, описывающих действия при выборе опций Просмотр, Добавление, Редактирование, Удаление на вкладке Пользователи
        private void usersSelectRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            usersIdTextBox.Clear();
            usersFTextBox.Clear();
            usersIoTextBox.Clear();
            usersPostTextBox.Clear();
        }

        private void usersInsertRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            usersIdTextBox.Clear();
            usersFTextBox.Clear();
            usersIoTextBox.Clear();
            usersPostTextBox.Clear();
        }

        private void usersUpdateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (usersUpdateRadioButton.Checked)
            {
                usersView.MultiSelect = false;
                usersView.Rows[usersView.CurrentRow.Index].Selected = false;
            }
            else
            {
                usersView.MultiSelect = true;
            }

            usersIdTextBox.Clear();
            usersFTextBox.Clear();
            usersIoTextBox.Clear();
            usersPostTextBox.Clear();
        }

        private void usersDeleteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            usersIdTextBox.Clear();
            usersFTextBox.Clear();
            usersIoTextBox.Clear();
            usersPostTextBox.Clear();
        }

        // Серия функций, описывающих действия при выборе опций Просмотр, Добавление, Редактирование, Удаление на вкладке Взятые вещи
        private void materialValuesView_SelectionChanged(object sender, EventArgs e)
        {
            if (materialValuesUpdateRadioButton.Checked)
            {
                try
                {
                    int currentRow = materialValuesView.CurrentRow.Index;
                    if (currentRow != -1)
                    {
                        materialValuesIdTextBox.Text = materialValuesView.Rows[currentRow].Cells[0].Value.ToString();
                        materialValuesDescriptionTextBox.Text = materialValuesView.Rows[currentRow].Cells[1].Value.ToString();
                        materialValuesClosetIdTextBox.Text = materialValuesView.Rows[currentRow].Cells[2].Value.ToString();
                    }
                }
                catch (Exception exception)
                {

                }
            }
        }

        private void usersView_SelectionChanged(object sender, EventArgs e)
        {
            if (usersUpdateRadioButton.Checked)
            {
                try
                {
                    int currentRow = usersView.CurrentRow.Index;
                    if (currentRow != -1)
                    {
                        usersIdTextBox.Text = usersView.Rows[currentRow].Cells[0].Value.ToString();
                        usersFTextBox.Text = usersView.Rows[currentRow].Cells[1].Value.ToString();
                        usersIoTextBox.Text = usersView.Rows[currentRow].Cells[2].Value.ToString();
                        usersPostTextBox.Text = usersView.Rows[currentRow].Cells[3].Value.ToString();
                    }
                }
                catch (Exception exception)
                {

                }
            }
        }

        private void closetsView_SelectionChanged(object sender, EventArgs e)
        {
            if (closetsUpdateRadioButton.Checked)
            {
                try
                {
                    int currentRow = closetsView.CurrentRow.Index;
                    if (currentRow != -1)
                    {
                            closetsIdTextBox.Text = closetsView.Rows[currentRow].Cells[0].Value.ToString();
                            closetsBuildingTextBox.Text = closetsView.Rows[currentRow].Cells[1].Value.ToString();
                            closetsFloorTextBox.Text = closetsView.Rows[currentRow].Cells[2].Value.ToString();
                            closetsDescriptionTextBox.Text = closetsView.Rows[currentRow].Cells[3].Value.ToString();
                    }
                }
                catch (Exception exception)
                {

                }
            }
        }
    }
}
