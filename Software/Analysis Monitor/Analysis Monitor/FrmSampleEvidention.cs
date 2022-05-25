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
    public partial class FrmSampleEvidention : Form
    {
        private Sample sample;
        public FrmSampleEvidention(Sample selectedSample)
        {
            InitializeComponent();

            sample = selectedSample;

            var SampleType = new[] { "Urin", "Krv" };
            cboSampleType.DataSource = SampleType;
            cboSampleType.DropDownStyle = ComboBoxStyle.DropDownList;

            if (selectedSample == null)
            {
                if (FrmPatientSearch.NewPatient == null) txtPatientId.Text = FrmPatientSearch.SearchedPatient.IdPatient;
                else txtPatientId.Text = FrmPatientSearch.NewPatient;
                
                if (SampleRepository.GetMaxID() != null)
                {
                    var pomocna = SampleRepository.GetMaxID().IdSample;
                    var druga = (pomocna + 1).ToString();
                    txtSampleId.Text = druga;
                }
                else
                {
                    SampleRepository.RefreshTable();
                    txtSampleId.Text = "1";
                }

                txtTimeOfReceipt.Text = DateTime.Now.ToString();
            }
            else
            {
                Sample newSample = SampleRepository.GetSample(selectedSample.IdSample);
                txtSampleId.Text= newSample.IdSample.ToString();
                txtPatientId.Text = newSample.IdPatient.ToString();
                txtTimeOfReceipt.Text = newSample.TimeOfReceipt.ToString();
                txtRecipient.Text = newSample.IdEmployee.ToString();
                cboSampleType.Text = newSample.SampleType.ToString();
                txtSampleInfo.Text = newSample.SampleInfo.ToString();
            }
           
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
                if (txtRecipient.Text.Length == 11 && txtSampleInfo.Text != "" && txtRecipient.Text.All(char.IsDigit))
                {

                    if (sample == null)
                    {
                        SampleRepository.InsertSample(txtPatientId.Text, DateTime.Parse(txtTimeOfReceipt.Text), txtRecipient.Text, cboSampleType.Text, txtSampleInfo.Text);
      
                        MessageBox.Show("Uzorak uspješno evidentiran!", "Uzorak evidentiran!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();                       
                        Close();
                        
                    }
                    else
                    {
                        SampleRepository.UpdateSample(txtRecipient.Text, cboSampleType.Text, txtSampleInfo.Text, sample.IdSample);
                        
                        MessageBox.Show("Uzorak uspješno izmijenjen!", "Uzorak izmijenjen!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        Hide();
                        Close();
                }
            }
                else
                {
                    if (txtRecipient.Text.Length != 11 || !txtRecipient.Text.All(char.IsDigit))
                    {
                        txtRecipient.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffdddd");
                    }
                    else if (txtSampleInfo.Text == "")
                    {
                        txtSampleInfo.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffdddd");
                    }
                }
            
        }
        
        private void FrmSampleEvidention_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }
    }
}
