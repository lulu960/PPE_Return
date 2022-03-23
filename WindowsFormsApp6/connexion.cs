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
                    int ID_perso = -1;
                    string role = null;

                    sqlCommand.CommandText = "select * from personnel natural join attribuer where personnel.ID_personnel = " + ID_perso + ";";
                    lecteur = sqlCommand.ExecuteReader();
                    if (lecteur.HasRows)
                    {
                        while (lecteur.Read())
                        {
                            /* recupération du role de l'utilisateur*/
                            role = lecteur.GetString(4);
                        }
                        MessageBox.Show("Bienvenue " + textBoxID.Text + " et l'ID est" + ID_perso + "et votre role est " + role + ".");
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
    class Compte
    {
        private int _id_perso;
        private string _role;
        private string _nom;

        public int ID_Perso
        {
            get => _id_perso;
            set => _id_perso = value;
        }
        public string Role
        {
            get => _role;
            set => _role = value;
        }

    }
}
