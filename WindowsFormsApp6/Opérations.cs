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
    public partial class Opérations : Form
    {
        MySqlCommand sqlCommand;
        MySqlDataReader lecteur;
        public Opérations(MySqlCommand sqlC)
        {
            /*datagridview opération*/
            InitializeComponent();
            sqlCommand = sqlC;  
            sqlCommand.CommandText = "SELECT * FROM `libelles` ";
            lecteur = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(lecteur);
            dtgOperation.DataSource = dt;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Opérations_Load(object sender, EventArgs e)
        {

        }
    }
}
