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
            HideAll();
            pnl_Authorization.Dock = DockStyle.Fill;
            pnl_Authorization.Show();
        }
        
        private void HideAll()
        {
            pnl_Position.Hide();
            //pnl_ShowReports.Hide();
            pnl_Workers.Hide();
            pnl_MainMenu.Hide();
            //pnl_Search.Hide();
            pnl_Authorization.Hide();
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
            pnl_MainMenu.Dock = DockStyle.Fill;
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
            connectStr.UserID = "snow";
            connectStr.Password = "12345";

            connect = new SqlConnection(connectStr.ConnectionString);
            connect.Open();

            ts_ConnectIndicator.Text = "Підключено";
            ts_ConnectIndicator.ForeColor = System.Drawing.Color.Green;
            перепідключитисьДоБДToolStripMenuItem.Enabled = true;
            string str = "tyui";


            //for insert

            //SqlCommand tyui = new SqlCommand(str, connect);
            //tyui.ExecuteNonQuery();


            //for select
            //SqlCommand tyui = new SqlCommand(str, connect);
            //tyui.ExecuteNonQuery();
            //SqlDataReader reader = tyui.ExecuteReader();
            //while(reader.Read())
            //{
            //    datagrid.rows.add(reader[0],reader[1], reader[2]);
            //}
            //reader.Close();

            //Event cellcontentclick при кліканні на рядок 
            //textgrid.currentrow.cells[0].value.tostring();
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

        private void btn_Back2Main_Click(object sender, EventArgs e)
        {
            dgw_WorkersList.Rows.Clear();
            pnl_Workers.Hide();
            pnl_MainMenu.Show();
        }

        private void інформаціяПроРозробникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Розробив студент групи КН-14 Танасюк Ілля Курсова робота з СТУБД");
        }

        private void ShowAllWorkers()
        {
            string query4ShowAll = "select * from Кадри";

            SqlCommand cmdShowWorkers = new SqlCommand(query4ShowAll, connect);
            SqlDataReader reader = cmdShowWorkers.ExecuteReader();

            while (reader.Read())
            {
                dgw_WorkersList.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
            }
            reader.Close();
        }

        private void btn_Workers_Click(object sender, EventArgs e)
        {

            pnl_MainMenu.Hide();
            pnl_Workers.Dock = DockStyle.Fill;
            pnl_Workers.Show();

            ShowAllWorkers();
        }

        private void btn_Back2MainAP_Click(object sender, EventArgs e)
        {
            pnl_Position.Hide();
            pnl_MainMenu.Show();
        }

        private void btn_Position_Click(object sender, EventArgs e)
        {
            pnl_MainMenu.Hide();
            pnl_Position.Dock = DockStyle.Fill;
            pnl_Position.Show();
        }

        private void AddWorkerChangeColourMainEl(System.Drawing.Color color)
        {
            tb_AddWorkerLastName.BackColor = color;
            tb_AddWorkerName.BackColor = color;
            tb_AddWorkerSurname.BackColor = color;
            label18.BackColor = color;
            cb_AddWorkerGender.BackColor = color;
        }

        private void btn_AddWorkerAccept_Click(object sender, EventArgs e)
        {
            if(tb_AddWorkerLastName.Text == "" || tb_AddWorkerName.Text == "" || tb_AddWorkerSurname.Text == ""||
                dtp_AddWorkerBDay.Value.Date == DateTime.Now.Date || cb_AddWorkerGender.SelectedItem == null)
            {
                AddWorkerChangeColourMainEl(System.Drawing.Color.LightPink);
                MessageBox.Show("Не заповнені ключові поля");
            }
            else
            {
                AddWorkerChangeColourMainEl(System.Drawing.Color.White);
                string addNewWorker = "use HumanRecourcesDepartment exec AddWorker '" + tb_AddWorkerLastName.Text + "', '"
                                 + tb_AddWorkerName.Text + "', '" + tb_AddWorkerSurname.Text + "', '"
                                 + dtp_AddWorkerBDay.Value.Date + "', '" + rb_AddWorkerHiEd.Checked + "', '"
                                 + cb_AddWorkerGender.SelectedItem + "'";

                SqlCommand cmdAddWorkers = new SqlCommand(addNewWorker, connect);
                cmdAddWorkers.ExecuteNonQuery();
            }
            
            AddWorkerClear();
            
            ts_StatusLabel.Text = ("Працівника додано");
            tmr_ClearStatus.Enabled = true;
        }

        private void AddWorkerClear()
        {
            tb_AddWorkerLastName.Text = "";
            tb_AddWorkerName.Text = "";
            tb_AddWorkerSurname.Text = "";
            dtp_AddWorkerBDay.Text = "";
            rb_AddWorkerHiEd.Checked = false;
            cb_AddWorkerGender.SelectedIndex = -1;
        }

        private void WorkerEditShowWorkers()
        {
            dgw_EditWorker.Rows.Clear();

            string query4Search = "use HumanRecourcesDepartment select * from Кадри where кодКадру like '" + tb_IDworker4Edit.Text +
                "%' and Прізвище  like '" + tb_LastNameWorker4Edit.Text + "%' and ім_я like '"
                + tb_NameWorker4Edit.Text + "%' and поБатькові like '" + tb_SurNameWorker4Edit.Text + "%'" +
                " and датаНародження like '%' and вищаОсвіта = '" +
                rb_EditHiEd.Checked + "' and Стать like '" + cb_EditWorkerGender.SelectedItem + "%'";
            Clipboard.SetText(query4Search);

            SqlCommand cmdSearch4Edit = new SqlCommand(query4Search, connect);
            SqlDataReader reader = cmdSearch4Edit.ExecuteReader();

            while(reader.Read())
            {
                dgw_EditWorker.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
            }

            reader.Close();
            if (tb_IDworker4Edit.Text == "" && tb_LastNameWorker4Edit.Text == "" && tb_NameWorker4Edit.Text == ""
                && tb_SurNameWorker4Edit.Text == "")
            {
                dgw_EditWorker.Rows.Clear();
            }
        }

        private void tb_IDworker4Edit_TextChanged(object sender, EventArgs e)
        {
            WorkerEditShowWorkers();
        }

        private void tb_LastNameWorker4Edit_TextChanged(object sender, EventArgs e)
        {
            WorkerEditShowWorkers();
        }

        private void tb_NameWorker4Edit_TextChanged(object sender, EventArgs e)
        {
            WorkerEditShowWorkers();
        }

        private void tb_SurNameWorker4Edit_TextChanged(object sender, EventArgs e)
        {
            WorkerEditShowWorkers();
        }

        private void dgw_EditWorker_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgw_EditWorker.CurrentRow != null)
            {
                tb_IDworker4Edit.Text = dgw_EditWorker.CurrentRow.Cells[0].Value.ToString();
                tb_LastNameWorker4Edit.Text = dgw_EditWorker.CurrentRow.Cells[1].Value.ToString();
                tb_NameWorker4Edit.Text = dgw_EditWorker.CurrentRow.Cells[2].Value.ToString();
                tb_SurNameWorker4Edit.Text = dgw_EditWorker.CurrentRow.Cells[3].Value.ToString();
                rb_EditHiEd.Checked = Convert.ToBoolean(dgw_EditWorker.CurrentRow.Cells[5].Value);
                cb_EditWorkerGender.SelectedItem = dgw_EditWorker.CurrentRow.Cells[6].Value.ToString();
                dtp_EditBDay.Value = Convert.ToDateTime(dgw_EditWorker.CurrentRow.Cells[4].Value);
                tb_IDworker4Edit.Enabled = false;
            }
        }

        private void rb_EditHiEd_CheckedChanged(object sender, EventArgs e)
        {
            WorkerEditShowWorkers();
        }

        private void cb_EditWorkerGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            WorkerEditShowWorkers();
        }

        private void dtp_EditBDay_ValueChanged(object sender, EventArgs e)
        {
            WorkerEditShowWorkers();
        }

        private void btn_EditWorker_Click(object sender, EventArgs e)
        {
            string queryUpdate = "use HumanRecourcesDepartment exec UpdateWorker " + tb_IDworker4Edit.Text + ", " + tb_LastNameWorker4Edit.Text +
                ", " + tb_NameWorker4Edit.Text + ", " + tb_SurNameWorker4Edit.Text + ", '" + dtp_EditBDay.Value.Date +
                "', " + rb_EditHiEd.Checked + ", " + cb_EditWorkerGender.SelectedItem;

            

            SqlCommand cmdUpdate = new SqlCommand(queryUpdate, connect);
            cmdUpdate.ExecuteNonQuery();

            ClearEdit();
            ts_StatusLabel.Text = ("Дані оновлено");
            tmr_ClearStatus.Enabled = true;
            tb_IDworker4Edit.Enabled = true;
        }

        private void ClearEdit()
        {
            tb_IDworker4Edit.Text = "";
            tb_LastNameWorker4Edit.Text = "";
            tb_NameWorker4Edit.Text = "";
            tb_SurNameWorker4Edit.Text = "";
            dtp_EditBDay.Text = "";
            cb_EditWorkerGender.SelectedIndex = -1;
            rb_EditHiEd.Checked = false;
        }

        private void btn_ClearEdit_Click(object sender, EventArgs e)
        {
            tb_IDworker4Edit.Text = "";
            tb_LastNameWorker4Edit.Text = "";
            tb_NameWorker4Edit.Text = "";
            tb_SurNameWorker4Edit.Text = "";
            dtp_EditBDay.Value = DateTime.Now;
            rb_EditHiEd.Checked = false;
            cb_EditWorkerGender.SelectedIndex = -1;
            tb_IDworker4Edit.Enabled = true;
        }
    }
}
