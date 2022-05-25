using DBLayer;
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
using System.Data.Sql;
using System.Data.SqlClient;

namespace Analysis_Monitor
{
    public partial class FrmPatientAddition : Form
    {
        public FrmPatientAddition()
        {
            InitializeComponent();
            txtIdPatient.Text = FrmPatientSearch.NewPatient;

        }

        private void FrmPatientAddition_Load(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPatientFirstName.Text.Length > 30 || txtPatientFirstName.Text=="")
            {
                txtPatientFirstName.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffdddd");
            }
            else if (txtPatientLastName.Text.Length > 30 || txtPatientLastName.Text == "")
            {
                txtPatientLastName.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffdddd");
            }
            else if(txtBirthDate.Text==""){
                txtBirthDate.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffdddd");
            }
            else if (txtResidentialAddress.Text=="" || txtResidentialAddress.Text.Length > 50)
            {
                txtResidentialAddress.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffdddd");
            }
            else if (txtPhoneNum.Text=="" || txtPhoneNum.Text.Length > 15)
            {
                txtPhoneNum.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffdddd");
            }
            else if (txtEmail.Text=="" || txtEmail.Text.Length > 50)
            {
                txtEmail.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffdddd");
            }
            else
            {

                PatientRepository.InsertPatient(txtIdPatient.Text, txtPatientFirstName.Text, txtPatientLastName.Text, txtPhoneNum.Text, txtEmail.Text, DateTime.Parse(txtBirthDate.Text), txtResidentialAddress.Text);

                MessageBox.Show("Pacijent uspješno unesen!", "Pacijent unesen!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                FrmSampleEvidention frmSampleEvidention = new FrmSampleEvidention(null);
                frmSampleEvidention.ShowDialog();
                Close();
            }
        
        }
    }
}
