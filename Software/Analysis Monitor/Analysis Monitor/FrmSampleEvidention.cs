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
                txtPatientId.Text = FrmPatientSearch.SearchedPatient.IdPatient;

                if (SampleRepository.GetMaxID() != null)
                {
                    var pomocna = SampleRepository.GetMaxID().IdSample;
                    var druga = (pomocna + 1).ToString();
                    txtSampleId.Text = druga;
                }
                else
                {
                    DB.OpenConnection();
                    string sql = $"TRUNCATE TABLE Samples";
                    DB.ExecuteCommand(sql);
                    DB.CloseConnection();
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
                if (txtRecipient.Text.Length == 11 && txtSampleInfo.Text != "")
                {

                    if (sample == null)
                    {
                    SqlConnection db = new SqlConnection(@"Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=lpejakovi20_DB;Persist Security Info=True;User ID=lpejakovi20;Password=Q=}o18]E");
                    SqlCommand cmd = new SqlCommand("INSERT INTO Samples (IdPatient,TimeOfReceipt,IdEmployee,SampleType,SampleInfo) VALUES (@IdPatient, @TimeOfReceipt, @IdEmployee,@SampleType,@SampleInfo)", db);
                    db.Open();
                    cmd.Parameters.AddWithValue("@IdPatient", txtPatientId.Text);
                    cmd.Parameters.AddWithValue("@SampleType", cboSampleType.Text);
                    cmd.Parameters.AddWithValue("@SampleInfo", txtSampleInfo.Text);
                    cmd.Parameters.AddWithValue("@TimeOfReceipt", DateTime.Parse(txtTimeOfReceipt.Text));
                    cmd.Parameters.AddWithValue("@IdEmployee", txtRecipient.Text);
                    cmd.ExecuteNonQuery();
                    db.Close();
      
                        MessageBox.Show("Uzorak uspješno evidentiran!", "Uzorak evidentiran!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();                       
                        Close();
                        
                    }
                    else
                    {
                        DB.OpenConnection();
                        var id = txtRecipient.Text;
                        var id2 = cboSampleType.Text;
                        var id3 = txtSampleInfo.Text;
                        string sql = $"UPDATE Samples SET IdEmployee = '" + id + "', SampleType = '" + id2 + "', SampleInfo = '" + id3 + "' WHERE IdSample = '" + sample.IdSample + "'";
                        DB.ExecuteCommand(sql);
                        DB.CloseConnection();

                        MessageBox.Show("Uzorak uspješno izmijenjen!", "Uzorak izmijenjen!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        Hide();
                        Close();
                }
            }
                else
                {
                    if (txtRecipient.Text.Length != 11)
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
