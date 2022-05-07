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
using System.Runtime;

namespace WindowsFormsApp6
{
    public partial class connexion : Form
    {
        MySqlCommand sqlCommand;
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
        /*Variable*/
        int ID_user = -1;
        private string namerole;
        int ID_perso;


        private void button1_Click(object sender, EventArgs e)
        {
            /*On vérifie dans la bd si il y a un Nom et un mdp qui correspond*/
            MySqlDataReader lecteur;
            sqlCommand.CommandText = "SELECT Nom , Mot_de_passe FROM ppe.personnel where Binary Nom ='" + textBoxID.Text + "' AND Binary Mot_de_passe = '" + textBoxMDP.Text + "';";
            lecteur = sqlCommand.ExecuteReader();
            /*Si le mdp est le meme que le nom alors on demande a changer de mot de passe */
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
                    string datedujour = DateTime.Now.ToString();
                    string datefin = null;
                    string role = null;
                    string source = textBoxMDP.Text;
                    string mdp = Libe.Hash(source);
                    /*Si il y a une correspondance avec le mot de passe et le nom de compte dans la bd on récupère l'id du compte*/
                    sqlCommand.CommandText = "SELECT Nom , Mot_de_passe, ID_personnel FROM ppe.personnel where Nom ='" + textBoxID.Text + "' && Mot_de_passe = '" + mdp + "';";
                    lecteur = sqlCommand.ExecuteReader();
                    if (lecteur.HasRows)
                    {
                        while (lecteur.Read())
                        {
                            /*recupération de l'id utilisateur*/
                            ID_perso = lecteur.GetInt32(2);
                        }
                        ID_user = ID_perso;
                        lecteur.Close();

                    }
                    else
                    {
                        /*SI le mot de passe et le nom de correspondent a rien alors on affitche : Mot de passe ou identifiant incorrect */
                        MessageBox.Show("Mot de passe ou identifiant incorrect");
                        lecteur.Close();
                    }
                        /*On verifie si le compte a une date de fin si elle est null on s'identifie */
                    sqlCommand.CommandText = "select * from personnel natural join attribuer where personnel.ID_personnel = " + ID_perso + "&& isnull(date_fin) ;";
                    lecteur = sqlCommand.ExecuteReader();
                    if (lecteur.HasRows)
                    {
                        while (lecteur.Read())
                        {
                            /*recupération du role de l'utilisateur*/
                            role = lecteur.GetString(4);
                        }
                        lecteur.Close();
                        MessageBox.Show("Bienvenue " + textBoxID.Text + " vous êtes " + role + datefin);
                        namerole = role;
                        this.Close();
                    }
                    else
                    {
                        /*Si donc la date de fin n'est pas nul c'est qu'elle existe donc on récupère la date de fin*/
                        lecteur.Close();
                        sqlCommand.CommandText = "select * from personnel natural join attribuer where personnel.ID_personnel = " + ID_perso + ";";
                        lecteur = sqlCommand.ExecuteReader();
                        if (lecteur.HasRows)
                        {
                            while (lecteur.Read())
                            {
                                /*recupération du role de l'utilisateur et de la date de fin*/
                                role = lecteur.GetString(4);
                                datefin = lecteur.GetString(6);
                            }
                            lecteur.Close();
                            var parsedatefin = DateTime.Parse(datefin);
                            var parsedatejour = DateTime.Parse(datedujour);
                            /*permet de comparer deux date et renvoie >0 si la date n'est pas dépasser 
                             donc on vérifie si oui ou non on peut se connecter au compte*/
                            int comparedate = DateTime.Compare(parsedatefin, parsedatejour);
                            if (comparedate > 0)
                            {
                                MessageBox.Show("Bienvenue " + textBoxID.Text + " vous êtes " + role + " jusqu'au : "+ datefin);
                                namerole = role;
                                this.Close();
                                lecteur.Close();
                            }
                            else
                            {
                                MessageBox.Show("Votre compte est suspendu depuis le : " + parsedatefin);
                                lecteur.Close();
                                ID_user = -1;
                            }

                        }
                        else
                        {
                            lecteur.Close();
                        }
                    }
                }
                catch
                {
                    lecteur.Close();
                    ID_user = -1;
                }
            }
        }


        public int getID()
        {
            return ID_user;
        }

        public string getRole()
        {
            return namerole;
        }

        private void connexion_Load(object sender, EventArgs e)
        {

        }




    }
}
