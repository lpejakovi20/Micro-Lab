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
        public FrmSampleEvidention()
        {
            InitializeComponent();

            var SampleType =
               new[] { "Urin", "Krv" };

            cboSampleType.DataSource = SampleType;
            cboSampleType.DropDownStyle = ComboBoxStyle.DropDownList;

            txtPatientId.Text = FrmPatientSearch.SearchedPatient.IdPatient;

            var pomocna = SampleRepository.GetMaxID().IdSample;
            var druga = (pomocna + 1).ToString();
            txtSampleId.Text = druga;

            txtTimeOfReceipt.Text = DateTime.Now.ToString();
           

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if(txtRecipient.Text != "" && txtSampleInfo.Text != "")
            {
                SqlConnection DB = new SqlConnection(@"Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=lpejakovi20_DB;Persist Security Info=True;User ID=lpejakovi20;Password=Q=}o18]E");
                DB.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Samples (IdPatient,TimeOfReceipt,SampleType,SampleInfo) VALUES (@IdPatient,@TimeOfReceipt,@SampleType,@SampleInfo)", DB);
                cmd.Parameters.AddWithValue("@IdPatient", txtPatientId.Text);
                cmd.Parameters.AddWithValue("@SampleType", cboSampleType.Text);
                cmd.Parameters.AddWithValue("@SampleInfo", txtSampleInfo.Text);
                cmd.Parameters.AddWithValue("@TimeOfReceipt", DateTime.Parse(txtTimeOfReceipt.Text));
                cmd.ExecuteNonQuery();
                DB.Close();

                MessageBox.Show("Uzorak uspješno evidentiran!", "Uzorak evidentiran!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmSamples frmSamples = new FrmSamples();
                Hide();
                frmSamples.ShowDialog();
                Close();
            }
            else
            {
                if(txtRecipient.Text == "")
                {
                    txtRecipient.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffdddd");
                }
                else if(txtSampleInfo.Text == "")
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
            FrmPatientSearch frmPatientSearch = new FrmPatientSearch();
            Hide();
            frmPatientSearch.ShowDialog();
            Close();
        }
    }
}
