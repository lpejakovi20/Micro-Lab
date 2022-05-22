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
    public partial class FrmSamples : Form
    {
        public FrmSamples()
        {
            InitializeComponent();
        }

        private void ShowSamples()
        {
            var students = SampleRepository.GetSamples();
            dgvSamples.DataSource = students;

        }

        private void FrmSamples_Load(object sender, EventArgs e)
        {
            ShowSamples();
        }
    }
}
