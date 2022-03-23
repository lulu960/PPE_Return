using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using libe;

namespace WindowsFormsApp6
{
    public partial class connexion : Form
    {
        MySqlCommand sqlCommand;
        string dataBaseName;
        public connexion(MySqlCommand sqlC)
        {
            InitializeComponent();
            sqlCommand = sqlC;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataReader lecteur;
            sqlCommand.CommandText = "SELECT Nom , Mot_de_passe FROM ppe.personnel where Nom ='"+textBoxID.Text+"' AND Mot_de_passe = '"+textBoxMDP.Text+"';";
            lecteur = sqlCommand.ExecuteReader();
            if (lecteur.HasRows)
            {
                ChangementMDP ChangementMDP = new ChangementMDP(textBoxID.Text, sqlCommand);
                lecteur.Close();
                ChangementMDP.ShowDialog();
                ChangementMDP.Dispose();
            }
            else
            {
                lecteur.Close();
                try
                {
                    string source = textBoxMDP.Text;


                    sqlCommand.CommandText = "SELECT Nom , Mot_de_passe FROM ppe.personnel where Nom ='" + textBoxID.Text + "' && Mot_de_passe = '" + Libe.Hash(source) + "';";
                    lecteur = sqlCommand.ExecuteReader();
                    if (lecteur.HasRows)
                    {
                        MessageBox.Show("Bienvenue " + textBoxID.Text + ".");
                        lecteur.Close();
                        salle_de_marché salle_de_marché = new salle_de_marché();
                        salle_de_marché.ShowDialog();
                        salle_de_marché.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Mot de passe ou identifiant incorrect");
                        lecteur.Close();
                    }
                    
                    
                }
                catch
                {
                    lecteur.Close();
                }
            }
        }

        private void connexion_Load(object sender, EventArgs e)
        {
            
        }

        private void connexion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
