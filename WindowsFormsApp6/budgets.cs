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
    public partial class budgets : Form
    {
        MySqlCommand sqlCommand;
        MySqlCommand sqlC;
        string ID_compte;
        string Budget;
        public budgets(MySqlCommand sqlC)
        {
            InitializeComponent();
            sqlCommand = sqlC;
            sqlC = Refresh(sqlC);
            dtgbudget.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgbudget.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgbudget.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgbudget.AllowUserToAddRows = false;
            dtgbudget.AllowUserToDeleteRows = false;
            dtgbudget.ReadOnly = true;
        }

        MySqlCommand Refresh(MySqlCommand sqlC)
        {
            MySqlDataAdapter sqlDa = new MySqlDataAdapter("SELECT personnel.ID_personnel, personnel.Nom,personnel.Prenom,budget.Budget, budget.ID_budget FROM ppe.budget natural join personnel", sqlCommand.Connection);
            DataTable dt1 = new DataTable();
            sqlDa.Fill(dt1);
            dtgbudget.DataSource = dt1;
            return (sqlC);
        }
        private void budgets_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Budget = textBox2.Text;
            string message = "Etre vous sur d'attribuer "+ Budget +" € au compte "+ ID_compte + " ?";
            string titre = "Attribution de budget";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, titre, buttons);
            if (result == DialogResult.Yes)
            sqlCommand.CommandText = "UPDATE `ppe`.`budget` SET `Budget` = "+ Budget + " WHERE (`ID_budget` = "+ ID_compte + ")";
            sqlCommand.ExecuteNonQuery();
            this.Refresh(sqlC);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dtgbudget_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgbudget.Rows[e.RowIndex].Cells[3].Value != null)
            {
                 Budget = dtgbudget.Rows[e.RowIndex].Cells[3].Value.ToString();
                 ID_compte = dtgbudget.Rows[e.RowIndex].Cells[4].Value.ToString();
                 textBox2.Text = Budget;
            }
        }
    }
}
