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
    public partial class Form4 : Form
    {
        MySqlCommand sqlCommand;
        MySqlCommand sqlC;
        string ID_fp;
        public Form4(MySqlCommand sqlC)
        {
            InitializeComponent();
            dataGridView1.ClearSelection();
            sqlCommand = sqlC;
            sqlC = Refresh(sqlC);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
        }
        MySqlCommand Refresh(MySqlCommand sqlC)
        {
            string commande = "select ID_personnel,Nom,Prenom,ID_categorie,date_debut,date_fin from personnel natural join attribuer";
            MySqlDataAdapter sqlDa = new MySqlDataAdapter(commande, sqlCommand.Connection);
            DataTable dt1 = new DataTable();
            sqlDa.Fill(dt1);
            dataGridView1.DataSource = dt1;
            return (sqlC);
        }


        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var ID_data = dataGridView1.SelectedCells[0].Value;
            string ID_ficheperso = Convert.ToString(ID_data);
            ID_fp = ID_ficheperso;
            Fiche_personnel fiche_personnel = new Fiche_personnel(sqlCommand, ID_fp);
            fiche_personnel.ShowDialog();
            this.Refresh(sqlC);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string GetID()
        {
            return ID_fp;
        }

        private void Form4_Load(object sender, EventArgs e)
        {


        }

    }
}



