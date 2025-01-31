using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseCourse2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.worker_info". При необходимости она может быть перемещена или удалена.
            this.worker_infoTableAdapter.Fill(this.dataSet2.worker_info);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.worker_experience". При необходимости она может быть перемещена или удалена.
            this.worker_experienceTableAdapter.Fill(this.dataSet2.worker_experience);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.production_normas". При необходимости она может быть перемещена или удалена.
            this.production_normasTableAdapter.Fill(this.dataSet2.production_normas);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
