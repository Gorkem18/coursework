namespace Interface
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
            this.pnl_Authorization = new System.Windows.Forms.Panel();
            this.pnl_MainMenu = new System.Windows.Forms.Panel();
            this.pnl_AddWorker = new System.Windows.Forms.Panel();
            this.btn_Back2Main = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_Notification = new System.Windows.Forms.Label();
            this.btn_AddPosition = new System.Windows.Forms.Button();
            this.btn_ShowReports = new System.Windows.Forms.Button();
            this.btn_AddWorker = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Confirm_Login = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmr_ClearStatus = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ss_StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ts_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_ConnectStrip = new System.Windows.Forms.StatusStrip();
            this.ts_ConnectIndicator = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перепідключитисьДоБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інформаціяПроКористувачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інформаціяПроРозробникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmr_Timer = new System.Windows.Forms.Timer(this.components);
            this.pnl_ShowReports = new System.Windows.Forms.Panel();
            this.btn_Back2MainSR = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnl_AddPosition = new System.Windows.Forms.Panel();
            this.btn_Back2MainAP = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.btn_Back2MainS = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pnl_Authorization.SuspendLayout();
            this.pnl_MainMenu.SuspendLayout();
            this.pnl_AddWorker.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ss_StatusStrip.SuspendLayout();
            this.ss_ConnectStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnl_ShowReports.SuspendLayout();
            this.pnl_AddPosition.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Authorization
            // 
            this.pnl_Authorization.BackColor = System.Drawing.Color.Honeydew;
            this.pnl_Authorization.Controls.Add(this.pnl_MainMenu);
            this.pnl_Authorization.Controls.Add(this.btn_Exit);
            this.pnl_Authorization.Controls.Add(this.btn_Confirm_Login);
            this.pnl_Authorization.Controls.Add(this.tb_Password);
            this.pnl_Authorization.Controls.Add(this.tb_Login);
            this.pnl_Authorization.Controls.Add(this.label2);
            this.pnl_Authorization.Controls.Add(this.label1);
            this.pnl_Authorization.Location = new System.Drawing.Point(0, 31);
            this.pnl_Authorization.Name = "pnl_Authorization";
            this.pnl_Authorization.Size = new System.Drawing.Size(638, 382);
            this.pnl_Authorization.TabIndex = 0;
            // 
            // pnl_MainMenu
            // 
            this.pnl_MainMenu.BackColor = System.Drawing.Color.Honeydew;
            this.pnl_MainMenu.Controls.Add(this.pnl_Search);
            this.pnl_MainMenu.Controls.Add(this.pnl_AddWorker);
            this.pnl_MainMenu.Controls.Add(this.pnl_ShowReports);
            this.pnl_MainMenu.Controls.Add(this.btn_Search);
            this.pnl_MainMenu.Controls.Add(this.lbl_Date);
            this.pnl_MainMenu.Controls.Add(this.lbl_Time);
            this.pnl_MainMenu.Controls.Add(this.lbl_Notification);
            this.pnl_MainMenu.Controls.Add(this.btn_AddPosition);
            this.pnl_MainMenu.Controls.Add(this.btn_ShowReports);
            this.pnl_MainMenu.Controls.Add(this.btn_AddWorker);
            this.pnl_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnl_MainMenu.Name = "pnl_MainMenu";
            this.pnl_MainMenu.Size = new System.Drawing.Size(638, 382);
            this.pnl_MainMenu.TabIndex = 6;
            // 
            // pnl_AddWorker
            // 
            this.pnl_AddWorker.BackColor = System.Drawing.Color.Honeydew;
            this.pnl_AddWorker.Controls.Add(this.btn_Back2Main);
            this.pnl_AddWorker.Controls.Add(this.label3);
            this.pnl_AddWorker.Controls.Add(this.label4);
            this.pnl_AddWorker.Controls.Add(this.label5);
            this.pnl_AddWorker.Location = new System.Drawing.Point(3, 0);
            this.pnl_AddWorker.Name = "pnl_AddWorker";
            this.pnl_AddWorker.Size = new System.Drawing.Size(638, 382);
            this.pnl_AddWorker.TabIndex = 7;
            // 
            // btn_Back2Main
            // 
            this.btn_Back2Main.BackColor = System.Drawing.Color.Honeydew;
            this.btn_Back2Main.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btn_Back2Main.FlatAppearance.BorderSize = 0;
            this.btn_Back2Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back2Main.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Back2Main.Location = new System.Drawing.Point(9, 10);
            this.btn_Back2Main.Name = "btn_Back2Main";
            this.btn_Back2Main.Size = new System.Drawing.Size(25, 25);
            this.btn_Back2Main.TabIndex = 6;
            this.btn_Back2Main.Text = "←";
            this.btn_Back2Main.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Back2Main.UseVisualStyleBackColor = false;
            this.btn_Back2Main.Click += new System.EventHandler(this.btn_Back2Main_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 55);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(38, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 55);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(520, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 32);
            this.label5.TabIndex = 3;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Date.Location = new System.Drawing.Point(12, 197);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(0, 55);
            this.lbl_Date.TabIndex = 5;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Time.Location = new System.Drawing.Point(38, 86);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(0, 55);
            this.lbl_Time.TabIndex = 4;
            // 
            // lbl_Notification
            // 
            this.lbl_Notification.AutoSize = true;
            this.lbl_Notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Notification.Location = new System.Drawing.Point(520, 10);
            this.lbl_Notification.Name = "lbl_Notification";
            this.lbl_Notification.Size = new System.Drawing.Size(0, 32);
            this.lbl_Notification.TabIndex = 3;
            // 
            // btn_AddPosition
            // 
            this.btn_AddPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddPosition.Location = new System.Drawing.Point(348, 211);
            this.btn_AddPosition.Name = "btn_AddPosition";
            this.btn_AddPosition.Size = new System.Drawing.Size(263, 41);
            this.btn_AddPosition.TabIndex = 2;
            this.btn_AddPosition.Text = "Додати посаду";
            this.btn_AddPosition.UseVisualStyleBackColor = true;
            this.btn_AddPosition.Click += new System.EventHandler(this.btn_AddPosition_Click);
            // 
            // btn_ShowReports
            // 
            this.btn_ShowReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ShowReports.Location = new System.Drawing.Point(348, 137);
            this.btn_ShowReports.Name = "btn_ShowReports";
            this.btn_ShowReports.Size = new System.Drawing.Size(263, 41);
            this.btn_ShowReports.TabIndex = 1;
            this.btn_ShowReports.Text = "Переглянути звіти";
            this.btn_ShowReports.UseVisualStyleBackColor = true;
            this.btn_ShowReports.Click += new System.EventHandler(this.btn_ShowReports_Click);
            // 
            // btn_AddWorker
            // 
            this.btn_AddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddWorker.Location = new System.Drawing.Point(348, 62);
            this.btn_AddWorker.Name = "btn_AddWorker";
            this.btn_AddWorker.Size = new System.Drawing.Size(263, 41);
            this.btn_AddWorker.TabIndex = 0;
            this.btn_AddWorker.Text = "Додати працівника";
            this.btn_AddWorker.UseVisualStyleBackColor = true;
            this.btn_AddWorker.Click += new System.EventHandler(this.btn_AddWorker_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Exit.Location = new System.Drawing.Point(302, 231);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(93, 42);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Вийти";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Confirm_Login
            // 
            this.btn_Confirm_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirm_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Confirm_Login.Location = new System.Drawing.Point(173, 231);
            this.btn_Confirm_Login.Name = "btn_Confirm_Login";
            this.btn_Confirm_Login.Size = new System.Drawing.Size(93, 42);
            this.btn_Confirm_Login.TabIndex = 4;
            this.btn_Confirm_Login.Text = "Ввійти";
            this.btn_Confirm_Login.UseVisualStyleBackColor = true;
            this.btn_Confirm_Login.Click += new System.EventHandler(this.btn_Confirm_Login_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Password.Location = new System.Drawing.Point(288, 158);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(196, 34);
            this.tb_Password.TabIndex = 3;
            // 
            // tb_Login
            // 
            this.tb_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Login.Location = new System.Drawing.Point(288, 109);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(196, 34);
            this.tb_Login.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(139, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(139, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логін";
            // 
            // tmr_ClearStatus
            // 
            this.tmr_ClearStatus.Tick += new System.EventHandler(this.tmr_ClearStatus_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Honeydew;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.51097F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.48903F));
            this.tableLayoutPanel1.Controls.Add(this.ss_StatusStrip, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ss_ConnectStrip, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 419);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 28);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ss_StatusStrip
            // 
            this.ss_StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ss_StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_StatusLabel});
            this.ss_StatusStrip.Location = new System.Drawing.Point(0, 6);
            this.ss_StatusStrip.Name = "ss_StatusStrip";
            this.ss_StatusStrip.Size = new System.Drawing.Size(468, 22);
            this.ss_StatusStrip.TabIndex = 0;
            this.ss_StatusStrip.Text = "statusStrip1";
            // 
            // ts_StatusLabel
            // 
            this.ts_StatusLabel.BackColor = System.Drawing.Color.White;
            this.ts_StatusLabel.Name = "ts_StatusLabel";
            this.ts_StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ss_ConnectStrip
            // 
            this.ss_ConnectStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ss_ConnectStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_ConnectIndicator});
            this.ss_ConnectStrip.Location = new System.Drawing.Point(468, 3);
            this.ss_ConnectStrip.Name = "ss_ConnectStrip";
            this.ss_ConnectStrip.Size = new System.Drawing.Size(170, 25);
            this.ss_ConnectStrip.TabIndex = 1;
            this.ss_ConnectStrip.Text = "statusStrip1";
            // 
            // ts_ConnectIndicator
            // 
            this.ts_ConnectIndicator.BackColor = System.Drawing.Color.White;
            this.ts_ConnectIndicator.ForeColor = System.Drawing.Color.Red;
            this.ts_ConnectIndicator.Name = "ts_ConnectIndicator";
            this.ts_ConnectIndicator.Size = new System.Drawing.Size(114, 20);
            this.ts_ConnectIndicator.Text = "Не підключено";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Honeydew;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перепідключитисьДоБДToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.файлToolStripMenuItem.Text = "Сеанс";
            // 
            // перепідключитисьДоБДToolStripMenuItem
            // 
            this.перепідключитисьДоБДToolStripMenuItem.Enabled = false;
            this.перепідключитисьДоБДToolStripMenuItem.Name = "перепідключитисьДоБДToolStripMenuItem";
            this.перепідключитисьДоБДToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.перепідключитисьДоБДToolStripMenuItem.Text = "Перепідключитись до БД";
            this.перепідключитисьДоБДToolStripMenuItem.Click += new System.EventHandler(this.перепідключитисьДоБДToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.інформаціяПроКористувачаToolStripMenuItem,
            this.інформаціяПроРозробникаToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // інформаціяПроКористувачаToolStripMenuItem
            // 
            this.інформаціяПроКористувачаToolStripMenuItem.Enabled = false;
            this.інформаціяПроКористувачаToolStripMenuItem.Name = "інформаціяПроКористувачаToolStripMenuItem";
            this.інформаціяПроКористувачаToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.інформаціяПроКористувачаToolStripMenuItem.Text = "Інформація про користувача";
            // 
            // інформаціяПроРозробникаToolStripMenuItem
            // 
            this.інформаціяПроРозробникаToolStripMenuItem.Name = "інформаціяПроРозробникаToolStripMenuItem";
            this.інформаціяПроРозробникаToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.інформаціяПроРозробникаToolStripMenuItem.Text = "Інформація про розробника";
            // 
            // tmr_Timer
            // 
            this.tmr_Timer.Tick += new System.EventHandler(this.tmr_Timer_Tick);
            // 
            // pnl_ShowReports
            // 
            this.pnl_ShowReports.BackColor = System.Drawing.Color.Honeydew;
            this.pnl_ShowReports.Controls.Add(this.btn_Back2MainSR);
            this.pnl_ShowReports.Controls.Add(this.label6);
            this.pnl_ShowReports.Controls.Add(this.label7);
            this.pnl_ShowReports.Controls.Add(this.label8);
            this.pnl_ShowReports.Location = new System.Drawing.Point(3, 0);
            this.pnl_ShowReports.Name = "pnl_ShowReports";
            this.pnl_ShowReports.Size = new System.Drawing.Size(638, 382);
            this.pnl_ShowReports.TabIndex = 8;
            // 
            // btn_Back2MainSR
            // 
            this.btn_Back2MainSR.BackColor = System.Drawing.Color.Honeydew;
            this.btn_Back2MainSR.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btn_Back2MainSR.FlatAppearance.BorderSize = 0;
            this.btn_Back2MainSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back2MainSR.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Back2MainSR.Location = new System.Drawing.Point(9, 10);
            this.btn_Back2MainSR.Name = "btn_Back2MainSR";
            this.btn_Back2MainSR.Size = new System.Drawing.Size(25, 25);
            this.btn_Back2MainSR.TabIndex = 6;
            this.btn_Back2MainSR.Text = "←";
            this.btn_Back2MainSR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Back2MainSR.UseVisualStyleBackColor = false;
            this.btn_Back2MainSR.Click += new System.EventHandler(this.btn_Back2MainSR_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 55);
            this.label6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(38, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 55);
            this.label7.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(520, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 32);
            this.label8.TabIndex = 3;
            // 
            // pnl_AddPosition
            // 
            this.pnl_AddPosition.BackColor = System.Drawing.Color.Honeydew;
            this.pnl_AddPosition.Controls.Add(this.btn_Back2MainAP);
            this.pnl_AddPosition.Controls.Add(this.label9);
            this.pnl_AddPosition.Controls.Add(this.label10);
            this.pnl_AddPosition.Controls.Add(this.label11);
            this.pnl_AddPosition.Location = new System.Drawing.Point(3, 31);
            this.pnl_AddPosition.Name = "pnl_AddPosition";
            this.pnl_AddPosition.Size = new System.Drawing.Size(632, 379);
            this.pnl_AddPosition.TabIndex = 9;
            // 
            // btn_Back2MainAP
            // 
            this.btn_Back2MainAP.BackColor = System.Drawing.Color.Honeydew;
            this.btn_Back2MainAP.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btn_Back2MainAP.FlatAppearance.BorderSize = 0;
            this.btn_Back2MainAP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back2MainAP.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Back2MainAP.Location = new System.Drawing.Point(9, 10);
            this.btn_Back2MainAP.Name = "btn_Back2MainAP";
            this.btn_Back2MainAP.Size = new System.Drawing.Size(25, 25);
            this.btn_Back2MainAP.TabIndex = 6;
            this.btn_Back2MainAP.Text = "←";
            this.btn_Back2MainAP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Back2MainAP.UseVisualStyleBackColor = false;
            this.btn_Back2MainAP.Click += new System.EventHandler(this.btn_Back2MainAP_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 55);
            this.label9.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(38, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 55);
            this.label10.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(520, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 32);
            this.label11.TabIndex = 3;
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Search.Location = new System.Drawing.Point(348, 282);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(263, 41);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Пошук працівників";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // pnl_Search
            // 
            this.pnl_Search.BackColor = System.Drawing.Color.Honeydew;
            this.pnl_Search.Controls.Add(this.btn_Back2MainS);
            this.pnl_Search.Controls.Add(this.label12);
            this.pnl_Search.Controls.Add(this.label13);
            this.pnl_Search.Controls.Add(this.label14);
            this.pnl_Search.Location = new System.Drawing.Point(3, 0);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(638, 382);
            this.pnl_Search.TabIndex = 10;
            // 
            // btn_Back2MainS
            // 
            this.btn_Back2MainS.BackColor = System.Drawing.Color.Honeydew;
            this.btn_Back2MainS.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btn_Back2MainS.FlatAppearance.BorderSize = 0;
            this.btn_Back2MainS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back2MainS.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Back2MainS.Location = new System.Drawing.Point(9, 10);
            this.btn_Back2MainS.Name = "btn_Back2MainS";
            this.btn_Back2MainS.Size = new System.Drawing.Size(25, 25);
            this.btn_Back2MainS.TabIndex = 6;
            this.btn_Back2MainS.Text = "←";
            this.btn_Back2MainS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Back2MainS.UseVisualStyleBackColor = false;
            this.btn_Back2MainS.Click += new System.EventHandler(this.btn_Back2MainS_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(12, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 55);
            this.label12.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(38, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 55);
            this.label13.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(520, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 32);
            this.label14.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Confirm_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(638, 447);
            this.Controls.Add(this.pnl_AddPosition);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnl_Authorization);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Відділ кадрів";
            this.pnl_Authorization.ResumeLayout(false);
            this.pnl_Authorization.PerformLayout();
            this.pnl_MainMenu.ResumeLayout(false);
            this.pnl_MainMenu.PerformLayout();
            this.pnl_AddWorker.ResumeLayout(false);
            this.pnl_AddWorker.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ss_StatusStrip.ResumeLayout(false);
            this.ss_StatusStrip.PerformLayout();
            this.ss_ConnectStrip.ResumeLayout(false);
            this.ss_ConnectStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_ShowReports.ResumeLayout(false);
            this.pnl_ShowReports.PerformLayout();
            this.pnl_AddPosition.ResumeLayout(false);
            this.pnl_AddPosition.PerformLayout();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Authorization;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Confirm_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_MainMenu;
        private System.Windows.Forms.Button btn_AddWorker;
        private System.Windows.Forms.Timer tmr_ClearStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip ss_StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ts_StatusLabel;
        private System.Windows.Forms.StatusStrip ss_ConnectStrip;
        private System.Windows.Forms.ToolStripStatusLabel ts_ConnectIndicator;
        private System.Windows.Forms.Button btn_ShowReports;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перепідключитисьДоБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інформаціяПроКористувачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інформаціяПроРозробникаToolStripMenuItem;
        private System.Windows.Forms.Button btn_AddPosition;
        private System.Windows.Forms.Label lbl_Notification;
        private System.Windows.Forms.Timer tmr_Timer;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Panel pnl_AddWorker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Back2Main;
        private System.Windows.Forms.Panel pnl_ShowReports;
        private System.Windows.Forms.Button btn_Back2MainSR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnl_AddPosition;
        private System.Windows.Forms.Button btn_Back2MainAP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel pnl_Search;
        private System.Windows.Forms.Button btn_Back2MainS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

