namespace VS_Prototype_v0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chosenPortComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.debugTextBox = new System.Windows.Forms.TextBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.connectionStateLabel = new System.Windows.Forms.Label();
            this.pagesControl = new System.Windows.Forms.TabControl();
            this.connectionPage = new System.Windows.Forms.TabPage();
            this.clearQueryTextBox = new System.Windows.Forms.Button();
            this.clearDebugTextBoxButton = new System.Windows.Forms.Button();
            this.executeQueryButton = new System.Windows.Forms.Button();
            this.checkDbConnectionButton = new System.Windows.Forms.Button();
            this.queryTextBox = new System.Windows.Forms.TextBox();
            this.takenValuesInfoPage = new System.Windows.Forms.TabPage();
            this.takenValuesInfoDeleteRadioButton = new System.Windows.Forms.RadioButton();
            this.takenValuesInfoSelectRadioButton = new System.Windows.Forms.RadioButton();
            this.takenValuesInfoReturnToLabel = new System.Windows.Forms.Label();
            this.takenValuesInfoReturnFromLabel = new System.Windows.Forms.Label();
            this.takenValuesInfoTakeToLabel = new System.Windows.Forms.Label();
            this.takenValuesInfoTakeFromLabel = new System.Windows.Forms.Label();
            this.takenValuesInfoVdescriptionLabel = new System.Windows.Forms.Label();
            this.takenValuesInfoCidLabel = new System.Windows.Forms.Label();
            this.takenValuesInfoVidLabel = new System.Windows.Forms.Label();
            this.takenValuesInfoIoLabel = new System.Windows.Forms.Label();
            this.takenValuesInfoFLabel = new System.Windows.Forms.Label();
            this.takenValuesInfoPostLabel = new System.Windows.Forms.Label();
            this.takenValuesInfoUidLabel = new System.Windows.Forms.Label();
            this.takenValuesInfoCommitButton = new System.Windows.Forms.Button();
            this.takenValuesInfoReturnToTextBox = new System.Windows.Forms.TextBox();
            this.takenValuesInfoReturnFromTextBox = new System.Windows.Forms.TextBox();
            this.takenValuesInfoTakeToTextBox = new System.Windows.Forms.TextBox();
            this.takenValuesInfoTakeFromTextBox = new System.Windows.Forms.TextBox();
            this.takenValuesInfoVdescriptionTextBox = new System.Windows.Forms.TextBox();
            this.takenValuesInfoCidTextBox = new System.Windows.Forms.TextBox();
            this.takenValuesInfoVidTextBox = new System.Windows.Forms.TextBox();
            this.takenValuesInfoIoTextBox = new System.Windows.Forms.TextBox();
            this.takenValuesInfoFTextBox = new System.Windows.Forms.TextBox();
            this.takenValuesInfoPostTextBox = new System.Windows.Forms.TextBox();
            this.takenValuesInfoUidTextBox = new System.Windows.Forms.TextBox();
            this.autoRefreshTakenValuesInfoCheckBox = new System.Windows.Forms.CheckBox();
            this.refreshTakenValuesInfoViewButton = new System.Windows.Forms.Button();
            this.takenValuesInfoView = new System.Windows.Forms.DataGridView();
            this.U_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_IO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_POST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MV_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MV_DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MV_CLOSET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TV_TAKE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TV_RETURN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closetsPage = new System.Windows.Forms.TabPage();
            this.closetsCommitButton = new System.Windows.Forms.Button();
            this.closetsDeleteRadioButton = new System.Windows.Forms.RadioButton();
            this.closetsUpdateRadioButton = new System.Windows.Forms.RadioButton();
            this.closetsInsertRadioButton = new System.Windows.Forms.RadioButton();
            this.closetsSelectRadioButton = new System.Windows.Forms.RadioButton();
            this.closetsDescriptionLabel = new System.Windows.Forms.Label();
            this.closetsFloorLabel = new System.Windows.Forms.Label();
            this.closetsBuildingLabel = new System.Windows.Forms.Label();
            this.closetsIdLabel = new System.Windows.Forms.Label();
            this.closetsDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.closetsFloorTextBox = new System.Windows.Forms.TextBox();
            this.closetsBuildingTextBox = new System.Windows.Forms.TextBox();
            this.closetsIdTextBox = new System.Windows.Forms.TextBox();
            this.autoRefreshClosetsCheckBox = new System.Windows.Forms.CheckBox();
            this.refreshClosetsButton = new System.Windows.Forms.Button();
            this.closetsView = new System.Windows.Forms.DataGridView();
            this.C_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_BUILDING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_FLOOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialValuesPage = new System.Windows.Forms.TabPage();
            this.materialValuesSelectRadioButton = new System.Windows.Forms.RadioButton();
            this.materialValuesInsertRadioButton = new System.Windows.Forms.RadioButton();
            this.materialValuesUpdateRadioButton = new System.Windows.Forms.RadioButton();
            this.materialValuesDeleteRadioButton = new System.Windows.Forms.RadioButton();
            this.MaterialValuesClosetIdLabel = new System.Windows.Forms.Label();
            this.materialValuesDescriptionLabel = new System.Windows.Forms.Label();
            this.materialValuesIdLabel = new System.Windows.Forms.Label();
            this.materialValuesIdTextBox = new System.Windows.Forms.TextBox();
            this.materialValuesDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.materialValuesClosetIdTextBox = new System.Windows.Forms.TextBox();
            this.materialValuesCommitButton = new System.Windows.Forms.Button();
            this.refreshMaterialValuesButton = new System.Windows.Forms.Button();
            this.autoRefreshMaterialValuesCheckBox = new System.Windows.Forms.CheckBox();
            this.materialValuesView = new System.Windows.Forms.DataGridView();
            this.mv__id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mv__description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mv__closet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersPage = new System.Windows.Forms.TabPage();
            this.usersDeleteRadioButton = new System.Windows.Forms.RadioButton();
            this.usersUpdateRadioButton = new System.Windows.Forms.RadioButton();
            this.usersInsertRadioButton = new System.Windows.Forms.RadioButton();
            this.usersSelectRadioButton = new System.Windows.Forms.RadioButton();
            this.usersCommitButton = new System.Windows.Forms.Button();
            this.refreshUsersView = new System.Windows.Forms.Button();
            this.usersPostLabel = new System.Windows.Forms.Label();
            this.usersIoLabel = new System.Windows.Forms.Label();
            this.usersFLabel = new System.Windows.Forms.Label();
            this.usersIdLabel = new System.Windows.Forms.Label();
            this.usersPostTextBox = new System.Windows.Forms.TextBox();
            this.usersIoTextBox = new System.Windows.Forms.TextBox();
            this.usersFTextBox = new System.Windows.Forms.TextBox();
            this.usersIdTextBox = new System.Windows.Forms.TextBox();
            this.autoRefreshUsersView = new System.Windows.Forms.CheckBox();
            this.usersView = new System.Windows.Forms.DataGridView();
            this.U__ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U__F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U__IO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U__POST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAKENVALUESINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new VS_Prototype_v0.DataSet1();
            this.tAKENVALUES_INFOTableAdapter = new VS_Prototype_v0.DataSet1TableAdapters.TAKENVALUES_INFOTableAdapter();
            this.pagesControl.SuspendLayout();
            this.connectionPage.SuspendLayout();
            this.takenValuesInfoPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.takenValuesInfoView)).BeginInit();
            this.closetsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closetsView)).BeginInit();
            this.materialValuesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialValuesView)).BeginInit();
            this.usersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKENVALUESINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // chosenPortComboBox
            // 
            this.chosenPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chosenPortComboBox.FormattingEnabled = true;
            this.chosenPortComboBox.Location = new System.Drawing.Point(18, 114);
            this.chosenPortComboBox.Name = "chosenPortComboBox";
            this.chosenPortComboBox.Size = new System.Drawing.Size(119, 21);
            this.chosenPortComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбранный COM порт";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(18, 188);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(119, 23);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Подключение";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(18, 218);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(119, 23);
            this.disconnectButton.TabIndex = 4;
            this.disconnectButton.Text = "Отключение";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // debugTextBox
            // 
            this.debugTextBox.AcceptsReturn = true;
            this.debugTextBox.AcceptsTab = true;
            this.debugTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.debugTextBox.Location = new System.Drawing.Point(154, 16);
            this.debugTextBox.Multiline = true;
            this.debugTextBox.Name = "debugTextBox";
            this.debugTextBox.ReadOnly = true;
            this.debugTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debugTextBox.Size = new System.Drawing.Size(388, 367);
            this.debugTextBox.TabIndex = 5;
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // connectionStateLabel
            // 
            this.connectionStateLabel.BackColor = System.Drawing.Color.Red;
            this.connectionStateLabel.Location = new System.Drawing.Point(18, 152);
            this.connectionStateLabel.Name = "connectionStateLabel";
            this.connectionStateLabel.Size = new System.Drawing.Size(119, 23);
            this.connectionStateLabel.TabIndex = 6;
            this.connectionStateLabel.Text = "Отключено";
            this.connectionStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pagesControl
            // 
            this.pagesControl.Controls.Add(this.connectionPage);
            this.pagesControl.Controls.Add(this.takenValuesInfoPage);
            this.pagesControl.Controls.Add(this.closetsPage);
            this.pagesControl.Controls.Add(this.materialValuesPage);
            this.pagesControl.Controls.Add(this.usersPage);
            this.pagesControl.Location = new System.Drawing.Point(12, 12);
            this.pagesControl.Name = "pagesControl";
            this.pagesControl.SelectedIndex = 0;
            this.pagesControl.Size = new System.Drawing.Size(982, 505);
            this.pagesControl.TabIndex = 7;
            // 
            // connectionPage
            // 
            this.connectionPage.Controls.Add(this.clearQueryTextBox);
            this.connectionPage.Controls.Add(this.clearDebugTextBoxButton);
            this.connectionPage.Controls.Add(this.executeQueryButton);
            this.connectionPage.Controls.Add(this.checkDbConnectionButton);
            this.connectionPage.Controls.Add(this.queryTextBox);
            this.connectionPage.Controls.Add(this.connectionStateLabel);
            this.connectionPage.Controls.Add(this.debugTextBox);
            this.connectionPage.Controls.Add(this.chosenPortComboBox);
            this.connectionPage.Controls.Add(this.label1);
            this.connectionPage.Controls.Add(this.disconnectButton);
            this.connectionPage.Controls.Add(this.connectButton);
            this.connectionPage.Location = new System.Drawing.Point(4, 22);
            this.connectionPage.Name = "connectionPage";
            this.connectionPage.Padding = new System.Windows.Forms.Padding(3);
            this.connectionPage.Size = new System.Drawing.Size(974, 479);
            this.connectionPage.TabIndex = 0;
            this.connectionPage.Text = "Управление";
            this.connectionPage.UseVisualStyleBackColor = true;
            // 
            // clearQueryTextBox
            // 
            this.clearQueryTextBox.Location = new System.Drawing.Point(709, 247);
            this.clearQueryTextBox.Name = "clearQueryTextBox";
            this.clearQueryTextBox.Size = new System.Drawing.Size(119, 23);
            this.clearQueryTextBox.TabIndex = 11;
            this.clearQueryTextBox.Text = "Очистить";
            this.clearQueryTextBox.UseVisualStyleBackColor = true;
            this.clearQueryTextBox.Click += new System.EventHandler(this.clearQueryTextBox_Click);
            // 
            // clearDebugTextBoxButton
            // 
            this.clearDebugTextBoxButton.Location = new System.Drawing.Point(283, 389);
            this.clearDebugTextBoxButton.Name = "clearDebugTextBoxButton";
            this.clearDebugTextBoxButton.Size = new System.Drawing.Size(119, 23);
            this.clearDebugTextBoxButton.TabIndex = 10;
            this.clearDebugTextBoxButton.Text = "Очистить";
            this.clearDebugTextBoxButton.UseVisualStyleBackColor = true;
            this.clearDebugTextBoxButton.Click += new System.EventHandler(this.clearDebugTextBoxButton_Click);
            // 
            // executeQueryButton
            // 
            this.executeQueryButton.Location = new System.Drawing.Point(776, 295);
            this.executeQueryButton.Name = "executeQueryButton";
            this.executeQueryButton.Size = new System.Drawing.Size(173, 40);
            this.executeQueryButton.TabIndex = 9;
            this.executeQueryButton.Text = "Отправить запрос";
            this.executeQueryButton.UseVisualStyleBackColor = true;
            this.executeQueryButton.Click += new System.EventHandler(this.executeQueryButton_Click);
            // 
            // checkDbConnectionButton
            // 
            this.checkDbConnectionButton.Location = new System.Drawing.Point(588, 295);
            this.checkDbConnectionButton.Name = "checkDbConnectionButton";
            this.checkDbConnectionButton.Size = new System.Drawing.Size(173, 40);
            this.checkDbConnectionButton.TabIndex = 8;
            this.checkDbConnectionButton.Text = "Проверка подключения к БД";
            this.checkDbConnectionButton.UseVisualStyleBackColor = true;
            this.checkDbConnectionButton.Click += new System.EventHandler(this.checkDbConnectionButton_Click);
            // 
            // queryTextBox
            // 
            this.queryTextBox.AcceptsReturn = true;
            this.queryTextBox.AcceptsTab = true;
            this.queryTextBox.Location = new System.Drawing.Point(588, 16);
            this.queryTextBox.Multiline = true;
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.queryTextBox.Size = new System.Drawing.Size(361, 225);
            this.queryTextBox.TabIndex = 7;
            // 
            // takenValuesInfoPage
            // 
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoDeleteRadioButton);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoSelectRadioButton);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoReturnToLabel);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoReturnFromLabel);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoTakeToLabel);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoTakeFromLabel);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoVdescriptionLabel);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoCidLabel);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoVidLabel);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoIoLabel);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoFLabel);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoPostLabel);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoUidLabel);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoCommitButton);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoReturnToTextBox);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoReturnFromTextBox);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoTakeToTextBox);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoTakeFromTextBox);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoVdescriptionTextBox);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoCidTextBox);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoVidTextBox);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoIoTextBox);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoFTextBox);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoPostTextBox);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoUidTextBox);
            this.takenValuesInfoPage.Controls.Add(this.autoRefreshTakenValuesInfoCheckBox);
            this.takenValuesInfoPage.Controls.Add(this.refreshTakenValuesInfoViewButton);
            this.takenValuesInfoPage.Controls.Add(this.takenValuesInfoView);
            this.takenValuesInfoPage.Location = new System.Drawing.Point(4, 22);
            this.takenValuesInfoPage.Name = "takenValuesInfoPage";
            this.takenValuesInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.takenValuesInfoPage.Size = new System.Drawing.Size(974, 479);
            this.takenValuesInfoPage.TabIndex = 1;
            this.takenValuesInfoPage.Text = "Взятые вещи";
            this.takenValuesInfoPage.UseVisualStyleBackColor = true;
            // 
            // takenValuesInfoDeleteRadioButton
            // 
            this.takenValuesInfoDeleteRadioButton.AutoSize = true;
            this.takenValuesInfoDeleteRadioButton.Location = new System.Drawing.Point(866, 414);
            this.takenValuesInfoDeleteRadioButton.Name = "takenValuesInfoDeleteRadioButton";
            this.takenValuesInfoDeleteRadioButton.Size = new System.Drawing.Size(75, 17);
            this.takenValuesInfoDeleteRadioButton.TabIndex = 27;
            this.takenValuesInfoDeleteRadioButton.Text = "Удаление";
            this.takenValuesInfoDeleteRadioButton.UseVisualStyleBackColor = true;
            // 
            // takenValuesInfoSelectRadioButton
            // 
            this.takenValuesInfoSelectRadioButton.AutoSize = true;
            this.takenValuesInfoSelectRadioButton.Checked = true;
            this.takenValuesInfoSelectRadioButton.Location = new System.Drawing.Point(866, 392);
            this.takenValuesInfoSelectRadioButton.Name = "takenValuesInfoSelectRadioButton";
            this.takenValuesInfoSelectRadioButton.Size = new System.Drawing.Size(76, 17);
            this.takenValuesInfoSelectRadioButton.TabIndex = 26;
            this.takenValuesInfoSelectRadioButton.TabStop = true;
            this.takenValuesInfoSelectRadioButton.Text = "Просмотр";
            this.takenValuesInfoSelectRadioButton.UseVisualStyleBackColor = true;
            // 
            // takenValuesInfoReturnToLabel
            // 
            this.takenValuesInfoReturnToLabel.AutoSize = true;
            this.takenValuesInfoReturnToLabel.Location = new System.Drawing.Point(776, 424);
            this.takenValuesInfoReturnToLabel.Name = "takenValuesInfoReturnToLabel";
            this.takenValuesInfoReturnToLabel.Size = new System.Drawing.Size(19, 13);
            this.takenValuesInfoReturnToLabel.TabIndex = 25;
            this.takenValuesInfoReturnToLabel.Text = "до";
            // 
            // takenValuesInfoReturnFromLabel
            // 
            this.takenValuesInfoReturnFromLabel.AutoSize = true;
            this.takenValuesInfoReturnFromLabel.Location = new System.Drawing.Point(754, 378);
            this.takenValuesInfoReturnFromLabel.Name = "takenValuesInfoReturnFromLabel";
            this.takenValuesInfoReturnFromLabel.Size = new System.Drawing.Size(63, 13);
            this.takenValuesInfoReturnFromLabel.TabIndex = 24;
            this.takenValuesInfoReturnFromLabel.Text = "Возврат от";
            // 
            // takenValuesInfoTakeToLabel
            // 
            this.takenValuesInfoTakeToLabel.AutoSize = true;
            this.takenValuesInfoTakeToLabel.Location = new System.Drawing.Point(670, 423);
            this.takenValuesInfoTakeToLabel.Name = "takenValuesInfoTakeToLabel";
            this.takenValuesInfoTakeToLabel.Size = new System.Drawing.Size(19, 13);
            this.takenValuesInfoTakeToLabel.TabIndex = 23;
            this.takenValuesInfoTakeToLabel.Text = "до";
            // 
            // takenValuesInfoTakeFromLabel
            // 
            this.takenValuesInfoTakeFromLabel.AutoSize = true;
            this.takenValuesInfoTakeFromLabel.Location = new System.Drawing.Point(651, 377);
            this.takenValuesInfoTakeFromLabel.Name = "takenValuesInfoTakeFromLabel";
            this.takenValuesInfoTakeFromLabel.Size = new System.Drawing.Size(57, 13);
            this.takenValuesInfoTakeFromLabel.TabIndex = 22;
            this.takenValuesInfoTakeFromLabel.Text = "Взятие от";
            // 
            // takenValuesInfoVdescriptionLabel
            // 
            this.takenValuesInfoVdescriptionLabel.AutoSize = true;
            this.takenValuesInfoVdescriptionLabel.Location = new System.Drawing.Point(476, 377);
            this.takenValuesInfoVdescriptionLabel.Name = "takenValuesInfoVdescriptionLabel";
            this.takenValuesInfoVdescriptionLabel.Size = new System.Drawing.Size(110, 13);
            this.takenValuesInfoVdescriptionLabel.TabIndex = 21;
            this.takenValuesInfoVdescriptionLabel.Text = "Описание ценности:";
            // 
            // takenValuesInfoCidLabel
            // 
            this.takenValuesInfoCidLabel.AutoSize = true;
            this.takenValuesInfoCidLabel.Location = new System.Drawing.Point(355, 424);
            this.takenValuesInfoCidLabel.Name = "takenValuesInfoCidLabel";
            this.takenValuesInfoCidLabel.Size = new System.Drawing.Size(58, 13);
            this.takenValuesInfoCidLabel.TabIndex = 20;
            this.takenValuesInfoCidLabel.Text = "ID шкафа:";
            // 
            // takenValuesInfoVidLabel
            // 
            this.takenValuesInfoVidLabel.AutoSize = true;
            this.takenValuesInfoVidLabel.Location = new System.Drawing.Point(349, 378);
            this.takenValuesInfoVidLabel.Name = "takenValuesInfoVidLabel";
            this.takenValuesInfoVidLabel.Size = new System.Drawing.Size(71, 13);
            this.takenValuesInfoVidLabel.TabIndex = 19;
            this.takenValuesInfoVidLabel.Text = "ID ценности:";
            // 
            // takenValuesInfoIoLabel
            // 
            this.takenValuesInfoIoLabel.AutoSize = true;
            this.takenValuesInfoIoLabel.Location = new System.Drawing.Point(234, 425);
            this.takenValuesInfoIoLabel.Name = "takenValuesInfoIoLabel";
            this.takenValuesInfoIoLabel.Size = new System.Drawing.Size(89, 13);
            this.takenValuesInfoIoLabel.TabIndex = 18;
            this.takenValuesInfoIoLabel.Text = "Имя и отчество:";
            // 
            // takenValuesInfoFLabel
            // 
            this.takenValuesInfoFLabel.AutoSize = true;
            this.takenValuesInfoFLabel.Location = new System.Drawing.Point(249, 379);
            this.takenValuesInfoFLabel.Name = "takenValuesInfoFLabel";
            this.takenValuesInfoFLabel.Size = new System.Drawing.Size(59, 13);
            this.takenValuesInfoFLabel.TabIndex = 17;
            this.takenValuesInfoFLabel.Text = "Фамилия:";
            // 
            // takenValuesInfoPostLabel
            // 
            this.takenValuesInfoPostLabel.AutoSize = true;
            this.takenValuesInfoPostLabel.Location = new System.Drawing.Point(138, 426);
            this.takenValuesInfoPostLabel.Name = "takenValuesInfoPostLabel";
            this.takenValuesInfoPostLabel.Size = new System.Drawing.Size(68, 13);
            this.takenValuesInfoPostLabel.TabIndex = 16;
            this.takenValuesInfoPostLabel.Text = "Должность:";
            // 
            // takenValuesInfoUidLabel
            // 
            this.takenValuesInfoUidLabel.AutoSize = true;
            this.takenValuesInfoUidLabel.Location = new System.Drawing.Point(125, 379);
            this.takenValuesInfoUidLabel.Name = "takenValuesInfoUidLabel";
            this.takenValuesInfoUidLabel.Size = new System.Drawing.Size(95, 13);
            this.takenValuesInfoUidLabel.TabIndex = 15;
            this.takenValuesInfoUidLabel.Text = "ID пользователя:";
            // 
            // takenValuesInfoCommitButton
            // 
            this.takenValuesInfoCommitButton.Location = new System.Drawing.Point(853, 437);
            this.takenValuesInfoCommitButton.Name = "takenValuesInfoCommitButton";
            this.takenValuesInfoCommitButton.Size = new System.Drawing.Size(110, 23);
            this.takenValuesInfoCommitButton.TabIndex = 14;
            this.takenValuesInfoCommitButton.Text = "ОК";
            this.takenValuesInfoCommitButton.UseVisualStyleBackColor = true;
            this.takenValuesInfoCommitButton.Click += new System.EventHandler(this.takenValuesInfoCommitButton_Click);
            // 
            // takenValuesInfoReturnToTextBox
            // 
            this.takenValuesInfoReturnToTextBox.Location = new System.Drawing.Point(735, 440);
            this.takenValuesInfoReturnToTextBox.Name = "takenValuesInfoReturnToTextBox";
            this.takenValuesInfoReturnToTextBox.Size = new System.Drawing.Size(100, 20);
            this.takenValuesInfoReturnToTextBox.TabIndex = 13;
            // 
            // takenValuesInfoReturnFromTextBox
            // 
            this.takenValuesInfoReturnFromTextBox.Location = new System.Drawing.Point(735, 396);
            this.takenValuesInfoReturnFromTextBox.Name = "takenValuesInfoReturnFromTextBox";
            this.takenValuesInfoReturnFromTextBox.Size = new System.Drawing.Size(100, 20);
            this.takenValuesInfoReturnFromTextBox.TabIndex = 12;
            // 
            // takenValuesInfoTakeToTextBox
            // 
            this.takenValuesInfoTakeToTextBox.Location = new System.Drawing.Point(629, 440);
            this.takenValuesInfoTakeToTextBox.Name = "takenValuesInfoTakeToTextBox";
            this.takenValuesInfoTakeToTextBox.Size = new System.Drawing.Size(100, 20);
            this.takenValuesInfoTakeToTextBox.TabIndex = 11;
            // 
            // takenValuesInfoTakeFromTextBox
            // 
            this.takenValuesInfoTakeFromTextBox.Location = new System.Drawing.Point(629, 396);
            this.takenValuesInfoTakeFromTextBox.Name = "takenValuesInfoTakeFromTextBox";
            this.takenValuesInfoTakeFromTextBox.Size = new System.Drawing.Size(100, 20);
            this.takenValuesInfoTakeFromTextBox.TabIndex = 10;
            // 
            // takenValuesInfoVdescriptionTextBox
            // 
            this.takenValuesInfoVdescriptionTextBox.Location = new System.Drawing.Point(440, 395);
            this.takenValuesInfoVdescriptionTextBox.Multiline = true;
            this.takenValuesInfoVdescriptionTextBox.Name = "takenValuesInfoVdescriptionTextBox";
            this.takenValuesInfoVdescriptionTextBox.Size = new System.Drawing.Size(183, 67);
            this.takenValuesInfoVdescriptionTextBox.TabIndex = 9;
            // 
            // takenValuesInfoCidTextBox
            // 
            this.takenValuesInfoCidTextBox.Location = new System.Drawing.Point(334, 441);
            this.takenValuesInfoCidTextBox.Name = "takenValuesInfoCidTextBox";
            this.takenValuesInfoCidTextBox.Size = new System.Drawing.Size(100, 20);
            this.takenValuesInfoCidTextBox.TabIndex = 8;
            // 
            // takenValuesInfoVidTextBox
            // 
            this.takenValuesInfoVidTextBox.Location = new System.Drawing.Point(334, 397);
            this.takenValuesInfoVidTextBox.Name = "takenValuesInfoVidTextBox";
            this.takenValuesInfoVidTextBox.Size = new System.Drawing.Size(100, 20);
            this.takenValuesInfoVidTextBox.TabIndex = 7;
            // 
            // takenValuesInfoIoTextBox
            // 
            this.takenValuesInfoIoTextBox.Location = new System.Drawing.Point(228, 442);
            this.takenValuesInfoIoTextBox.Name = "takenValuesInfoIoTextBox";
            this.takenValuesInfoIoTextBox.Size = new System.Drawing.Size(100, 20);
            this.takenValuesInfoIoTextBox.TabIndex = 6;
            // 
            // takenValuesInfoFTextBox
            // 
            this.takenValuesInfoFTextBox.Location = new System.Drawing.Point(228, 398);
            this.takenValuesInfoFTextBox.Name = "takenValuesInfoFTextBox";
            this.takenValuesInfoFTextBox.Size = new System.Drawing.Size(100, 20);
            this.takenValuesInfoFTextBox.TabIndex = 5;
            // 
            // takenValuesInfoPostTextBox
            // 
            this.takenValuesInfoPostTextBox.Location = new System.Drawing.Point(122, 442);
            this.takenValuesInfoPostTextBox.Name = "takenValuesInfoPostTextBox";
            this.takenValuesInfoPostTextBox.Size = new System.Drawing.Size(100, 20);
            this.takenValuesInfoPostTextBox.TabIndex = 4;
            // 
            // takenValuesInfoUidTextBox
            // 
            this.takenValuesInfoUidTextBox.Location = new System.Drawing.Point(122, 398);
            this.takenValuesInfoUidTextBox.Name = "takenValuesInfoUidTextBox";
            this.takenValuesInfoUidTextBox.Size = new System.Drawing.Size(100, 20);
            this.takenValuesInfoUidTextBox.TabIndex = 3;
            // 
            // autoRefreshTakenValuesInfoCheckBox
            // 
            this.autoRefreshTakenValuesInfoCheckBox.AutoSize = true;
            this.autoRefreshTakenValuesInfoCheckBox.Checked = true;
            this.autoRefreshTakenValuesInfoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoRefreshTakenValuesInfoCheckBox.Location = new System.Drawing.Point(6, 397);
            this.autoRefreshTakenValuesInfoCheckBox.Name = "autoRefreshTakenValuesInfoCheckBox";
            this.autoRefreshTakenValuesInfoCheckBox.Size = new System.Drawing.Size(110, 17);
            this.autoRefreshTakenValuesInfoCheckBox.TabIndex = 2;
            this.autoRefreshTakenValuesInfoCheckBox.Text = "Автообновление";
            this.autoRefreshTakenValuesInfoCheckBox.UseVisualStyleBackColor = true;
            this.autoRefreshTakenValuesInfoCheckBox.CheckedChanged += new System.EventHandler(this.autoRefreshTakenValuesInfoCheckBox_CheckedChanged);
            // 
            // refreshTakenValuesInfoViewButton
            // 
            this.refreshTakenValuesInfoViewButton.Enabled = false;
            this.refreshTakenValuesInfoViewButton.Location = new System.Drawing.Point(6, 420);
            this.refreshTakenValuesInfoViewButton.Name = "refreshTakenValuesInfoViewButton";
            this.refreshTakenValuesInfoViewButton.Size = new System.Drawing.Size(110, 23);
            this.refreshTakenValuesInfoViewButton.TabIndex = 1;
            this.refreshTakenValuesInfoViewButton.Text = "Обновить";
            this.refreshTakenValuesInfoViewButton.UseVisualStyleBackColor = true;
            this.refreshTakenValuesInfoViewButton.Click += new System.EventHandler(this.refreshTakenValuesInfoViewButton_Click);
            // 
            // takenValuesInfoView
            // 
            this.takenValuesInfoView.AllowUserToAddRows = false;
            this.takenValuesInfoView.AllowUserToDeleteRows = false;
            this.takenValuesInfoView.AllowUserToResizeColumns = false;
            this.takenValuesInfoView.AllowUserToResizeRows = false;
            this.takenValuesInfoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.takenValuesInfoView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.U_ID,
            this.U_F,
            this.U_IO,
            this.U_POST,
            this.MV_ID,
            this.MV_DESCRIPTION,
            this.MV_CLOSET,
            this.TV_TAKE,
            this.TV_RETURN});
            this.takenValuesInfoView.Location = new System.Drawing.Point(26, 6);
            this.takenValuesInfoView.Name = "takenValuesInfoView";
            this.takenValuesInfoView.ReadOnly = true;
            this.takenValuesInfoView.RowHeadersVisible = false;
            this.takenValuesInfoView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.takenValuesInfoView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.takenValuesInfoView.Size = new System.Drawing.Size(937, 365);
            this.takenValuesInfoView.TabIndex = 0;
            // 
            // U_ID
            // 
            this.U_ID.Frozen = true;
            this.U_ID.HeaderText = "ID пользователя";
            this.U_ID.Name = "U_ID";
            this.U_ID.ReadOnly = true;
            // 
            // U_F
            // 
            this.U_F.Frozen = true;
            this.U_F.HeaderText = "Фамилия";
            this.U_F.Name = "U_F";
            this.U_F.ReadOnly = true;
            this.U_F.Width = 80;
            // 
            // U_IO
            // 
            this.U_IO.Frozen = true;
            this.U_IO.HeaderText = "Имя и отчество";
            this.U_IO.Name = "U_IO";
            this.U_IO.ReadOnly = true;
            this.U_IO.Width = 130;
            // 
            // U_POST
            // 
            this.U_POST.Frozen = true;
            this.U_POST.HeaderText = "Должность";
            this.U_POST.Name = "U_POST";
            this.U_POST.ReadOnly = true;
            this.U_POST.Width = 80;
            // 
            // MV_ID
            // 
            this.MV_ID.Frozen = true;
            this.MV_ID.HeaderText = "ID ценности";
            this.MV_ID.Name = "MV_ID";
            this.MV_ID.ReadOnly = true;
            // 
            // MV_DESCRIPTION
            // 
            this.MV_DESCRIPTION.Frozen = true;
            this.MV_DESCRIPTION.HeaderText = "Описание ценности";
            this.MV_DESCRIPTION.Name = "MV_DESCRIPTION";
            this.MV_DESCRIPTION.ReadOnly = true;
            // 
            // MV_CLOSET
            // 
            this.MV_CLOSET.Frozen = true;
            this.MV_CLOSET.HeaderText = "ID шкафа";
            this.MV_CLOSET.Name = "MV_CLOSET";
            this.MV_CLOSET.ReadOnly = true;
            // 
            // TV_TAKE
            // 
            this.TV_TAKE.Frozen = true;
            this.TV_TAKE.HeaderText = "Взятие";
            this.TV_TAKE.Name = "TV_TAKE";
            this.TV_TAKE.ReadOnly = true;
            this.TV_TAKE.Width = 110;
            // 
            // TV_RETURN
            // 
            this.TV_RETURN.Frozen = true;
            this.TV_RETURN.HeaderText = "Возврат";
            this.TV_RETURN.Name = "TV_RETURN";
            this.TV_RETURN.ReadOnly = true;
            this.TV_RETURN.Width = 110;
            // 
            // closetsPage
            // 
            this.closetsPage.Controls.Add(this.closetsCommitButton);
            this.closetsPage.Controls.Add(this.closetsDeleteRadioButton);
            this.closetsPage.Controls.Add(this.closetsUpdateRadioButton);
            this.closetsPage.Controls.Add(this.closetsInsertRadioButton);
            this.closetsPage.Controls.Add(this.closetsSelectRadioButton);
            this.closetsPage.Controls.Add(this.closetsDescriptionLabel);
            this.closetsPage.Controls.Add(this.closetsFloorLabel);
            this.closetsPage.Controls.Add(this.closetsBuildingLabel);
            this.closetsPage.Controls.Add(this.closetsIdLabel);
            this.closetsPage.Controls.Add(this.closetsDescriptionTextBox);
            this.closetsPage.Controls.Add(this.closetsFloorTextBox);
            this.closetsPage.Controls.Add(this.closetsBuildingTextBox);
            this.closetsPage.Controls.Add(this.closetsIdTextBox);
            this.closetsPage.Controls.Add(this.autoRefreshClosetsCheckBox);
            this.closetsPage.Controls.Add(this.refreshClosetsButton);
            this.closetsPage.Controls.Add(this.closetsView);
            this.closetsPage.Location = new System.Drawing.Point(4, 22);
            this.closetsPage.Name = "closetsPage";
            this.closetsPage.Size = new System.Drawing.Size(974, 479);
            this.closetsPage.TabIndex = 2;
            this.closetsPage.Text = "Шкафы";
            this.closetsPage.UseVisualStyleBackColor = true;
            // 
            // closetsCommitButton
            // 
            this.closetsCommitButton.Location = new System.Drawing.Point(558, 392);
            this.closetsCommitButton.Name = "closetsCommitButton";
            this.closetsCommitButton.Size = new System.Drawing.Size(142, 23);
            this.closetsCommitButton.TabIndex = 15;
            this.closetsCommitButton.Text = "ОК";
            this.closetsCommitButton.UseVisualStyleBackColor = true;
            this.closetsCommitButton.Click += new System.EventHandler(this.closetsCommitButton_Click);
            // 
            // closetsDeleteRadioButton
            // 
            this.closetsDeleteRadioButton.AutoSize = true;
            this.closetsDeleteRadioButton.Location = new System.Drawing.Point(591, 88);
            this.closetsDeleteRadioButton.Name = "closetsDeleteRadioButton";
            this.closetsDeleteRadioButton.Size = new System.Drawing.Size(75, 17);
            this.closetsDeleteRadioButton.TabIndex = 14;
            this.closetsDeleteRadioButton.Text = "Удаление";
            this.closetsDeleteRadioButton.UseVisualStyleBackColor = true;
            this.closetsDeleteRadioButton.CheckedChanged += new System.EventHandler(this.closetsDeleteRadioButton_CheckedChanged);
            // 
            // closetsUpdateRadioButton
            // 
            this.closetsUpdateRadioButton.AutoSize = true;
            this.closetsUpdateRadioButton.Location = new System.Drawing.Point(574, 64);
            this.closetsUpdateRadioButton.Name = "closetsUpdateRadioButton";
            this.closetsUpdateRadioButton.Size = new System.Drawing.Size(109, 17);
            this.closetsUpdateRadioButton.TabIndex = 13;
            this.closetsUpdateRadioButton.Text = "Редактирование";
            this.closetsUpdateRadioButton.UseVisualStyleBackColor = true;
            this.closetsUpdateRadioButton.CheckedChanged += new System.EventHandler(this.closetsUpdateRadioButton_CheckedChanged);
            // 
            // closetsInsertRadioButton
            // 
            this.closetsInsertRadioButton.AutoSize = true;
            this.closetsInsertRadioButton.Location = new System.Drawing.Point(584, 40);
            this.closetsInsertRadioButton.Name = "closetsInsertRadioButton";
            this.closetsInsertRadioButton.Size = new System.Drawing.Size(88, 17);
            this.closetsInsertRadioButton.TabIndex = 12;
            this.closetsInsertRadioButton.Text = "Добавление";
            this.closetsInsertRadioButton.UseVisualStyleBackColor = true;
            this.closetsInsertRadioButton.CheckedChanged += new System.EventHandler(this.closetsInsertRadioButton_CheckedChanged);
            // 
            // closetsSelectRadioButton
            // 
            this.closetsSelectRadioButton.AutoSize = true;
            this.closetsSelectRadioButton.Checked = true;
            this.closetsSelectRadioButton.Location = new System.Drawing.Point(590, 16);
            this.closetsSelectRadioButton.Name = "closetsSelectRadioButton";
            this.closetsSelectRadioButton.Size = new System.Drawing.Size(76, 17);
            this.closetsSelectRadioButton.TabIndex = 11;
            this.closetsSelectRadioButton.TabStop = true;
            this.closetsSelectRadioButton.Text = "Просмотр";
            this.closetsSelectRadioButton.UseVisualStyleBackColor = true;
            this.closetsSelectRadioButton.CheckedChanged += new System.EventHandler(this.closetsSelectRadioButton_CheckedChanged);
            // 
            // closetsDescriptionLabel
            // 
            this.closetsDescriptionLabel.AutoSize = true;
            this.closetsDescriptionLabel.Location = new System.Drawing.Point(598, 279);
            this.closetsDescriptionLabel.Name = "closetsDescriptionLabel";
            this.closetsDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.closetsDescriptionLabel.TabIndex = 10;
            this.closetsDescriptionLabel.Text = "Описание:";
            // 
            // closetsFloorLabel
            // 
            this.closetsFloorLabel.AutoSize = true;
            this.closetsFloorLabel.Location = new System.Drawing.Point(610, 230);
            this.closetsFloorLabel.Name = "closetsFloorLabel";
            this.closetsFloorLabel.Size = new System.Drawing.Size(36, 13);
            this.closetsFloorLabel.TabIndex = 9;
            this.closetsFloorLabel.Text = "Этаж:";
            // 
            // closetsBuildingLabel
            // 
            this.closetsBuildingLabel.AutoSize = true;
            this.closetsBuildingLabel.Location = new System.Drawing.Point(605, 180);
            this.closetsBuildingLabel.Name = "closetsBuildingLabel";
            this.closetsBuildingLabel.Size = new System.Drawing.Size(46, 13);
            this.closetsBuildingLabel.TabIndex = 8;
            this.closetsBuildingLabel.Text = "Корпус:";
            // 
            // closetsIdLabel
            // 
            this.closetsIdLabel.AutoSize = true;
            this.closetsIdLabel.Location = new System.Drawing.Point(599, 130);
            this.closetsIdLabel.Name = "closetsIdLabel";
            this.closetsIdLabel.Size = new System.Drawing.Size(58, 13);
            this.closetsIdLabel.TabIndex = 7;
            this.closetsIdLabel.Text = "ID шкафа:";
            // 
            // closetsDescriptionTextBox
            // 
            this.closetsDescriptionTextBox.Location = new System.Drawing.Point(529, 298);
            this.closetsDescriptionTextBox.Multiline = true;
            this.closetsDescriptionTextBox.Name = "closetsDescriptionTextBox";
            this.closetsDescriptionTextBox.Size = new System.Drawing.Size(199, 75);
            this.closetsDescriptionTextBox.TabIndex = 6;
            // 
            // closetsFloorTextBox
            // 
            this.closetsFloorTextBox.Location = new System.Drawing.Point(578, 246);
            this.closetsFloorTextBox.Name = "closetsFloorTextBox";
            this.closetsFloorTextBox.Size = new System.Drawing.Size(100, 20);
            this.closetsFloorTextBox.TabIndex = 5;
            // 
            // closetsBuildingTextBox
            // 
            this.closetsBuildingTextBox.Location = new System.Drawing.Point(578, 196);
            this.closetsBuildingTextBox.Name = "closetsBuildingTextBox";
            this.closetsBuildingTextBox.Size = new System.Drawing.Size(100, 20);
            this.closetsBuildingTextBox.TabIndex = 4;
            // 
            // closetsIdTextBox
            // 
            this.closetsIdTextBox.Location = new System.Drawing.Point(578, 146);
            this.closetsIdTextBox.Name = "closetsIdTextBox";
            this.closetsIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.closetsIdTextBox.TabIndex = 3;
            // 
            // autoRefreshClosetsCheckBox
            // 
            this.autoRefreshClosetsCheckBox.AutoSize = true;
            this.autoRefreshClosetsCheckBox.Checked = true;
            this.autoRefreshClosetsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoRefreshClosetsCheckBox.Location = new System.Drawing.Point(198, 379);
            this.autoRefreshClosetsCheckBox.Name = "autoRefreshClosetsCheckBox";
            this.autoRefreshClosetsCheckBox.Size = new System.Drawing.Size(110, 17);
            this.autoRefreshClosetsCheckBox.TabIndex = 2;
            this.autoRefreshClosetsCheckBox.Text = "Автообновление";
            this.autoRefreshClosetsCheckBox.UseVisualStyleBackColor = true;
            this.autoRefreshClosetsCheckBox.CheckedChanged += new System.EventHandler(this.autoRefreshClosetsCheckBox_CheckedChanged);
            // 
            // refreshClosetsButton
            // 
            this.refreshClosetsButton.Enabled = false;
            this.refreshClosetsButton.Location = new System.Drawing.Point(181, 402);
            this.refreshClosetsButton.Name = "refreshClosetsButton";
            this.refreshClosetsButton.Size = new System.Drawing.Size(142, 23);
            this.refreshClosetsButton.TabIndex = 1;
            this.refreshClosetsButton.Text = "Обновить";
            this.refreshClosetsButton.UseVisualStyleBackColor = true;
            this.refreshClosetsButton.Click += new System.EventHandler(this.refreshClosetsButton_Click);
            // 
            // closetsView
            // 
            this.closetsView.AllowUserToAddRows = false;
            this.closetsView.AllowUserToDeleteRows = false;
            this.closetsView.AllowUserToResizeColumns = false;
            this.closetsView.AllowUserToResizeRows = false;
            this.closetsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.closetsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_ID,
            this.C_BUILDING,
            this.C_FLOOR,
            this.C_DESCRIPTION});
            this.closetsView.Location = new System.Drawing.Point(16, 16);
            this.closetsView.Name = "closetsView";
            this.closetsView.ReadOnly = true;
            this.closetsView.RowHeadersVisible = false;
            this.closetsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.closetsView.Size = new System.Drawing.Size(497, 357);
            this.closetsView.TabIndex = 0;
            this.closetsView.SelectionChanged += new System.EventHandler(this.closetsView_SelectionChanged);
            // 
            // C_ID
            // 
            this.C_ID.HeaderText = "ID шкафа";
            this.C_ID.Name = "C_ID";
            this.C_ID.ReadOnly = true;
            // 
            // C_BUILDING
            // 
            this.C_BUILDING.HeaderText = "Корпус";
            this.C_BUILDING.Name = "C_BUILDING";
            this.C_BUILDING.ReadOnly = true;
            this.C_BUILDING.Width = 120;
            // 
            // C_FLOOR
            // 
            this.C_FLOOR.HeaderText = "Этаж";
            this.C_FLOOR.Name = "C_FLOOR";
            this.C_FLOOR.ReadOnly = true;
            // 
            // C_DESCRIPTION
            // 
            this.C_DESCRIPTION.HeaderText = "Описание";
            this.C_DESCRIPTION.Name = "C_DESCRIPTION";
            this.C_DESCRIPTION.ReadOnly = true;
            this.C_DESCRIPTION.Width = 150;
            // 
            // materialValuesPage
            // 
            this.materialValuesPage.Controls.Add(this.materialValuesSelectRadioButton);
            this.materialValuesPage.Controls.Add(this.materialValuesInsertRadioButton);
            this.materialValuesPage.Controls.Add(this.materialValuesUpdateRadioButton);
            this.materialValuesPage.Controls.Add(this.materialValuesDeleteRadioButton);
            this.materialValuesPage.Controls.Add(this.MaterialValuesClosetIdLabel);
            this.materialValuesPage.Controls.Add(this.materialValuesDescriptionLabel);
            this.materialValuesPage.Controls.Add(this.materialValuesIdLabel);
            this.materialValuesPage.Controls.Add(this.materialValuesIdTextBox);
            this.materialValuesPage.Controls.Add(this.materialValuesDescriptionTextBox);
            this.materialValuesPage.Controls.Add(this.materialValuesClosetIdTextBox);
            this.materialValuesPage.Controls.Add(this.materialValuesCommitButton);
            this.materialValuesPage.Controls.Add(this.refreshMaterialValuesButton);
            this.materialValuesPage.Controls.Add(this.autoRefreshMaterialValuesCheckBox);
            this.materialValuesPage.Controls.Add(this.materialValuesView);
            this.materialValuesPage.Location = new System.Drawing.Point(4, 22);
            this.materialValuesPage.Name = "materialValuesPage";
            this.materialValuesPage.Size = new System.Drawing.Size(974, 479);
            this.materialValuesPage.TabIndex = 3;
            this.materialValuesPage.Text = "Ценности";
            this.materialValuesPage.UseVisualStyleBackColor = true;
            // 
            // materialValuesSelectRadioButton
            // 
            this.materialValuesSelectRadioButton.AutoSize = true;
            this.materialValuesSelectRadioButton.Checked = true;
            this.materialValuesSelectRadioButton.Location = new System.Drawing.Point(468, 13);
            this.materialValuesSelectRadioButton.Name = "materialValuesSelectRadioButton";
            this.materialValuesSelectRadioButton.Size = new System.Drawing.Size(76, 17);
            this.materialValuesSelectRadioButton.TabIndex = 15;
            this.materialValuesSelectRadioButton.TabStop = true;
            this.materialValuesSelectRadioButton.Text = "Просмотр";
            this.materialValuesSelectRadioButton.UseVisualStyleBackColor = true;
            this.materialValuesSelectRadioButton.CheckedChanged += new System.EventHandler(this.materialValuesSelectRadioButton_CheckedChanged);
            // 
            // materialValuesInsertRadioButton
            // 
            this.materialValuesInsertRadioButton.AutoSize = true;
            this.materialValuesInsertRadioButton.Location = new System.Drawing.Point(462, 36);
            this.materialValuesInsertRadioButton.Name = "materialValuesInsertRadioButton";
            this.materialValuesInsertRadioButton.Size = new System.Drawing.Size(88, 17);
            this.materialValuesInsertRadioButton.TabIndex = 14;
            this.materialValuesInsertRadioButton.Text = "Добавление";
            this.materialValuesInsertRadioButton.UseVisualStyleBackColor = true;
            this.materialValuesInsertRadioButton.CheckedChanged += new System.EventHandler(this.materialValuesInsertRadioButton_CheckedChanged);
            // 
            // materialValuesUpdateRadioButton
            // 
            this.materialValuesUpdateRadioButton.AutoSize = true;
            this.materialValuesUpdateRadioButton.Location = new System.Drawing.Point(452, 59);
            this.materialValuesUpdateRadioButton.Name = "materialValuesUpdateRadioButton";
            this.materialValuesUpdateRadioButton.Size = new System.Drawing.Size(109, 17);
            this.materialValuesUpdateRadioButton.TabIndex = 13;
            this.materialValuesUpdateRadioButton.Text = "Редактирование";
            this.materialValuesUpdateRadioButton.UseVisualStyleBackColor = true;
            this.materialValuesUpdateRadioButton.CheckedChanged += new System.EventHandler(this.materialValuesUpdateRadioButton_CheckedChanged);
            // 
            // materialValuesDeleteRadioButton
            // 
            this.materialValuesDeleteRadioButton.AutoSize = true;
            this.materialValuesDeleteRadioButton.Location = new System.Drawing.Point(469, 82);
            this.materialValuesDeleteRadioButton.Name = "materialValuesDeleteRadioButton";
            this.materialValuesDeleteRadioButton.Size = new System.Drawing.Size(75, 17);
            this.materialValuesDeleteRadioButton.TabIndex = 12;
            this.materialValuesDeleteRadioButton.Text = "Удаление";
            this.materialValuesDeleteRadioButton.UseVisualStyleBackColor = true;
            this.materialValuesDeleteRadioButton.CheckedChanged += new System.EventHandler(this.materialValuesDeleteRadioButton_CheckedChanged);
            // 
            // MaterialValuesClosetIdLabel
            // 
            this.MaterialValuesClosetIdLabel.AutoSize = true;
            this.MaterialValuesClosetIdLabel.Location = new System.Drawing.Point(479, 282);
            this.MaterialValuesClosetIdLabel.Name = "MaterialValuesClosetIdLabel";
            this.MaterialValuesClosetIdLabel.Size = new System.Drawing.Size(55, 13);
            this.MaterialValuesClosetIdLabel.TabIndex = 10;
            this.MaterialValuesClosetIdLabel.Text = "ID шкафа";
            // 
            // materialValuesDescriptionLabel
            // 
            this.materialValuesDescriptionLabel.AutoSize = true;
            this.materialValuesDescriptionLabel.Location = new System.Drawing.Point(478, 188);
            this.materialValuesDescriptionLabel.Name = "materialValuesDescriptionLabel";
            this.materialValuesDescriptionLabel.Size = new System.Drawing.Size(57, 13);
            this.materialValuesDescriptionLabel.TabIndex = 9;
            this.materialValuesDescriptionLabel.Text = "Описание";
            // 
            // materialValuesIdLabel
            // 
            this.materialValuesIdLabel.AutoSize = true;
            this.materialValuesIdLabel.Location = new System.Drawing.Point(472, 146);
            this.materialValuesIdLabel.Name = "materialValuesIdLabel";
            this.materialValuesIdLabel.Size = new System.Drawing.Size(68, 13);
            this.materialValuesIdLabel.TabIndex = 8;
            this.materialValuesIdLabel.Text = "ID ценности";
            // 
            // materialValuesIdTextBox
            // 
            this.materialValuesIdTextBox.Location = new System.Drawing.Point(456, 165);
            this.materialValuesIdTextBox.Name = "materialValuesIdTextBox";
            this.materialValuesIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.materialValuesIdTextBox.TabIndex = 7;
            // 
            // materialValuesDescriptionTextBox
            // 
            this.materialValuesDescriptionTextBox.Location = new System.Drawing.Point(407, 204);
            this.materialValuesDescriptionTextBox.Multiline = true;
            this.materialValuesDescriptionTextBox.Name = "materialValuesDescriptionTextBox";
            this.materialValuesDescriptionTextBox.Size = new System.Drawing.Size(199, 75);
            this.materialValuesDescriptionTextBox.TabIndex = 6;
            // 
            // materialValuesClosetIdTextBox
            // 
            this.materialValuesClosetIdTextBox.Location = new System.Drawing.Point(456, 298);
            this.materialValuesClosetIdTextBox.Name = "materialValuesClosetIdTextBox";
            this.materialValuesClosetIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.materialValuesClosetIdTextBox.TabIndex = 5;
            // 
            // materialValuesCommitButton
            // 
            this.materialValuesCommitButton.Location = new System.Drawing.Point(435, 384);
            this.materialValuesCommitButton.Name = "materialValuesCommitButton";
            this.materialValuesCommitButton.Size = new System.Drawing.Size(142, 23);
            this.materialValuesCommitButton.TabIndex = 3;
            this.materialValuesCommitButton.Text = "ОК";
            this.materialValuesCommitButton.UseVisualStyleBackColor = true;
            this.materialValuesCommitButton.Click += new System.EventHandler(this.materialValuesCommitButton_Click);
            // 
            // refreshMaterialValuesButton
            // 
            this.refreshMaterialValuesButton.Enabled = false;
            this.refreshMaterialValuesButton.Location = new System.Drawing.Point(123, 399);
            this.refreshMaterialValuesButton.Name = "refreshMaterialValuesButton";
            this.refreshMaterialValuesButton.Size = new System.Drawing.Size(142, 23);
            this.refreshMaterialValuesButton.TabIndex = 2;
            this.refreshMaterialValuesButton.Text = "Обновить";
            this.refreshMaterialValuesButton.UseVisualStyleBackColor = true;
            this.refreshMaterialValuesButton.Click += new System.EventHandler(this.refreshMaterialValuesButton_Click);
            // 
            // autoRefreshMaterialValuesCheckBox
            // 
            this.autoRefreshMaterialValuesCheckBox.AutoSize = true;
            this.autoRefreshMaterialValuesCheckBox.Checked = true;
            this.autoRefreshMaterialValuesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoRefreshMaterialValuesCheckBox.Location = new System.Drawing.Point(139, 375);
            this.autoRefreshMaterialValuesCheckBox.Name = "autoRefreshMaterialValuesCheckBox";
            this.autoRefreshMaterialValuesCheckBox.Size = new System.Drawing.Size(110, 17);
            this.autoRefreshMaterialValuesCheckBox.TabIndex = 1;
            this.autoRefreshMaterialValuesCheckBox.Text = "Автообновление";
            this.autoRefreshMaterialValuesCheckBox.UseVisualStyleBackColor = true;
            this.autoRefreshMaterialValuesCheckBox.CheckedChanged += new System.EventHandler(this.autoRefreshMaterialValuesCheckBox_CheckedChanged);
            // 
            // materialValuesView
            // 
            this.materialValuesView.AllowUserToAddRows = false;
            this.materialValuesView.AllowUserToDeleteRows = false;
            this.materialValuesView.AllowUserToResizeColumns = false;
            this.materialValuesView.AllowUserToResizeRows = false;
            this.materialValuesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialValuesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mv__id,
            this.mv__description,
            this.mv__closet});
            this.materialValuesView.Location = new System.Drawing.Point(13, 13);
            this.materialValuesView.Name = "materialValuesView";
            this.materialValuesView.ReadOnly = true;
            this.materialValuesView.RowHeadersVisible = false;
            this.materialValuesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.materialValuesView.Size = new System.Drawing.Size(378, 356);
            this.materialValuesView.TabIndex = 0;
            this.materialValuesView.SelectionChanged += new System.EventHandler(this.materialValuesView_SelectionChanged);
            // 
            // mv__id
            // 
            this.mv__id.HeaderText = "ID ценности";
            this.mv__id.Name = "mv__id";
            this.mv__id.ReadOnly = true;
            // 
            // mv__description
            // 
            this.mv__description.HeaderText = "Описание";
            this.mv__description.Name = "mv__description";
            this.mv__description.ReadOnly = true;
            this.mv__description.Width = 150;
            // 
            // mv__closet
            // 
            this.mv__closet.HeaderText = "Шкаф";
            this.mv__closet.Name = "mv__closet";
            this.mv__closet.ReadOnly = true;
            // 
            // usersPage
            // 
            this.usersPage.Controls.Add(this.usersDeleteRadioButton);
            this.usersPage.Controls.Add(this.usersUpdateRadioButton);
            this.usersPage.Controls.Add(this.usersInsertRadioButton);
            this.usersPage.Controls.Add(this.usersSelectRadioButton);
            this.usersPage.Controls.Add(this.usersCommitButton);
            this.usersPage.Controls.Add(this.refreshUsersView);
            this.usersPage.Controls.Add(this.usersPostLabel);
            this.usersPage.Controls.Add(this.usersIoLabel);
            this.usersPage.Controls.Add(this.usersFLabel);
            this.usersPage.Controls.Add(this.usersIdLabel);
            this.usersPage.Controls.Add(this.usersPostTextBox);
            this.usersPage.Controls.Add(this.usersIoTextBox);
            this.usersPage.Controls.Add(this.usersFTextBox);
            this.usersPage.Controls.Add(this.usersIdTextBox);
            this.usersPage.Controls.Add(this.autoRefreshUsersView);
            this.usersPage.Controls.Add(this.usersView);
            this.usersPage.Location = new System.Drawing.Point(4, 22);
            this.usersPage.Name = "usersPage";
            this.usersPage.Size = new System.Drawing.Size(974, 479);
            this.usersPage.TabIndex = 4;
            this.usersPage.Text = "Пользователи";
            this.usersPage.UseVisualStyleBackColor = true;
            // 
            // usersDeleteRadioButton
            // 
            this.usersDeleteRadioButton.AutoSize = true;
            this.usersDeleteRadioButton.Location = new System.Drawing.Point(546, 91);
            this.usersDeleteRadioButton.Name = "usersDeleteRadioButton";
            this.usersDeleteRadioButton.Size = new System.Drawing.Size(75, 17);
            this.usersDeleteRadioButton.TabIndex = 15;
            this.usersDeleteRadioButton.Text = "Удаление";
            this.usersDeleteRadioButton.UseVisualStyleBackColor = true;
            this.usersDeleteRadioButton.CheckedChanged += new System.EventHandler(this.usersDeleteRadioButton_CheckedChanged);
            // 
            // usersUpdateRadioButton
            // 
            this.usersUpdateRadioButton.AutoSize = true;
            this.usersUpdateRadioButton.Location = new System.Drawing.Point(529, 68);
            this.usersUpdateRadioButton.Name = "usersUpdateRadioButton";
            this.usersUpdateRadioButton.Size = new System.Drawing.Size(109, 17);
            this.usersUpdateRadioButton.TabIndex = 14;
            this.usersUpdateRadioButton.Text = "Редактирование";
            this.usersUpdateRadioButton.UseVisualStyleBackColor = true;
            this.usersUpdateRadioButton.CheckedChanged += new System.EventHandler(this.usersUpdateRadioButton_CheckedChanged);
            // 
            // usersInsertRadioButton
            // 
            this.usersInsertRadioButton.AutoSize = true;
            this.usersInsertRadioButton.Location = new System.Drawing.Point(539, 45);
            this.usersInsertRadioButton.Name = "usersInsertRadioButton";
            this.usersInsertRadioButton.Size = new System.Drawing.Size(88, 17);
            this.usersInsertRadioButton.TabIndex = 13;
            this.usersInsertRadioButton.Text = "Добавление";
            this.usersInsertRadioButton.UseVisualStyleBackColor = true;
            this.usersInsertRadioButton.CheckedChanged += new System.EventHandler(this.usersInsertRadioButton_CheckedChanged);
            // 
            // usersSelectRadioButton
            // 
            this.usersSelectRadioButton.AutoSize = true;
            this.usersSelectRadioButton.Checked = true;
            this.usersSelectRadioButton.Location = new System.Drawing.Point(545, 22);
            this.usersSelectRadioButton.Name = "usersSelectRadioButton";
            this.usersSelectRadioButton.Size = new System.Drawing.Size(76, 17);
            this.usersSelectRadioButton.TabIndex = 12;
            this.usersSelectRadioButton.TabStop = true;
            this.usersSelectRadioButton.Text = "Просмотр";
            this.usersSelectRadioButton.UseVisualStyleBackColor = true;
            this.usersSelectRadioButton.CheckedChanged += new System.EventHandler(this.usersSelectRadioButton_CheckedChanged);
            // 
            // usersCommitButton
            // 
            this.usersCommitButton.Location = new System.Drawing.Point(512, 385);
            this.usersCommitButton.Name = "usersCommitButton";
            this.usersCommitButton.Size = new System.Drawing.Size(142, 23);
            this.usersCommitButton.TabIndex = 11;
            this.usersCommitButton.Text = "ОК";
            this.usersCommitButton.UseVisualStyleBackColor = true;
            this.usersCommitButton.Click += new System.EventHandler(this.usersCommitButton_Click);
            // 
            // refreshUsersView
            // 
            this.refreshUsersView.Enabled = false;
            this.refreshUsersView.Location = new System.Drawing.Point(158, 398);
            this.refreshUsersView.Name = "refreshUsersView";
            this.refreshUsersView.Size = new System.Drawing.Size(142, 23);
            this.refreshUsersView.TabIndex = 10;
            this.refreshUsersView.Text = "Обновить";
            this.refreshUsersView.UseVisualStyleBackColor = true;
            this.refreshUsersView.Click += new System.EventHandler(this.refreshUsersView_Click);
            // 
            // usersPostLabel
            // 
            this.usersPostLabel.AutoSize = true;
            this.usersPostLabel.Location = new System.Drawing.Point(549, 290);
            this.usersPostLabel.Name = "usersPostLabel";
            this.usersPostLabel.Size = new System.Drawing.Size(68, 13);
            this.usersPostLabel.TabIndex = 9;
            this.usersPostLabel.Text = "Должность:";
            // 
            // usersIoLabel
            // 
            this.usersIoLabel.AutoSize = true;
            this.usersIoLabel.Location = new System.Drawing.Point(539, 241);
            this.usersIoLabel.Name = "usersIoLabel";
            this.usersIoLabel.Size = new System.Drawing.Size(89, 13);
            this.usersIoLabel.TabIndex = 8;
            this.usersIoLabel.Text = "Имя и отчество:";
            // 
            // usersFLabel
            // 
            this.usersFLabel.AutoSize = true;
            this.usersFLabel.Location = new System.Drawing.Point(554, 189);
            this.usersFLabel.Name = "usersFLabel";
            this.usersFLabel.Size = new System.Drawing.Size(59, 13);
            this.usersFLabel.TabIndex = 7;
            this.usersFLabel.Text = "Фамилия:";
            // 
            // usersIdLabel
            // 
            this.usersIdLabel.AutoSize = true;
            this.usersIdLabel.Location = new System.Drawing.Point(536, 140);
            this.usersIdLabel.Name = "usersIdLabel";
            this.usersIdLabel.Size = new System.Drawing.Size(95, 13);
            this.usersIdLabel.TabIndex = 6;
            this.usersIdLabel.Text = "ID пользователя:";
            // 
            // usersPostTextBox
            // 
            this.usersPostTextBox.Location = new System.Drawing.Point(533, 306);
            this.usersPostTextBox.Name = "usersPostTextBox";
            this.usersPostTextBox.Size = new System.Drawing.Size(100, 20);
            this.usersPostTextBox.TabIndex = 5;
            // 
            // usersIoTextBox
            // 
            this.usersIoTextBox.Location = new System.Drawing.Point(533, 257);
            this.usersIoTextBox.Name = "usersIoTextBox";
            this.usersIoTextBox.Size = new System.Drawing.Size(100, 20);
            this.usersIoTextBox.TabIndex = 4;
            // 
            // usersFTextBox
            // 
            this.usersFTextBox.Location = new System.Drawing.Point(533, 205);
            this.usersFTextBox.Name = "usersFTextBox";
            this.usersFTextBox.Size = new System.Drawing.Size(100, 20);
            this.usersFTextBox.TabIndex = 3;
            // 
            // usersIdTextBox
            // 
            this.usersIdTextBox.Location = new System.Drawing.Point(533, 156);
            this.usersIdTextBox.Name = "usersIdTextBox";
            this.usersIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.usersIdTextBox.TabIndex = 2;
            // 
            // autoRefreshUsersView
            // 
            this.autoRefreshUsersView.AutoSize = true;
            this.autoRefreshUsersView.Checked = true;
            this.autoRefreshUsersView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoRefreshUsersView.Location = new System.Drawing.Point(174, 374);
            this.autoRefreshUsersView.Name = "autoRefreshUsersView";
            this.autoRefreshUsersView.Size = new System.Drawing.Size(110, 17);
            this.autoRefreshUsersView.TabIndex = 1;
            this.autoRefreshUsersView.Text = "Автообновление";
            this.autoRefreshUsersView.UseVisualStyleBackColor = true;
            this.autoRefreshUsersView.CheckedChanged += new System.EventHandler(this.autoRefreshUsersView_CheckedChanged);
            // 
            // usersView
            // 
            this.usersView.AllowUserToAddRows = false;
            this.usersView.AllowUserToDeleteRows = false;
            this.usersView.AllowUserToResizeColumns = false;
            this.usersView.AllowUserToResizeRows = false;
            this.usersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.U__ID,
            this.U__F,
            this.U__IO,
            this.U__POST});
            this.usersView.Location = new System.Drawing.Point(22, 21);
            this.usersView.Name = "usersView";
            this.usersView.ReadOnly = true;
            this.usersView.RowHeadersVisible = false;
            this.usersView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersView.Size = new System.Drawing.Size(477, 347);
            this.usersView.TabIndex = 0;
            this.usersView.SelectionChanged += new System.EventHandler(this.usersView_SelectionChanged);
            // 
            // U__ID
            // 
            this.U__ID.HeaderText = "ID пользователя";
            this.U__ID.Name = "U__ID";
            this.U__ID.ReadOnly = true;
            // 
            // U__F
            // 
            this.U__F.HeaderText = "Фамилия";
            this.U__F.Name = "U__F";
            this.U__F.ReadOnly = true;
            // 
            // U__IO
            // 
            this.U__IO.HeaderText = "Имя и отчетство";
            this.U__IO.Name = "U__IO";
            this.U__IO.ReadOnly = true;
            this.U__IO.Width = 150;
            // 
            // U__POST
            // 
            this.U__POST.HeaderText = "Должность";
            this.U__POST.Name = "U__POST";
            this.U__POST.ReadOnly = true;
            // 
            // tAKENVALUESINFOBindingSource
            // 
            this.tAKENVALUESINFOBindingSource.DataMember = "TAKENVALUES_INFO";
            this.tAKENVALUESINFOBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAKENVALUES_INFOTableAdapter
            // 
            this.tAKENVALUES_INFOTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 529);
            this.Controls.Add(this.pagesControl);
            this.Name = "Form1";
            this.Text = "Prototype_v0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pagesControl.ResumeLayout(false);
            this.connectionPage.ResumeLayout(false);
            this.connectionPage.PerformLayout();
            this.takenValuesInfoPage.ResumeLayout(false);
            this.takenValuesInfoPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.takenValuesInfoView)).EndInit();
            this.closetsPage.ResumeLayout(false);
            this.closetsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closetsView)).EndInit();
            this.materialValuesPage.ResumeLayout(false);
            this.materialValuesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialValuesView)).EndInit();
            this.usersPage.ResumeLayout(false);
            this.usersPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKENVALUESINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox chosenPortComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.TextBox debugTextBox;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label connectionStateLabel;
        private System.Windows.Forms.TabControl pagesControl;
        private System.Windows.Forms.TabPage connectionPage;
        private System.Windows.Forms.TabPage takenValuesInfoPage;
        private System.Windows.Forms.DataGridView takenValuesInfoView;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tAKENVALUESINFOBindingSource;
        private DataSet1TableAdapters.TAKENVALUES_INFOTableAdapter tAKENVALUES_INFOTableAdapter;
        private System.Windows.Forms.Button executeQueryButton;
        private System.Windows.Forms.Button checkDbConnectionButton;
        private System.Windows.Forms.TextBox queryTextBox;
        private System.Windows.Forms.Button clearQueryTextBox;
        private System.Windows.Forms.Button clearDebugTextBoxButton;
        private System.Windows.Forms.Button refreshTakenValuesInfoViewButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_F;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_IO;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_POST;
        private System.Windows.Forms.DataGridViewTextBoxColumn MV_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MV_DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn MV_CLOSET;
        private System.Windows.Forms.DataGridViewTextBoxColumn TV_TAKE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TV_RETURN;
        private System.Windows.Forms.TabPage closetsPage;
        private System.Windows.Forms.TextBox closetsDescriptionTextBox;
        private System.Windows.Forms.TextBox closetsFloorTextBox;
        private System.Windows.Forms.TextBox closetsBuildingTextBox;
        private System.Windows.Forms.TextBox closetsIdTextBox;
        private System.Windows.Forms.CheckBox autoRefreshClosetsCheckBox;
        private System.Windows.Forms.Button refreshClosetsButton;
        private System.Windows.Forms.DataGridView closetsView;
        private System.Windows.Forms.TabPage materialValuesPage;
        private System.Windows.Forms.TabPage usersPage;
        private System.Windows.Forms.Label closetsIdLabel;
        private System.Windows.Forms.Button closetsCommitButton;
        private System.Windows.Forms.RadioButton closetsDeleteRadioButton;
        private System.Windows.Forms.RadioButton closetsUpdateRadioButton;
        private System.Windows.Forms.RadioButton closetsInsertRadioButton;
        private System.Windows.Forms.RadioButton closetsSelectRadioButton;
        private System.Windows.Forms.Label closetsDescriptionLabel;
        private System.Windows.Forms.Label closetsFloorLabel;
        private System.Windows.Forms.Label closetsBuildingLabel;
        private System.Windows.Forms.RadioButton materialValuesSelectRadioButton;
        private System.Windows.Forms.RadioButton materialValuesInsertRadioButton;
        private System.Windows.Forms.RadioButton materialValuesUpdateRadioButton;
        private System.Windows.Forms.RadioButton materialValuesDeleteRadioButton;
        private System.Windows.Forms.Label MaterialValuesClosetIdLabel;
        private System.Windows.Forms.Label materialValuesDescriptionLabel;
        private System.Windows.Forms.Label materialValuesIdLabel;
        private System.Windows.Forms.TextBox materialValuesIdTextBox;
        private System.Windows.Forms.TextBox materialValuesDescriptionTextBox;
        private System.Windows.Forms.TextBox materialValuesClosetIdTextBox;
        private System.Windows.Forms.Button materialValuesCommitButton;
        private System.Windows.Forms.Button refreshMaterialValuesButton;
        private System.Windows.Forms.CheckBox autoRefreshMaterialValuesCheckBox;
        private System.Windows.Forms.DataGridView materialValuesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn mv__id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mv__description;
        private System.Windows.Forms.DataGridViewTextBoxColumn mv__closet;
        private System.Windows.Forms.RadioButton usersDeleteRadioButton;
        private System.Windows.Forms.RadioButton usersUpdateRadioButton;
        private System.Windows.Forms.RadioButton usersInsertRadioButton;
        private System.Windows.Forms.RadioButton usersSelectRadioButton;
        private System.Windows.Forms.Button usersCommitButton;
        private System.Windows.Forms.Button refreshUsersView;
        private System.Windows.Forms.Label usersPostLabel;
        private System.Windows.Forms.Label usersIoLabel;
        private System.Windows.Forms.Label usersFLabel;
        private System.Windows.Forms.Label usersIdLabel;
        private System.Windows.Forms.TextBox usersPostTextBox;
        private System.Windows.Forms.TextBox usersIoTextBox;
        private System.Windows.Forms.TextBox usersFTextBox;
        private System.Windows.Forms.TextBox usersIdTextBox;
        private System.Windows.Forms.CheckBox autoRefreshUsersView;
        private System.Windows.Forms.DataGridView usersView;
        private System.Windows.Forms.CheckBox autoRefreshTakenValuesInfoCheckBox;
        private System.Windows.Forms.Label takenValuesInfoReturnToLabel;
        private System.Windows.Forms.Label takenValuesInfoReturnFromLabel;
        private System.Windows.Forms.Label takenValuesInfoTakeToLabel;
        private System.Windows.Forms.Label takenValuesInfoTakeFromLabel;
        private System.Windows.Forms.Label takenValuesInfoVdescriptionLabel;
        private System.Windows.Forms.Label takenValuesInfoCidLabel;
        private System.Windows.Forms.Label takenValuesInfoVidLabel;
        private System.Windows.Forms.Label takenValuesInfoIoLabel;
        private System.Windows.Forms.Label takenValuesInfoFLabel;
        private System.Windows.Forms.Label takenValuesInfoPostLabel;
        private System.Windows.Forms.Label takenValuesInfoUidLabel;
        private System.Windows.Forms.Button takenValuesInfoCommitButton;
        private System.Windows.Forms.TextBox takenValuesInfoReturnToTextBox;
        private System.Windows.Forms.TextBox takenValuesInfoReturnFromTextBox;
        private System.Windows.Forms.TextBox takenValuesInfoTakeToTextBox;
        private System.Windows.Forms.TextBox takenValuesInfoTakeFromTextBox;
        private System.Windows.Forms.TextBox takenValuesInfoVdescriptionTextBox;
        private System.Windows.Forms.TextBox takenValuesInfoCidTextBox;
        private System.Windows.Forms.TextBox takenValuesInfoVidTextBox;
        private System.Windows.Forms.TextBox takenValuesInfoIoTextBox;
        private System.Windows.Forms.TextBox takenValuesInfoFTextBox;
        private System.Windows.Forms.TextBox takenValuesInfoPostTextBox;
        private System.Windows.Forms.TextBox takenValuesInfoUidTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_BUILDING;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_FLOOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn U__ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn U__F;
        private System.Windows.Forms.DataGridViewTextBoxColumn U__IO;
        private System.Windows.Forms.DataGridViewTextBoxColumn U__POST;
        private System.Windows.Forms.RadioButton takenValuesInfoDeleteRadioButton;
        private System.Windows.Forms.RadioButton takenValuesInfoSelectRadioButton;
    }
}

