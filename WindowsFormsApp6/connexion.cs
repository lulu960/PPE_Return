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
using Lib;
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
            sqlCommand.CommandText = "SELECT Nom , Mot_de_passe FROM ppe.personnel where Binary Nom ='" + textBoxID.Text+ "' AND Binary Mot_de_passe = '" + textBoxMDP.Text+"';";
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
                    int ID_perso = 0;
                    string source = textBoxMDP.Text;
                    string mdp = Libe.Hash(source);
                        sqlCommand.CommandText = "SELECT Nom , Mot_de_passe, ID_personnel FROM ppe.personnel where Nom ='" + textBoxID.Text + "' && Mot_de_passe = '" + mdp + "';";
                        lecteur = sqlCommand.ExecuteReader();
                        if (lecteur.HasRows)
                        {
                            while (lecteur.Read())
                                {
                                    /*recupération de l'id utilisateur*/
                                       ID_perso = lecteur.GetInt32(2);
                                }
                            MessageBox.Show("Bienvenue " + textBoxID.Text +" et l'ID est" + ID_perso + ".");                            
                            this.Close();
                            lecteur.Close();
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
    }
}
