using System;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class HireWorkerAccept : Form
    {
        int codeWorker;
        int codePosition;
        MainForm mf = null;
        SqlConnection connect;
        
        public HireWorkerAccept()
        {
            InitializeComponent();
            
        }

        public HireWorkerAccept(int codeWorker, int codePosition, SqlConnection connect, MainForm mf)
        {
            InitializeComponent();
            this.codeWorker = codeWorker;
            this.codePosition = codePosition;
            this.connect = connect;
            this.mf = mf;
            tb_HireWorkerCodeWorker.Text = codeWorker.ToString();
            tb_HireWorkerCodePosition.Text = codePosition.ToString();
        }

        private void btn_HireWorker_Click(object sender, EventArgs e)
        {
            string qCheckHiEdWorker = "exec hiedinworker " + codeWorker;
            SqlCommand cmdCheckHiEdWorker = new SqlCommand(qCheckHiEdWorker, connect);
            SqlDataReader reader = cmdCheckHiEdWorker.ExecuteReader();
            bool hiEdIndiWorker = false;

            while (reader.Read())
            {
                hiEdIndiWorker = Convert.ToBoolean(reader[0]);
            }
            
            reader.Close();

            string qCheckHiEd = "exec hiedrequires " + codePosition;
            SqlCommand cmdCheckHiEd = new SqlCommand(qCheckHiEd, connect);
            SqlDataReader reader2 = cmdCheckHiEd.ExecuteReader();
            bool hiEdPos = false;
            while(reader2.Read())
            {
                hiEdPos = Convert.ToBoolean(reader2[0]);
            }
            reader2.Close();

            try
            {

                if (hiEdPos == true && hiEdIndiWorker == false)
                {
                    MessageBox.Show("На цю посаду неможливо найняти працівника без вищої освіти");
                    throw new InvalidOperationException();
                }
                if (dtp_HireWorkerEndContr.Value.Date <= dtp_HireWorkerStartContract.Value.Date)
                {
                    MessageBox.Show("Некоректна дата");
                    throw new InvalidOperationException();
                }
                if(cb_PaymentIndex.SelectedIndex == -1)
                {
                    MessageBox.Show("Не вибрана ставка");
                    throw new InvalidOperationException();
                }

                string qRegisterWorker = "exec registernewworker " + codeWorker + ", " + codePosition +
                    ", " + Convert.ToSingle(cb_PaymentIndex.SelectedItem) + ", '"
                    + dtp_HireWorkerStartContract.Value.Date + "', '" + dtp_HireWorkerEndContr.Value.Date + "'";
                SqlCommand cmdRegisterWorker = new SqlCommand(qRegisterWorker, connect);
                cmdRegisterWorker.ExecuteNonQuery();
                mf.indicatorHireWorker = true;

            }
            catch (InvalidOperationException)
            {
                this.Close();
            }
            finally
            {
                this.Close();
            }
        }
    }
}
