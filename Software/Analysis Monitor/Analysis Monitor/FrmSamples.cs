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
    public partial class FrmSamples : Form
    {
        public FrmSamples()
        {
            InitializeComponent();
        }

        public void ShowSamples()
        {
            var samples = SampleRepository.GetSamples();
            dgvSamples.DataSource = samples;

        }

        private void FrmSamples_Load(object sender, EventArgs e)
        {
            ShowSamples();
        }

        private void btnAddSample_Click(object sender, EventArgs e)
        {
            FrmPatientSearch frmPatientSearch = new FrmPatientSearch();
            frmPatientSearch.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Jeste li sigurni da želite obrisati odabrani uzorak?", "Brisanje uzorka", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Sample selectedSample = dgvSamples.CurrentRow.DataBoundItem as Sample;
                var id = selectedSample.IdSample.ToString();
                SqlConnection DB = new SqlConnection(@"Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=lpejakovi20_DB;Persist Security Info=True;User ID=lpejakovi20;Password=Q=}o18]E");
                SqlCommand cmd = new SqlCommand("DELETE FROM Samples WHERE IdSample = '" + id + "'", DB);
                DB.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DB.Close();
                ShowSamples();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Sample selectedSample = dgvSamples.CurrentRow.DataBoundItem as Sample;
            FrmSampleEvidention frmSampleEvidention = new FrmSampleEvidention(selectedSample);
            frmSampleEvidention.ShowDialog();
            ShowSamples();
        }
    }
}
