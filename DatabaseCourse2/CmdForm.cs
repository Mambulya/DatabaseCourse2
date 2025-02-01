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

namespace DatabaseCourse2
{
    public partial class CmdForm : Form
    {
        public CmdForm()
        {
            InitializeComponent();
            CmddataGridView.AutoGenerateColumns = true;
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-LCHJBBK9;Initial Catalog=uni_serverm1;Integrated Security=True;");
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from production_normas;";





            try
            {
                conn.Open();
                var rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                CmddataGridView.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
