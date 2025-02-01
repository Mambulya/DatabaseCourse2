using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseCourse2.DataSet2TableAdapters;

namespace DatabaseCourse2
{
    public partial class Form1 : Form
    {
        DataSet2 ds = new DataSet2();
        production_normasTableAdapter proTA = new production_normasTableAdapter();
        worker_experienceTableAdapter weTA = new worker_experienceTableAdapter();
        worker_infoTableAdapter wiTA = new worker_infoTableAdapter();

        public Form1()
        {
            InitializeComponent();
            productionnormasBindingSource.DataSource = this.dataSet2.production_normas;
            workerexperienceBindingSource.DataSource = this.dataSet2.worker_experience;
            workerinfoBindingSource.DataSource = this.dataSet2.worker_info;
        }

        private void FillAll()
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.worker_info". При необходимости она может быть перемещена или удалена.
            this.worker_infoTableAdapter.Fill(this.dataSet2.worker_info);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.worker_experience". При необходимости она может быть перемещена или удалена.
            this.worker_experienceTableAdapter.Fill(this.dataSet2.worker_experience);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.production_normas". При необходимости она может быть перемещена или удалена.
            this.production_normasTableAdapter.Fill(this.dataSet2.production_normas);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        
            FillAll();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                proTA.Update(this.dataSet2.production_normas);
                weTA.Update(this.dataSet2.worker_experience);
                wiTA.Update(this.dataSet2.worker_info);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Changes saved!");


        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillAll();
        }

        private void альтернативнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltForm f = new AltForm();
            f.ShowDialog();
        }

        private void sqlProcedureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CmdForm cmd = new CmdForm();    
            cmd.ShowDialog();
        }

        private void ResLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            int quilification = 0;
            try
            {
                quilification = int.Parse(textBoxQuilification.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не верный формат ввода!");
            }


            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-LCHJBBK9;Initial Catalog=uni_serverm1;Integrated Security=True;");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "get_total_time";
            cmd.Parameters.AddWithValue("@q", quilification);

            // выходной параметр
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@total_time";
            param.SqlDbType = SqlDbType.Decimal;
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            try
            {
                conn.Open();
                int resv = cmd.ExecuteNonQuery();
                conn.Close();

                lblResult.Text = $"Суммарное время на изготовление:  {cmd.Parameters["@total_time"].Value}";

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
