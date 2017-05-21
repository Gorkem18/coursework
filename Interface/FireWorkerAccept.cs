using System;
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
    public partial class FireWorkerAccept : Form
    {
        MainForm mf = null;

        public FireWorkerAccept()
        {
            InitializeComponent();
        }
        
        public FireWorkerAccept (MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            mf.fireWorkerIndi = true;
            this.Close();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            mf.fireWorkerIndi = false;
            this.Close();
        }
    }
}
