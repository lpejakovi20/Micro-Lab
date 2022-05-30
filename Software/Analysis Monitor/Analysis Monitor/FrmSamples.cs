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
    public partial class FrmSamples : Form
    {
        public FrmSamples()
        {
            InitializeComponent();
        }

        public void ShowSamples(string id)
        {
            if (id != null)
            {
                var samples = SampleRepository.GetSamples(id);
                dgvSamples.DataSource = samples;
            }
            else
            {
                var samples = SampleRepository.GetSamples(null);
                dgvSamples.DataSource = samples;
            }
        }

        private void FrmSamples_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("lpejakovi20_DB", "lpejakovi20", "Q=}o18]E");
            ShowSamples(null);
        }

        private void btnAddSample_Click(object sender, EventArgs e)
        {
            FrmPatientSearch frmPatientSearch = new FrmPatientSearch();
            frmPatientSearch.ShowDialog();
            ShowSamples(null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Jeste li sigurni da želite obrisati odabrani uzorak?", "Brisanje uzorka", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Sample selectedSample = dgvSamples.CurrentRow.DataBoundItem as Sample;
                var id = selectedSample.IdSample;
                SampleRepository.DeleteSample(id);
                
                ShowSamples(null);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Sample selectedSample = dgvSamples.CurrentRow.DataBoundItem as Sample;
            FrmSampleEvidention frmSampleEvidention = new FrmSampleEvidention(selectedSample);
            frmSampleEvidention.ShowDialog();
            if (txtSearchIdPatient.Text == "" || PatientRepository.GetPatient(txtSearchIdPatient.Text) == null)
            {
                ShowSamples(null);
            }
            else
            {
                ShowSamples(txtSearchIdPatient.Text);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearchIdPatient.Text == "" || PatientRepository.GetPatient(txtSearchIdPatient.Text) == null)
            {
                txtSearchIdPatient.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffdddd");
            }
            else
            {
                ShowSamples(txtSearchIdPatient.Text);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchIdPatient.Text = "";
            txtSearchIdPatient.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
            ShowSamples(null);
        }
    }
}
