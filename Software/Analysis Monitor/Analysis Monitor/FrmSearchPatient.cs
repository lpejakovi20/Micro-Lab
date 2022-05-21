using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analysis_Monitor
{
    public partial class FrmPatientSearch : Form
    {
        string oib = "01234567890";

        public FrmPatientSearch()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffdddd");
            }
            else if(txtID.Text == oib)
            {
                FrmSampleEvidention frmSampleEvidention = new FrmSampleEvidention();
                Hide();
                frmSampleEvidention.ShowDialog();
                Close();
            }
        }
    }
}
