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
        public Cours(MySqlCommand sqlC)
        {
            InitializeComponent();
            sqlCommand = sqlC;
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("Select * from libelles", sqlCommand.Connection);
            DataTable dt1 = new DataTable();
            sqlDa.Fill(dt1);
            Cours_gridview.DataSource = dt1;
            Cours_gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Cours_gridview.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Quitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void Cours_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cours_Load(object sender, EventArgs e)
        {

        }
    }
}
