using Analysis_Monitor.Models;
using Analysis_Monitor.Repositories;
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
        public static Patient SearchedPatient { get; set; }
        public static string NewPatient { get; set; }

        public FrmPatientSearch()
        {
            InitializeComponent();

            NewPatient = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchedPatient = PatientRepository.GetPatient(txtID.Text);

            if (SearchedPatient!=null)
            {
                FrmSampleEvidention frmSampleEvidention = new FrmSampleEvidention(null);
                this.Hide();
                frmSampleEvidention.ShowDialog();
                this.Close();
            }
            else if (txtID.Text.Length!=11 || !txtID.Text.All(char.IsDigit))
            {
                txtID.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffdddd");
            }
            else
            {
                NewPatient = txtID.Text;
                DialogResult dialogResult = MessageBox.Show("Pacijent ne postoji, želite li ga unijeti u sustav?", "Nepostojeći pacijent!", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    Hide();
                    FrmPatientAddition frmPatientAddition = new FrmPatientAddition();
                    frmPatientAddition.ShowDialog();
                    Close();
                }
            }
        }
    }
}
