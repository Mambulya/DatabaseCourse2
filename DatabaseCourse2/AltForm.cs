using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseCourse2.DataSet2TableAdapters;

namespace DatabaseCourse2
{
    public partial class AltForm : Form
    {
        DataSet2 ds = new DataSet2();
        production_normasTableAdapter proTA = new production_normasTableAdapter();
        worker_experienceTableAdapter weTA = new worker_experienceTableAdapter();
        worker_infoTableAdapter wiTA = new worker_infoTableAdapter();

        public AltForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProductionN_Click(object sender, EventArgs e)
        {
            proTA.Fill(ds.production_normas);
            MaindataGridView.DataSource = ds.production_normas;
            this.Text = "Нормы производства";    
        }

        private void btnWorkerExp_Click(object sender, EventArgs e)
        {

        }

        private void btnWorkerInf_Click(object sender, EventArgs e)
        {

        }
    }
}
