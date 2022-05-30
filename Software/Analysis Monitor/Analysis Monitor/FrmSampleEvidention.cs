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

            var IdEmployee = new[] { "95423216047", "26197467369", "71476987055", "30924526004", "68247423134" };
            cboIdEmployee.DataSource = IdEmployee;
            cboIdEmployee.DropDownStyle = ComboBoxStyle.DropDownList;

            if (selectedSample == null)
            {
                if (FrmPatientSearch.NewPatient == null) txtPatientId.Text = FrmPatientSearch.SearchedPatient.IdPatient;
                else txtPatientId.Text = FrmPatientSearch.NewPatient;
                
                txtTimeOfReceipt.Text = DateTime.Now.ToString();
            }
            else
            {
                Sample newSample = SampleRepository.GetSample(selectedSample.IdSample);
                txtPatientId.Text = newSample.IdPatient.ToString();
                txtTimeOfReceipt.Text = newSample.TimeOfReceipt.ToString();
                cboIdEmployee.Text = newSample.IdEmployee.ToString();
                cboSampleType.Text = newSample.SampleType.ToString();
                txtSampleInfo.Text = newSample.SampleInfo.ToString();
            }
           
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
                if (txtSampleInfo.Text != "")
                {

                    if (sample == null)
                    {
                        SampleRepository.InsertSample(txtPatientId.Text, DateTime.Parse(txtTimeOfReceipt.Text), cboIdEmployee.Text, cboSampleType.Text, txtSampleInfo.Text);
      
                        MessageBox.Show("Uzorak uspješno evidentiran!", "Uzorak evidentiran!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();                       
                        Close();
                        
                    }
                    else
                    {
                        SampleRepository.UpdateSample(cboIdEmployee.Text, cboSampleType.Text, txtSampleInfo.Text, sample.IdSample);
                        
                        MessageBox.Show("Uzorak uspješno izmijenjen!", "Uzorak izmijenjen!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        Hide();
                        Close();
                    }
                }
                else
                { 
                        txtSampleInfo.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffdddd");
                    
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
