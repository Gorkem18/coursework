using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Interface
{
    public partial class MainForm : Form
    {
        SqlConnection connect = null;
        DataGridViewRow hireWorkerRow = null;
        DataGridViewRow hirePositionRow = null;
        DataGridViewRow fireWorker = null;
        public bool indicatorHireWorker = false;
        bool HiEdIndi4Search = false;
        public bool fireWorkerIndi = false;

        public MainForm()
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
            pnl_ShowReports.Hide();
            pnl_Workers.Hide();
            pnl_MainMenu.Hide();
            pnl_Search.Hide();
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
            tsmi_Refresh.Enabled = true;

            DBconnect();
        }

        private void DBconnect()
        {
            SqlConnectionStringBuilder connectStr = new SqlConnectionStringBuilder();
            connectStr.DataSource = @"localhost\SQLEXPRESS";
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
            
            pnl_Workers.Hide();
            pnl_MainMenu.Show();
        }

        private void інформаціяПроРозробникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Розробив студент групи КН-14 Танасюк Ілля Курсова робота з СТУБД");
        }

        private void ShowAllWorkers()
        {
            dgw_WorkersList.Rows.Clear();
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
            LoadNonHiredWorkers();
            LoadNonHiredPositions();
            ShowWorkingNow();
        }

        private void LoadNonHiredWorkers()
        {
            dgw_NonHiredWorkers.Rows.Clear();
            string qNonHiredWorkers = " exec notWorkingNow";
            SqlCommand cmdNonHiredWorkers = new SqlCommand(qNonHiredWorkers, connect);
            SqlDataReader reader = cmdNonHiredWorkers.ExecuteReader();

            while(reader.Read())
            {
                dgw_NonHiredWorkers.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
            }

            reader.Close();
        }

        private void LoadNonHiredPositions()
        {
            dgw_NonHiredPositions.Rows.Clear();
            string query = "select * from nonhiredposts";
            SqlCommand cmdNonHired = new SqlCommand(query, connect);
            SqlDataReader reader = cmdNonHired.ExecuteReader();

            while(reader.Read())
            {
                dgw_NonHiredPositions.Rows.Add(reader[0], reader[1], reader[2], reader[3]);
            }

            reader.Close();
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
            ShowAllPositions();
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
            string gender = "";

            if(cb_EditWorkerGender.SelectedIndex != -1)
            {
                gender = cb_EditWorkerGender.SelectedItem.ToString();
            }

            string query4Search = "select * from Кадри where кодКадру like '" + tb_IDworker4Edit.Text +
                "%' and Прізвище  like '" + tb_LastNameWorker4Edit.Text + "%' and ім_я like '"
                + tb_NameWorker4Edit.Text + "%' and поБатькові like '" + tb_SurNameWorker4Edit.Text + "%'" +
                " and датаНародження like '%' and вищаОсвіта = '" +
                rb_EditHiEd.Checked + "' and Стать like '" + gender + "%'";
            Clipboard.SetText(query4Search);

            SqlCommand cmdSearch4Edit = new SqlCommand(query4Search, connect);
            SqlDataReader reader = cmdSearch4Edit.ExecuteReader();

            while(reader.Read())
            {
                dgw_EditWorker.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
            }
            reader.Close();
            if (tb_IDworker4Edit.Text == "" && tb_LastNameWorker4Edit.Text == "" && tb_NameWorker4Edit.Text == ""
                && tb_SurNameWorker4Edit.Text == "" && cb_EditWorkerGender.SelectedIndex == -1 )
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
            cb_EditWorkerGender.SelectedIndex = -1;
            rb_EditHiEd.Checked = false;
            dtp_EditBDay.Value = DateTime.Now.Date;
            
            dgw_EditWorker.Rows.Clear();
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
        }

        private void btn_Hire_Click(object sender, EventArgs e)
        {
            if(hirePositionRow != null && hirePositionRow != null)
            {
                HireWorkerAccept hwa = new HireWorkerAccept(Convert.ToInt32(hireWorkerRow.Cells[0].Value),
                    Convert.ToInt32(hirePositionRow.Cells[0].Value), connect, this);
                hwa.ShowDialog();
                if(indicatorHireWorker)
                    ts_StatusLabel.Text = "Працівника найнято";

                indicatorHireWorker = false;
            }
            else
            {
                MessageBox.Show("Не вибраний користувач або посада");
            }
        }

        private void dgw_NonHiredWorkers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            hireWorkerRow = dgw_NonHiredWorkers.CurrentRow;
            lbl_HireWorkersindiWorker.Text = "Вибрано";
        }

        private void dgw_NonHiredPositions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            hirePositionRow = dgw_NonHiredPositions.CurrentRow;
            lbl_HireWorkerindiPos.Text = "Вибрано";
        }

        private void btn_ClearMaybeHiredWorer_Click(object sender, EventArgs e)
        {
            dgw_NonHiredWorkers.ClearSelection();
            dgw_NonHiredPositions.ClearSelection();
            hirePositionRow = null;
            hireWorkerRow = null;
            lbl_HireWorkerindiPos.Text = "";
            lbl_HireWorkersindiWorker.Text = "";
        }

        private void tsmi_Refresh_Click(object sender, EventArgs e)
        {
            ShowAllWorkers();
            LoadNonHiredPositions();
            LoadNonHiredWorkers();
            ShowWorkingNow();
            ShowAllPositions();
        }

        private void ShowWorkingNow()
        {
            dgw_ShowWorkingNow.Rows.Clear();
            string qShowWorkingNow = "select * from NowWorkingView";
            SqlCommand cmdWorkingNow = new SqlCommand(qShowWorkingNow, connect);
            SqlDataReader reader = cmdWorkingNow.ExecuteReader();

            while(reader.Read())
            {
                dgw_ShowWorkingNow.Rows.Add(reader[0], reader[1], reader[2], reader[3],
                                            reader[4], reader[5], reader[6], reader[7], reader[8]);
            }
            reader.Close();
        }

        private void btn_AddPositionAccept_Click(object sender, EventArgs e)
        {
            if(tb_AddPositionNameOfPosition.Text != "" && tb_AddPositionpayment.Text != "")
            {
                string qAddPosition = "exec AddNewPosition " + tb_AddPositionNameOfPosition.Text + ", "
                + tb_AddPositionpayment.Text + ", " + rb_AddPositionHiEdRequires.Checked;
                SqlCommand cmdAddPos = new SqlCommand(qAddPosition, connect);
                cmdAddPos.ExecuteNonQuery();
                ts_StatusLabel.Text = "Посаду додано";
                tmr_ClearStatus.Enabled = true;
                AddPositionClear();
            }
            else
            {
                MessageBox.Show("Не заповнені основні поля");
                tb_AddPositionNameOfPosition.BackColor = System.Drawing.Color.LightPink;
                tb_AddPositionpayment.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void AddPositionClear()
        {
            tb_AddPositionNameOfPosition.Text = "";
            tb_AddPositionpayment.Text = "";
            rb_AddPositionHiEdRequires.Checked = false;
            tb_AddPositionNameOfPosition.BackColor = System.Drawing.Color.White;
            tb_AddPositionpayment.BackColor = System.Drawing.Color.White;
        }

        private void ShowAllPositions()
        {
            dgw_ShowAllPosition.Rows.Clear();
            string qShowAllPositions = "select * from штатнийрозпис";
            SqlCommand cmdShowAllPositions = new SqlCommand(qShowAllPositions, connect);
            SqlDataReader reader = cmdShowAllPositions.ExecuteReader();

            while(reader.Read())
            {
                dgw_ShowAllPosition.Rows.Add(reader[0], reader[1], reader[2], reader[3]);
            }

            reader.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            pnl_MainMenu.Hide();
            pnl_Search.Dock = DockStyle.Fill;
            pnl_Search.Show();
        }

        private void btn_Back2MainSearch_Click(object sender, EventArgs e)
        {
            pnl_Search.Hide();
            pnl_MainMenu.Show();
        }

        private void tb_SearchID_TextChanged(object sender, EventArgs e)
        {
            SearchWorker();
        }

        private void tb_SearchLastName_TextChanged(object sender, EventArgs e)
        {
            SearchWorker();
        }

        private void tb_SearchName_TextChanged(object sender, EventArgs e)
        {
            SearchWorker();
        }

        private void tb_SearchSurName_TextChanged(object sender, EventArgs e)
        {
            SearchWorker();
        }

        private void rb_SearchHiEd_CheckedChanged(object sender, EventArgs e)
        {
            HiEdIndi4Search = true;
            SearchWorker();
        }

        private void cb_SearchGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchWorker();
        }

        private void SearchWorker()
        {
            dgw_Search.Rows.Clear();

            string gender = "";
            if (cb_SearchGender.SelectedIndex != -1)
            {
                gender = cb_SearchGender.SelectedItem.ToString();
            }

            string SearchQuery = "select * from Кадри where кодКадру like '" + tb_SearchID.Text +
                "%' and прізвище like '" + tb_SearchLastName.Text + "%'and ім_я like '" + tb_SearchName.Text +
                "%'and побатькові like '" + tb_SearchSurName.Text + "%'and вищаосвіта = '" + rb_SearchHiEd.Checked +
                "' and стать like '" + gender + "%' ";
            SqlCommand cmdSearch = new SqlCommand(SearchQuery, connect);
            SqlDataReader reader = cmdSearch.ExecuteReader();

            Clipboard.SetText(SearchQuery);

            while(reader.Read())
            {
                dgw_Search.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
            }
            reader.Close();

            if(tb_SearchID.Text == "" &&tb_SearchLastName.Text =="" && tb_SearchName.Text == "" && tb_SearchSurName.Text == ""
                && cb_SearchGender.SelectedIndex == -1 && HiEdIndi4Search == false)
            {
                dgw_Search.Rows.Clear();
            }
        }

        private void btn_SearchClear_Click(object sender, EventArgs e)
        {
            tb_SearchID.Text = "";
            tb_SearchLastName.Text = "";
            tb_SearchName.Text = "";
            tb_SearchSurName.Text = "";
            cb_SearchGender.SelectedIndex = -1;
            rb_SearchHiEd.Checked = false;
            dtp_SearchBDay.Value = DateTime.Now.Date;
            HiEdIndi4Search = false;
            dgw_Search.Rows.Clear();
        }

        private void dgw_Search_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_SearchID.Text = dgw_Search.CurrentRow.Cells[0].Value.ToString();
            tb_SearchLastName.Text = dgw_Search.CurrentRow.Cells[1].Value.ToString();
            tb_SearchName.Text = dgw_Search.CurrentRow.Cells[2].Value.ToString();
            tb_SearchSurName.Text = dgw_Search.CurrentRow.Cells[3].Value.ToString();
            dtp_SearchBDay.Value = Convert.ToDateTime(dgw_Search.CurrentRow.Cells[4].Value);
            rb_SearchHiEd.Checked = Convert.ToBoolean(dgw_Search.CurrentRow.Cells[5].Value);
            cb_SearchGender.SelectedItem = dgw_Search.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_Back2MainSowRep_Click(object sender, EventArgs e)
        {
            pnl_ShowReports.Hide();
            pnl_MainMenu.Show();
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            pnl_MainMenu.Hide();
            pnl_ShowReports.Dock = DockStyle.Fill;
            pnl_ShowReports.Show();
        }

        private void btn_ShowDaysWorkedAndLeft_Click(object sender, EventArgs e)
        {
            dgw_ShowReports.Rows.Clear();
            dgw_ShowReports.Columns.Clear();

            dgw_ShowReports.Columns.Add("idWorker", "кодКадру");
            dgw_ShowReports.Columns.Add("idRegistr", "кодРеєстрації");
            dgw_ShowReports.Columns.Add("idPosition", "кодПосади");
            dgw_ShowReports.Columns.Add("lastName", "Прізвище");
            dgw_ShowReports.Columns.Add("Name", "Ім'я");
            dgw_ShowReports.Columns.Add("Surname", "поБатькові");
            dgw_ShowReports.Columns.Add("onPosition", "Відпрацьовано");
            dgw_ShowReports.Columns.Add("daysLeft", "Лишилось");

            string qShowDays = "exec daysworkedandleft";
            SqlCommand cmdShowDays = new SqlCommand(qShowDays, connect);
            SqlDataReader reader = cmdShowDays.ExecuteReader();

            while(reader.Read())
            {
                dgw_ShowReports.Rows.Add(reader[0], reader[1], reader[2], reader[3],
                                         reader[4], reader[5], reader[6], reader[7]);
            }
            reader.Close();
        }

        private void btn_PaymentOfWorkers_Click(object sender, EventArgs e)
        {
            dgw_ShowReports.Rows.Clear();
            dgw_ShowReports.Columns.Clear();

            dgw_ShowReports.Columns.Add("idRegistr", "кодРеєстрації");
            dgw_ShowReports.Columns.Add("lastName", "Прізвище");
            dgw_ShowReports.Columns.Add("Name", "Ім'я");
            dgw_ShowReports.Columns.Add("Surname", "поБатькові");
            dgw_ShowReports.Columns.Add("nameOfPosition", "назваПосади");
            dgw_ShowReports.Columns.Add("Payment", "Ставка");

            string qShowPayment = "exec paymentofworkers";
            SqlCommand cmdShowPayment = new SqlCommand(qShowPayment, connect);
            SqlDataReader reader = cmdShowPayment.ExecuteReader();

            while(reader.Read())
            {
                dgw_ShowReports.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4],
                                         reader[5]);
            }
            reader.Close();
        }

        private void btn_NumOfContracts_Click(object sender, EventArgs e)
        {
            dgw_ShowReports.Rows.Clear();
            dgw_ShowReports.Columns.Clear();

            dgw_ShowReports.Columns.Add("idRegistr", "кодРеєстрації");
            dgw_ShowReports.Columns.Add("lastName", "Прізвище");
            dgw_ShowReports.Columns.Add("Name", "Ім'я");
            dgw_ShowReports.Columns.Add("Surname", "поБатькові");
            dgw_ShowReports.Columns.Add("numOfContr", "укладеноКонтрактів");

            string qShowNumContr = "exec numberofContracts";
            SqlCommand cmdNumContr = new SqlCommand(qShowNumContr, connect);
            SqlDataReader reader = cmdNumContr.ExecuteReader();

            while(reader.Read())
            {
                dgw_ShowReports.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
            }
            reader.Close();
        }

        private void tb_WorkersFireWorkerID_TextChanged(object sender, EventArgs e)
        {
            dgw_WorkersFireWorker.Rows.Clear();

            string qWorkers4Fire = "select * from кадри where кодКадру like '" + tb_WorkersFireWorkerID.Text+ "%'";
            SqlCommand cmdShowWorkers4Fire = new SqlCommand(qWorkers4Fire, connect);
            SqlDataReader reader = cmdShowWorkers4Fire.ExecuteReader();

            while(reader.Read())
            {
                dgw_WorkersFireWorker.Rows.Add(reader[0], reader[1], reader[2], reader[3],
                                               reader[4], reader[5], reader[6]);
            }
            reader.Close();

            if(tb_WorkersFireWorkerID.Text == "")
            {
                dgw_WorkersFireWorker.Rows.Clear();
            }
        }

        private void dgw_WorkersFireWorker_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fireWorker = dgw_WorkersFireWorker.CurrentRow;
            lbl_Worker4FirePicked.Text = "Працівника вибрано";
            dgw_WorkersFireWorker.Rows.Clear();
            tb_WorkersFireWorkerID.Text = "";
        }

        private void btn_ClearChoice4Fire_Click(object sender, EventArgs e)
        {
            fireWorker = null;
            lbl_Worker4FirePicked.Text = "";
            tb_WorkersFireWorkerID.Text = "";
        }

        private void btn_FireWorker_Click(object sender, EventArgs e)
        {
            FireWorkerAccept fireWorkerForm = new FireWorkerAccept(this);
            fireWorkerForm.ShowDialog();

            if(fireWorkerIndi)
            {
                int size = 0;
                int i = 0;

                string qLookAllRegisters = "select * from реєстрація where кодкадру = " + fireWorker.Cells[0].Value;
                SqlCommand cmdLookAllRegisters = new SqlCommand(qLookAllRegisters, connect);
                SqlDataReader reader = cmdLookAllRegisters.ExecuteReader();

                while(reader.Read())
                {
                    size++;
                }
                reader.Close();
                reader = cmdLookAllRegisters.ExecuteReader();

                string[] qAddRegisters2Table = new string[size];

                while(reader.Read())
                {
                    qAddRegisters2Table[i] = "insert into РеєстраціїЗвільненихПрацівників(кодРеєстрації, кодКадру, кодПосади, Ставка, датаЗатвердження, датаЗакінченняКонтракту) " +
                        "values(" + reader[0] + ", " + reader[1] + ", " + reader[2] + ", " + reader[3] + ", '" + reader[4] + "', " +
                        "'" + reader[5] + "')";
                    i++;
                }

                reader.Close();

                for (int j = 0;j < qAddRegisters2Table.Length; j++)
                {
                    SqlCommand cmdIns = new SqlCommand(qAddRegisters2Table[j], connect);
                    cmdIns.ExecuteNonQuery();
                }

                string qDelWorkersRegistr = "use humanrecourcesdepartment delete from Реєстрація where кодКадру = " + fireWorker.Cells[0].Value;
                SqlCommand cmdDelRegistr = new SqlCommand(qDelWorkersRegistr, connect);
                cmdDelRegistr.ExecuteNonQuery();

                string qAddWorker2Archive = "use humanrecourcesdepartment insert into Архів ( кодкадру, прізвище, ім_я," +
                    " побатькові, датанародження, вищаосвіта, стать, датазвільнення)" +
                    " values( " + fireWorker.Cells[0].Value + ", '" + fireWorker.Cells[1].Value +
                    "', '" + fireWorker.Cells[2].Value + "', '" + fireWorker.Cells[3].Value +
                    "', '" + fireWorker.Cells[4].Value + "', '" + fireWorker.Cells[5].Value +
                    "', '" + fireWorker.Cells[6].Value + "', '" + DateTime.Now.Date + "')";

                SqlCommand cmdAdd2Arch = new SqlCommand(qAddWorker2Archive, connect);
                cmdAdd2Arch.ExecuteNonQuery();

                string qDelWorkerWorker = "use humanrecourcesdepartment delete from кадри where кодКадру = " + fireWorker.Cells[0].Value;
                SqlCommand cmdDelFromWorker = new SqlCommand(qDelWorkerWorker, connect);
                cmdDelFromWorker.ExecuteNonQuery();

                tb_WorkersFireWorkerID.Text = "";
                ts_StatusLabel.Text = "Працівника звільнено";
                btn_ClearChoice4Fire_Click(null, null);
            }
            else
            {
                btn_ClearChoice4Fire_Click(null, null);
            }
        }
    }
}
