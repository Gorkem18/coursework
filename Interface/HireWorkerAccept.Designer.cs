namespace Interface
{
    partial class HireWorkerAccept
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_HireWorker = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.dtp_HireWorkerEndContr = new System.Windows.Forms.DateTimePicker();
            this.dtp_HireWorkerStartContract = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tb_HireWorkerCodePosition = new System.Windows.Forms.TextBox();
            this.cb_PaymentIndex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_HireWorkerCodeWorker = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_HireWorker
            // 
            this.btn_HireWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_HireWorker.Location = new System.Drawing.Point(233, 387);
            this.btn_HireWorker.Name = "btn_HireWorker";
            this.btn_HireWorker.Size = new System.Drawing.Size(303, 38);
            this.btn_HireWorker.TabIndex = 17;
            this.btn_HireWorker.Text = "Найняти працівника";
            this.btn_HireWorker.UseVisualStyleBackColor = true;
            this.btn_HireWorker.Click += new System.EventHandler(this.btn_HireWorker_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(49, 256);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(325, 29);
            this.label27.TabIndex = 16;
            this.label27.Text = "Дата закінчення контракту";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(49, 189);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(328, 29);
            this.label26.TabIndex = 15;
            this.label26.Text = "Дата підписання контракту";
            // 
            // dtp_HireWorkerEndContr
            // 
            this.dtp_HireWorkerEndContr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_HireWorkerEndContr.Location = new System.Drawing.Point(435, 256);
            this.dtp_HireWorkerEndContr.Name = "dtp_HireWorkerEndContr";
            this.dtp_HireWorkerEndContr.Size = new System.Drawing.Size(253, 34);
            this.dtp_HireWorkerEndContr.TabIndex = 14;
            // 
            // dtp_HireWorkerStartContract
            // 
            this.dtp_HireWorkerStartContract.Enabled = false;
            this.dtp_HireWorkerStartContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_HireWorkerStartContract.Location = new System.Drawing.Point(435, 175);
            this.dtp_HireWorkerStartContract.Name = "dtp_HireWorkerStartContract";
            this.dtp_HireWorkerStartContract.Size = new System.Drawing.Size(253, 34);
            this.dtp_HireWorkerStartContract.TabIndex = 13;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(228, 104);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(146, 29);
            this.label25.TabIndex = 12;
            this.label25.Text = "Код посади";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(180, 28);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(194, 29);
            this.label24.TabIndex = 11;
            this.label24.Text = "Код працівника";
            // 
            // tb_HireWorkerCodePosition
            // 
            this.tb_HireWorkerCodePosition.Enabled = false;
            this.tb_HireWorkerCodePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_HireWorkerCodePosition.Location = new System.Drawing.Point(435, 104);
            this.tb_HireWorkerCodePosition.Name = "tb_HireWorkerCodePosition";
            this.tb_HireWorkerCodePosition.Size = new System.Drawing.Size(115, 34);
            this.tb_HireWorkerCodePosition.TabIndex = 10;
            // 
            // cb_PaymentIndex
            // 
            this.cb_PaymentIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PaymentIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_PaymentIndex.FormattingEnabled = true;
            this.cb_PaymentIndex.Items.AddRange(new object[] {
            "",
            "1"});
            this.cb_PaymentIndex.Location = new System.Drawing.Point(432, 325);
            this.cb_PaymentIndex.Name = "cb_PaymentIndex";
            this.cb_PaymentIndex.Size = new System.Drawing.Size(121, 37);
            this.cb_PaymentIndex.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(281, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ставка";
            // 
            // tb_HireWorkerCodeWorker
            // 
            this.tb_HireWorkerCodeWorker.Enabled = false;
            this.tb_HireWorkerCodeWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_HireWorkerCodeWorker.Location = new System.Drawing.Point(436, 35);
            this.tb_HireWorkerCodeWorker.Name = "tb_HireWorkerCodeWorker";
            this.tb_HireWorkerCodeWorker.Size = new System.Drawing.Size(114, 34);
            this.tb_HireWorkerCodeWorker.TabIndex = 20;
            // 
            // HireWorkerAccept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(763, 469);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.tb_HireWorkerCodeWorker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_PaymentIndex);
            this.Controls.Add(this.btn_HireWorker);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.dtp_HireWorkerEndContr);
            this.Controls.Add(this.dtp_HireWorkerStartContract);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.tb_HireWorkerCodePosition);
            this.Name = "HireWorkerAccept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Найняти працівника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HireWorker;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker dtp_HireWorkerEndContr;
        private System.Windows.Forms.DateTimePicker dtp_HireWorkerStartContract;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tb_HireWorkerCodePosition;
        private System.Windows.Forms.ComboBox cb_PaymentIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_HireWorkerCodeWorker;
    }
}