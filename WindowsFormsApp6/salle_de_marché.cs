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
using libe;

namespace WindowsFormsApp6
{
    public partial class salle_de_marché : Form
    {

        MySqlCommand sqlCommand;
        int ID_User;
        public salle_de_marché(int IDP,MySqlCommand sqlC)
        {
            InitializeComponent();
            sqlCommand = sqlC;
            ID_User = IDP;
            lblCompte.Text = ID_User.ToString();
            if (lblCompte.Text != "")
            {
                lblCompte.BackColor = Color.LightBlue;
                lblEtatBd.BackColor = Color.Green;
            }
        }
        private void personnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connexion connexion = new connexion();
            connexion.ShowDialog();
            connexion.Dispose();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tooldeco_Click(object sender, EventArgs e)
        {
        
        }

        private void ajouterUnePersonneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajout_personnel form2 = new ajout_personnel(sqlCommand);
            form2.ShowDialog();
            form2.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void visualiserLePersonnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
            form4.Dispose();
        }

        private void gérerLesBudgetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            budgets budgets = new budgets();
            budgets.ShowDialog();
            budgets.Dispose();
        }

        private void testFicherPersoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fiche_personnel fiche_personnel = new Fiche_personnel();
            fiche_personnel.ShowDialog();
            fiche_personnel.Dispose();
        }

        private void administrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
