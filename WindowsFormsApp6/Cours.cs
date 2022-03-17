using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp6
{
    public partial class Cours : Form
    {
        MySqlCommand sqlCommand;
        MySqlConnection connect;
        public Cours(MySqlCommand sqlC)
        {
            InitializeComponent();
            sqlCommand = sqlC;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("Select * from libelles",sqlCommand.Connection);
            DataTable dt1 = new DataTable();
            sqlDa.Fill(dt1);

            Cours_gridview.DataSource = dt1;
        }
    }
}
