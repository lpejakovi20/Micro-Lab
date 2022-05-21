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
           

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection DB = new SqlConnection(@"Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=lpejakovi20_DB;Persist Security Info=True;User ID=lpejakovi20;Password=Q=}o18]E");
            DB.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Samples (IdPatient,TimeOfReceipt,SampleType,SampleInfo) VALUES ('01234567890',GETDATE(),@SampleType,@SampleInfo)", DB);
            cmd.Parameters.AddWithValue("@SampleType", cboSampleType.Text);
            cmd.Parameters.AddWithValue("@SampleInfo", txtSampleInfo.Text);
            cmd.ExecuteNonQuery();
            DB.Close();
        }

        private void FrmSampleEvidention_Load(object sender, EventArgs e)
        {

        }
    }
}
