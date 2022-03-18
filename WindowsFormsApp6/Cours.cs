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
<<<<<<< HEAD
=======
        MySqlConnection connect;
>>>>>>> e7c87de541f073e882e3446375944d7353a57412
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
<<<<<<< HEAD
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("Select * from libelles", sqlCommand.Connection);
=======
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("Select * from libelles",sqlCommand.Connection);
>>>>>>> e7c87de541f073e882e3446375944d7353a57412
            DataTable dt1 = new DataTable();
            sqlDa.Fill(dt1);

            Cours_gridview.DataSource = dt1;
        }
    }
}
