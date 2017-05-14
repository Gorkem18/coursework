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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Confirm_Login = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Workers = new System.Windows.Forms.Panel();
            this.tc_Workers = new System.Windows.Forms.TabControl();
            this.tp_AddWorker = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_AddWorkerAccept = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tp_EditWorker = new System.Windows.Forms.TabPage();
            this.tb_SurNameWorker4Edit = new System.Windows.Forms.TextBox();
            this.tb_NameWorker4Edit = new System.Windows.Forms.TextBox();
            this.tb_LastNameWorker4Edit = new System.Windows.Forms.TextBox();
            this.tb_IDworker4Edit = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_SearchWorker4Edit = new System.Windows.Forms.Button();
            this.btn_EditWorker = new System.Windows.Forms.Button();
            this.dgw_EditWorker = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_ShowWorkers = new System.Windows.Forms.TabPage();
            this.dgw_WorkersList = new System.Windows.Forms.DataGridView();
            this.WorkerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkerSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkerBDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkerHiEdu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkerGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_HireWorker = new System.Windows.Forms.TabPage();
            this.tp_FireWorker = new System.Windows.Forms.TabPage();
            this.btn_Back2Main = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_Position = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_AddPositionAccept = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tb_payment = new System.Windows.Forms.TextBox();
            this.tb_NameOfPosition = new System.Windows.Forms.TextBox();
            this.btn_Back2MainAP = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pnl_MainMenu = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_Notification = new System.Windows.Forms.Label();
            this.btn_Position = new System.Windows.Forms.Button();
            this.btn_Reports = new System.Windows.Forms.Button();
            this.btn_Workers = new System.Windows.Forms.Button();
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
            this.pnl_Authorization.SuspendLayout();
            this.pnl_Workers.SuspendLayout();
            this.tc_Workers.SuspendLayout();
            this.tp_AddWorker.SuspendLayout();
            this.tp_EditWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_EditWorker)).BeginInit();
            this.tp_ShowWorkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_WorkersList)).BeginInit();
            this.pnl_Position.SuspendLayout();
            this.pnl_MainMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ss_StatusStrip.SuspendLayout();
            this.ss_ConnectStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Authorization
            // 
            this.pnl_Authorization.BackColor = System.Drawing.Color.Honeydew;
            this.pnl_Authorization.Controls.Add(this.btn_Exit);
            this.pnl_Authorization.Controls.Add(this.btn_Confirm_Login);
            this.pnl_Authorization.Controls.Add(this.tb_Password);
            this.pnl_Authorization.Controls.Add(this.tb_Login);
            this.pnl_Authorization.Controls.Add(this.label2);
            this.pnl_Authorization.Controls.Add(this.label1);
            this.pnl_Authorization.Location = new System.Drawing.Point(254, 89);
            this.pnl_Authorization.Name = "pnl_Authorization";
            this.pnl_Authorization.Size = new System.Drawing.Size(32, 28);
            this.pnl_Authorization.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Exit.Location = new System.Drawing.Point(296, 214);
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
            this.btn_Confirm_Login.Location = new System.Drawing.Point(167, 214);
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
            this.tb_Password.Location = new System.Drawing.Point(282, 141);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(196, 34);
            this.tb_Password.TabIndex = 3;
            // 
            // tb_Login
            // 
            this.tb_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Login.Location = new System.Drawing.Point(282, 92);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(196, 34);
            this.tb_Login.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(133, 144);
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
            this.label1.Location = new System.Drawing.Point(133, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логін";
            // 
            // pnl_Workers
            // 
            this.pnl_Workers.BackColor = System.Drawing.Color.Honeydew;
            this.pnl_Workers.Controls.Add(this.tc_Workers);
            this.pnl_Workers.Controls.Add(this.btn_Back2Main);
            this.pnl_Workers.Controls.Add(this.label3);
            this.pnl_Workers.Controls.Add(this.label4);
            this.pnl_Workers.Location = new System.Drawing.Point(0, 31);
            this.pnl_Workers.Name = "pnl_Workers";
            this.pnl_Workers.Size = new System.Drawing.Size(835, 454);
            this.pnl_Workers.TabIndex = 7;
            // 
            // tc_Workers
            // 
            this.tc_Workers.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tc_Workers.Controls.Add(this.tp_AddWorker);
            this.tc_Workers.Controls.Add(this.tp_EditWorker);
            this.tc_Workers.Controls.Add(this.tp_ShowWorkers);
            this.tc_Workers.Controls.Add(this.tp_HireWorker);
            this.tc_Workers.Controls.Add(this.tp_FireWorker);
            this.tc_Workers.Location = new System.Drawing.Point(39, 5);
            this.tc_Workers.Name = "tc_Workers";
            this.tc_Workers.SelectedIndex = 0;
            this.tc_Workers.Size = new System.Drawing.Size(796, 443);
            this.tc_Workers.TabIndex = 21;
            // 
            // tp_AddWorker
            // 
            this.tp_AddWorker.BackColor = System.Drawing.Color.Honeydew;
            this.tp_AddWorker.Controls.Add(this.label6);
            this.tp_AddWorker.Controls.Add(this.comboBox1);
            this.tp_AddWorker.Controls.Add(this.label18);
            this.tp_AddWorker.Controls.Add(this.label17);
            this.tp_AddWorker.Controls.Add(this.label16);
            this.tp_AddWorker.Controls.Add(this.label15);
            this.tp_AddWorker.Controls.Add(this.btn_AddWorkerAccept);
            this.tp_AddWorker.Controls.Add(this.radioButton1);
            this.tp_AddWorker.Controls.Add(this.dateTimePicker1);
            this.tp_AddWorker.Controls.Add(this.textBox3);
            this.tp_AddWorker.Controls.Add(this.textBox2);
            this.tp_AddWorker.Controls.Add(this.textBox1);
            this.tp_AddWorker.Controls.Add(this.label5);
            this.tp_AddWorker.Location = new System.Drawing.Point(4, 28);
            this.tp_AddWorker.Name = "tp_AddWorker";
            this.tp_AddWorker.Padding = new System.Windows.Forms.Padding(3);
            this.tp_AddWorker.Size = new System.Drawing.Size(788, 411);
            this.tp_AddWorker.TabIndex = 1;
            this.tp_AddWorker.Text = "Додати ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(111, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 29);
            this.label6.TabIndex = 33;
            this.label6.Text = "Стать";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Чоловіча",
            "Жіноча"});
            this.comboBox1.Location = new System.Drawing.Point(321, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 37);
            this.comboBox1.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(111, 221);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(219, 29);
            this.label18.TabIndex = 31;
            this.label18.Text = "Дата народження";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(111, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(149, 29);
            this.label17.TabIndex = 30;
            this.label17.Text = "По-батькові";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(111, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 29);
            this.label16.TabIndex = 29;
            this.label16.Text = "Ім\'я";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(111, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 29);
            this.label15.TabIndex = 28;
            this.label15.Text = "Прізвище";
            // 
            // btn_AddWorkerAccept
            // 
            this.btn_AddWorkerAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddWorkerAccept.Location = new System.Drawing.Point(212, 290);
            this.btn_AddWorkerAccept.Name = "btn_AddWorkerAccept";
            this.btn_AddWorkerAccept.Size = new System.Drawing.Size(278, 49);
            this.btn_AddWorkerAccept.TabIndex = 27;
            this.btn_AddWorkerAccept.Text = "Додати працівника";
            this.btn_AddWorkerAccept.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(494, 168);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(174, 33);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Вища освіта";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(348, 216);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 34);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(321, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 34);
            this.textBox3.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(321, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 34);
            this.textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(321, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 34);
            this.textBox1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(542, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 32);
            this.label5.TabIndex = 21;
            // 
            // tp_EditWorker
            // 
            this.tp_EditWorker.BackColor = System.Drawing.Color.Honeydew;
            this.tp_EditWorker.Controls.Add(this.tb_SurNameWorker4Edit);
            this.tp_EditWorker.Controls.Add(this.tb_NameWorker4Edit);
            this.tp_EditWorker.Controls.Add(this.tb_LastNameWorker4Edit);
            this.tp_EditWorker.Controls.Add(this.tb_IDworker4Edit);
            this.tp_EditWorker.Controls.Add(this.label19);
            this.tp_EditWorker.Controls.Add(this.label14);
            this.tp_EditWorker.Controls.Add(this.label13);
            this.tp_EditWorker.Controls.Add(this.label8);
            this.tp_EditWorker.Controls.Add(this.btn_SearchWorker4Edit);
            this.tp_EditWorker.Controls.Add(this.btn_EditWorker);
            this.tp_EditWorker.Controls.Add(this.dgw_EditWorker);
            this.tp_EditWorker.Location = new System.Drawing.Point(4, 28);
            this.tp_EditWorker.Name = "tp_EditWorker";
            this.tp_EditWorker.Size = new System.Drawing.Size(788, 411);
            this.tp_EditWorker.TabIndex = 2;
            this.tp_EditWorker.Text = "Редагувати ";
            // 
            // tb_SurNameWorker4Edit
            // 
            this.tb_SurNameWorker4Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_SurNameWorker4Edit.Location = new System.Drawing.Point(311, 168);
            this.tb_SurNameWorker4Edit.Name = "tb_SurNameWorker4Edit";
            this.tb_SurNameWorker4Edit.Size = new System.Drawing.Size(140, 34);
            this.tb_SurNameWorker4Edit.TabIndex = 11;
            // 
            // tb_NameWorker4Edit
            // 
            this.tb_NameWorker4Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_NameWorker4Edit.Location = new System.Drawing.Point(311, 120);
            this.tb_NameWorker4Edit.Name = "tb_NameWorker4Edit";
            this.tb_NameWorker4Edit.Size = new System.Drawing.Size(140, 34);
            this.tb_NameWorker4Edit.TabIndex = 10;
            // 
            // tb_LastNameWorker4Edit
            // 
            this.tb_LastNameWorker4Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_LastNameWorker4Edit.Location = new System.Drawing.Point(311, 73);
            this.tb_LastNameWorker4Edit.Name = "tb_LastNameWorker4Edit";
            this.tb_LastNameWorker4Edit.Size = new System.Drawing.Size(140, 34);
            this.tb_LastNameWorker4Edit.TabIndex = 9;
            // 
            // tb_IDworker4Edit
            // 
            this.tb_IDworker4Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_IDworker4Edit.Location = new System.Drawing.Point(311, 22);
            this.tb_IDworker4Edit.Name = "tb_IDworker4Edit";
            this.tb_IDworker4Edit.Size = new System.Drawing.Size(69, 34);
            this.tb_IDworker4Edit.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(150, 169);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(142, 29);
            this.label19.TabIndex = 7;
            this.label19.Text = "ПоБатькові";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(150, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 29);
            this.label14.TabIndex = 6;
            this.label14.Text = "Ім\'я";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(150, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 29);
            this.label13.TabIndex = 5;
            this.label13.Text = "Прізвище";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(150, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 29);
            this.label8.TabIndex = 4;
            this.label8.Text = "ID";
            // 
            // btn_SearchWorker4Edit
            // 
            this.btn_SearchWorker4Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SearchWorker4Edit.Location = new System.Drawing.Point(147, 218);
            this.btn_SearchWorker4Edit.Name = "btn_SearchWorker4Edit";
            this.btn_SearchWorker4Edit.Size = new System.Drawing.Size(145, 38);
            this.btn_SearchWorker4Edit.TabIndex = 3;
            this.btn_SearchWorker4Edit.Text = "Знайти ";
            this.btn_SearchWorker4Edit.UseVisualStyleBackColor = true;
            // 
            // btn_EditWorker
            // 
            this.btn_EditWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_EditWorker.Location = new System.Drawing.Point(311, 216);
            this.btn_EditWorker.Name = "btn_EditWorker";
            this.btn_EditWorker.Size = new System.Drawing.Size(132, 38);
            this.btn_EditWorker.TabIndex = 2;
            this.btn_EditWorker.Text = "Змінити";
            this.btn_EditWorker.UseVisualStyleBackColor = true;
            // 
            // dgw_EditWorker
            // 
            this.dgw_EditWorker.AllowUserToAddRows = false;
            this.dgw_EditWorker.AllowUserToDeleteRows = false;
            this.dgw_EditWorker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw_EditWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_EditWorker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgw_EditWorker.Location = new System.Drawing.Point(-4, 270);
            this.dgw_EditWorker.Name = "dgw_EditWorker";
            this.dgw_EditWorker.ReadOnly = true;
            this.dgw_EditWorker.RowTemplate.Height = 24;
            this.dgw_EditWorker.Size = new System.Drawing.Size(792, 141);
            this.dgw_EditWorker.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Прізвище";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Ім\'я";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "ПоБатькові";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ДатаНародження";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "ВищаОсвіта";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Стать";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // tp_ShowWorkers
            // 
            this.tp_ShowWorkers.BackColor = System.Drawing.Color.Honeydew;
            this.tp_ShowWorkers.Controls.Add(this.dgw_WorkersList);
            this.tp_ShowWorkers.Location = new System.Drawing.Point(4, 28);
            this.tp_ShowWorkers.Name = "tp_ShowWorkers";
            this.tp_ShowWorkers.Size = new System.Drawing.Size(788, 411);
            this.tp_ShowWorkers.TabIndex = 3;
            this.tp_ShowWorkers.Text = "Перегляд ";
            // 
            // dgw_WorkersList
            // 
            this.dgw_WorkersList.AllowUserToAddRows = false;
            this.dgw_WorkersList.AllowUserToDeleteRows = false;
            this.dgw_WorkersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw_WorkersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_WorkersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkerID,
            this.WorkerLastName,
            this.WorkerName,
            this.WorkerSurname,
            this.WorkerBDay,
            this.WorkerHiEdu,
            this.WorkerGender});
            this.dgw_WorkersList.Location = new System.Drawing.Point(1, 3);
            this.dgw_WorkersList.Name = "dgw_WorkersList";
            this.dgw_WorkersList.ReadOnly = true;
            this.dgw_WorkersList.RowTemplate.Height = 24;
            this.dgw_WorkersList.Size = new System.Drawing.Size(788, 408);
            this.dgw_WorkersList.TabIndex = 0;
            // 
            // WorkerID
            // 
            this.WorkerID.HeaderText = "ID";
            this.WorkerID.Name = "WorkerID";
            this.WorkerID.ReadOnly = true;
            // 
            // WorkerLastName
            // 
            this.WorkerLastName.HeaderText = "Прізвище";
            this.WorkerLastName.Name = "WorkerLastName";
            this.WorkerLastName.ReadOnly = true;
            // 
            // WorkerName
            // 
            this.WorkerName.HeaderText = "Ім\'я";
            this.WorkerName.Name = "WorkerName";
            this.WorkerName.ReadOnly = true;
            // 
            // WorkerSurname
            // 
            this.WorkerSurname.HeaderText = "ПоБатькові";
            this.WorkerSurname.Name = "WorkerSurname";
            this.WorkerSurname.ReadOnly = true;
            // 
            // WorkerBDay
            // 
            this.WorkerBDay.HeaderText = "ДатаНародження";
            this.WorkerBDay.Name = "WorkerBDay";
            this.WorkerBDay.ReadOnly = true;
            // 
            // WorkerHiEdu
            // 
            this.WorkerHiEdu.HeaderText = "ВищаОсвіта";
            this.WorkerHiEdu.Name = "WorkerHiEdu";
            this.WorkerHiEdu.ReadOnly = true;
            // 
            // WorkerGender
            // 
            this.WorkerGender.HeaderText = "Стать";
            this.WorkerGender.Name = "WorkerGender";
            this.WorkerGender.ReadOnly = true;
            // 
            // tp_HireWorker
            // 
            this.tp_HireWorker.BackColor = System.Drawing.Color.Honeydew;
            this.tp_HireWorker.Location = new System.Drawing.Point(4, 28);
            this.tp_HireWorker.Name = "tp_HireWorker";
            this.tp_HireWorker.Size = new System.Drawing.Size(788, 411);
            this.tp_HireWorker.TabIndex = 4;
            this.tp_HireWorker.Text = "Найняти ";
            // 
            // tp_FireWorker
            // 
            this.tp_FireWorker.BackColor = System.Drawing.Color.Honeydew;
            this.tp_FireWorker.Location = new System.Drawing.Point(4, 28);
            this.tp_FireWorker.Name = "tp_FireWorker";
            this.tp_FireWorker.Size = new System.Drawing.Size(788, 411);
            this.tp_FireWorker.TabIndex = 5;
            this.tp_FireWorker.Text = "Звільнити";
            // 
            // btn_Back2Main
            // 
            this.btn_Back2Main.BackColor = System.Drawing.Color.Honeydew;
            this.btn_Back2Main.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btn_Back2Main.FlatAppearance.BorderSize = 0;
            this.btn_Back2Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back2Main.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Back2Main.Location = new System.Drawing.Point(13, 12);
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
            // pnl_Position
            // 
            this.pnl_Position.BackColor = System.Drawing.Color.Honeydew;
            this.pnl_Position.Controls.Add(this.label7);
            this.pnl_Position.Controls.Add(this.label9);
            this.pnl_Position.Controls.Add(this.btn_AddPositionAccept);
            this.pnl_Position.Controls.Add(this.radioButton2);
            this.pnl_Position.Controls.Add(this.tb_payment);
            this.pnl_Position.Controls.Add(this.tb_NameOfPosition);
            this.pnl_Position.Controls.Add(this.btn_Back2MainAP);
            this.pnl_Position.Controls.Add(this.label10);
            this.pnl_Position.Controls.Add(this.label11);
            this.pnl_Position.Controls.Add(this.label12);
            this.pnl_Position.Location = new System.Drawing.Point(260, 143);
            this.pnl_Position.Name = "pnl_Position";
            this.pnl_Position.Size = new System.Drawing.Size(10, 18);
            this.pnl_Position.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(89, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ставка";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(89, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Назва посади";
            // 
            // btn_AddPositionAccept
            // 
            this.btn_AddPositionAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddPositionAccept.Location = new System.Drawing.Point(141, 227);
            this.btn_AddPositionAccept.Name = "btn_AddPositionAccept";
            this.btn_AddPositionAccept.Size = new System.Drawing.Size(278, 49);
            this.btn_AddPositionAccept.TabIndex = 16;
            this.btn_AddPositionAccept.Text = "Додати посаду";
            this.btn_AddPositionAccept.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(94, 178);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(334, 33);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Необхідність вищої освіти";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // tb_payment
            // 
            this.tb_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_payment.Location = new System.Drawing.Point(296, 122);
            this.tb_payment.Name = "tb_payment";
            this.tb_payment.Size = new System.Drawing.Size(151, 34);
            this.tb_payment.TabIndex = 13;
            // 
            // tb_NameOfPosition
            // 
            this.tb_NameOfPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_NameOfPosition.Location = new System.Drawing.Point(296, 76);
            this.tb_NameOfPosition.Name = "tb_NameOfPosition";
            this.tb_NameOfPosition.Size = new System.Drawing.Size(151, 34);
            this.tb_NameOfPosition.TabIndex = 12;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 55);
            this.label10.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(38, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 55);
            this.label11.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(520, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 32);
            this.label12.TabIndex = 3;
            // 
            // pnl_MainMenu
            // 
            this.pnl_MainMenu.BackColor = System.Drawing.Color.Honeydew;
            this.pnl_MainMenu.Controls.Add(this.btn_Search);
            this.pnl_MainMenu.Controls.Add(this.lbl_Date);
            this.pnl_MainMenu.Controls.Add(this.lbl_Time);
            this.pnl_MainMenu.Controls.Add(this.lbl_Notification);
            this.pnl_MainMenu.Controls.Add(this.btn_Position);
            this.pnl_MainMenu.Controls.Add(this.btn_Reports);
            this.pnl_MainMenu.Controls.Add(this.btn_Workers);
            this.pnl_MainMenu.Location = new System.Drawing.Point(254, 123);
            this.pnl_MainMenu.Name = "pnl_MainMenu";
            this.pnl_MainMenu.Size = new System.Drawing.Size(32, 17);
            this.pnl_MainMenu.TabIndex = 6;
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Search.Location = new System.Drawing.Point(340, 292);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(263, 41);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Пошук ";
            this.btn_Search.UseVisualStyleBackColor = true;
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
            this.lbl_Notification.Location = new System.Drawing.Point(12, 11);
            this.lbl_Notification.Name = "lbl_Notification";
            this.lbl_Notification.Size = new System.Drawing.Size(91, 32);
            this.lbl_Notification.TabIndex = 3;
            this.lbl_Notification.Text = "notific";
            // 
            // btn_Position
            // 
            this.btn_Position.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Position.Location = new System.Drawing.Point(340, 221);
            this.btn_Position.Name = "btn_Position";
            this.btn_Position.Size = new System.Drawing.Size(263, 41);
            this.btn_Position.TabIndex = 2;
            this.btn_Position.Text = "Посади";
            this.btn_Position.UseVisualStyleBackColor = true;
            this.btn_Position.Click += new System.EventHandler(this.btn_Position_Click);
            // 
            // btn_Reports
            // 
            this.btn_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Reports.Location = new System.Drawing.Point(340, 147);
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.Size = new System.Drawing.Size(263, 41);
            this.btn_Reports.TabIndex = 1;
            this.btn_Reports.Text = "Звіти";
            this.btn_Reports.UseVisualStyleBackColor = true;
            // 
            // btn_Workers
            // 
            this.btn_Workers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Workers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Workers.Location = new System.Drawing.Point(340, 72);
            this.btn_Workers.Name = "btn_Workers";
            this.btn_Workers.Size = new System.Drawing.Size(263, 41);
            this.btn_Workers.TabIndex = 0;
            this.btn_Workers.Text = "Працівники";
            this.btn_Workers.UseVisualStyleBackColor = true;
            this.btn_Workers.Click += new System.EventHandler(this.btn_Workers_Click);
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 485);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(835, 28);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ss_StatusStrip
            // 
            this.ss_StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ss_StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_StatusLabel});
            this.ss_StatusStrip.Location = new System.Drawing.Point(0, 6);
            this.ss_StatusStrip.Name = "ss_StatusStrip";
            this.ss_StatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ss_StatusStrip.Size = new System.Drawing.Size(613, 22);
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
            this.ss_ConnectStrip.Location = new System.Drawing.Point(613, 3);
            this.ss_ConnectStrip.Name = "ss_ConnectStrip";
            this.ss_ConnectStrip.Size = new System.Drawing.Size(222, 25);
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
            this.menuStrip1.Size = new System.Drawing.Size(835, 28);
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
            this.інформаціяПроРозробникаToolStripMenuItem.Click += new System.EventHandler(this.інформаціяПроРозробникаToolStripMenuItem_Click);
            // 
            // tmr_Timer
            // 
            this.tmr_Timer.Tick += new System.EventHandler(this.tmr_Timer_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Confirm_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(835, 513);
            this.Controls.Add(this.pnl_Workers);
            this.Controls.Add(this.pnl_Position);
            this.Controls.Add(this.pnl_MainMenu);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnl_Authorization);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Відділ кадрів";
            this.pnl_Authorization.ResumeLayout(false);
            this.pnl_Authorization.PerformLayout();
            this.pnl_Workers.ResumeLayout(false);
            this.pnl_Workers.PerformLayout();
            this.tc_Workers.ResumeLayout(false);
            this.tp_AddWorker.ResumeLayout(false);
            this.tp_AddWorker.PerformLayout();
            this.tp_EditWorker.ResumeLayout(false);
            this.tp_EditWorker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_EditWorker)).EndInit();
            this.tp_ShowWorkers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_WorkersList)).EndInit();
            this.pnl_Position.ResumeLayout(false);
            this.pnl_Position.PerformLayout();
            this.pnl_MainMenu.ResumeLayout(false);
            this.pnl_MainMenu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ss_StatusStrip.ResumeLayout(false);
            this.ss_StatusStrip.PerformLayout();
            this.ss_ConnectStrip.ResumeLayout(false);
            this.ss_ConnectStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btn_Workers;
        private System.Windows.Forms.Timer tmr_ClearStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip ss_StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ts_StatusLabel;
        private System.Windows.Forms.StatusStrip ss_ConnectStrip;
        private System.Windows.Forms.ToolStripStatusLabel ts_ConnectIndicator;
        private System.Windows.Forms.Button btn_Reports;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перепідключитисьДоБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інформаціяПроКористувачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інформаціяПроРозробникаToolStripMenuItem;
        private System.Windows.Forms.Button btn_Position;
        private System.Windows.Forms.Label lbl_Notification;
        private System.Windows.Forms.Timer tmr_Timer;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Panel pnl_Workers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Back2Main;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel pnl_Position;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_AddPositionAccept;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox tb_payment;
        private System.Windows.Forms.TextBox tb_NameOfPosition;
        private System.Windows.Forms.Button btn_Back2MainAP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl tc_Workers;
        private System.Windows.Forms.TabPage tp_AddWorker;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_AddWorkerAccept;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tp_EditWorker;
        private System.Windows.Forms.TabPage tp_ShowWorkers;
        private System.Windows.Forms.DataGridView dgw_WorkersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerBDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerHiEdu;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkerGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tp_HireWorker;
        private System.Windows.Forms.TabPage tp_FireWorker;
        private System.Windows.Forms.TextBox tb_SurNameWorker4Edit;
        private System.Windows.Forms.TextBox tb_NameWorker4Edit;
        private System.Windows.Forms.TextBox tb_LastNameWorker4Edit;
        private System.Windows.Forms.TextBox tb_IDworker4Edit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_SearchWorker4Edit;
        private System.Windows.Forms.Button btn_EditWorker;
        private System.Windows.Forms.DataGridView dgw_EditWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

