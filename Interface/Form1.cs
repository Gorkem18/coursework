using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        SqlConnection connect = null;

        public Form1()
        {
            InitializeComponent();
            tmr_ClearStatus.Interval = 10000;
            tmr_Timer.Interval = 1000;
            tmr_Timer.Enabled = true;
            pnl_AddPosition.Hide();
            pnl_ShowReports.Hide();
            pnl_AddWorker.Hide();
            pnl_MainMenu.Hide();
            pnl_Search.Hide();
            pnl_Authorization.Show();

        }
        
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Confirm_Login_Click(object sender, EventArgs e)
        {
            //string login = "hello_its_me";
            //string password = "12345_rabbit_goes_2_walk";

            string login = "odmen";
            string password = "odmen";

            if (tb_Login.Text == login && tb_Password.Text == password)
            {
                AuthorizationSuccesful();
            }
            else
            {
                tb_Password.Text = "";
                MessageBox.Show("Неправильний логін, або пароль");
            }
        }

        private void tmr_ClearStatus_Tick(object sender, EventArgs e)
        {
            ts_StatusLabel.Text = "";
            tmr_ClearStatus.Enabled = false;
        }

        private void tmr_Timer_Tick(object sender, EventArgs e)
        {
            string time = "";
            if (DateTime.Now.Hour < 10)
                time += "0" + DateTime.Now.Hour.ToString() + ":";
            else
                time += DateTime.Now.Hour.ToString() + ":";

            if (DateTime.Now.Minute < 10)
                time += "0" + DateTime.Now.Minute.ToString() + ":";
            else
                time += DateTime.Now.Minute.ToString() + ":";

            if (DateTime.Now.Second < 10)
                time += "0" + DateTime.Now.Second.ToString();
            else
                time += DateTime.Now.Second.ToString();

            lbl_Time.Text = time;


            string date = "";
            if (DateTime.Now.Day < 10)
                date += "0" + DateTime.Now.Day.ToString() + ".";
            else
                date += DateTime.Now.Day.ToString() + ".";

            if (DateTime.Now.Month < 10)
                date += "0" + DateTime.Now.Month.ToString() + ".";
            else
                date += DateTime.Now.Month.ToString() + ".";

            if (DateTime.Now.Year < 10)
                date += "0" + DateTime.Now.Year.ToString();
            else
                date += DateTime.Now.Year.ToString();

            lbl_Date.Text = date;
        }

        private void AuthorizationSuccesful ()
        {
            pnl_MainMenu.Show();
            ts_StatusLabel.Text = "Авторизація пройшла успішно";
            tmr_ClearStatus.Enabled = true;
            інформаціяПроКористувачаToolStripMenuItem.Enabled = true;

            DBconnect();
        }

        private void DBconnect()
        {
            SqlConnectionStringBuilder connectStr = new SqlConnectionStringBuilder();
            connectStr.DataSource = @"BIFROST\SQLEXPRESS";
            connectStr.InitialCatalog = "HumanRecourcesDepartment";
            connectStr.UserID = "Admin";
            connectStr.Password = "12345";

            connect = new SqlConnection(connectStr.ConnectionString);
            connect.Open();

            ts_ConnectIndicator.Text = "Підключено";
            ts_ConnectIndicator.ForeColor = System.Drawing.Color.Green;
            перепідключитисьДоБДToolStripMenuItem.Enabled = true;
        }

        private void DBdisconnect()
        {
            connect.Close();
            перепідключитисьДоБДToolStripMenuItem.Enabled = false;
            ts_ConnectIndicator.Text = "Відключено";
            ts_ConnectIndicator.ForeColor = System.Drawing.Color.Red;
        }

        private void перепідключитисьДоБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBdisconnect();
            DBconnect();
        }

        private void btn_AddWorker_Click(object sender, EventArgs e)
        {
            pnl_AddWorker.Show();
        }

        private void btn_ShowReports_Click(object sender, EventArgs e)
        {
            pnl_ShowReports.Show();
        }

        private void btn_AddPosition_Click(object sender, EventArgs e)
        {
            pnl_AddPosition.Show();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            pnl_Search.Show();
        }

        private void btn_Back2Main_Click(object sender, EventArgs e)
        {
            pnl_AddWorker.Hide();
            pnl_MainMenu.Show();
        }

        private void btn_Back2MainSR_Click(object sender, EventArgs e)
        {
            pnl_ShowReports.Hide();
            pnl_MainMenu.Show();
        }

        private void btn_Back2MainAP_Click(object sender, EventArgs e)
        {
            pnl_AddPosition.Hide();
            pnl_MainMenu.Show();
        }

        private void btn_Back2MainS_Click(object sender, EventArgs e)
        {
            pnl_Search.Hide();
            pnl_MainMenu.Show();
        }
    }
}
