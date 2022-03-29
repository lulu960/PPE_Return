﻿using System;
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
            /*On verifie si le mdp et le nom de compte est égal ou non si oui on le modifie*/
            MySqlDataReader lecteur;
            sqlCommand.CommandText = "SELECT Nom , Mot_de_passe FROM ppe.personnel where Binary Nom ='" + textBoxID.Text+ "' AND Binary Mot_de_passe = '" + textBoxMDP.Text+"';";
            lecteur = sqlCommand.ExecuteReader();
            if (lecteur.HasRows)
            {
                /*Si le mdp est égal au nom du compte alors on ouvre une page pour le changer*/
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
                    int ID_perso = -1;
                    string role = null;
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
                        lecteur.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mot de passe ou identifiant incorrect");
                        lecteur.Close();
                    }

                    sqlCommand.CommandText = "select * from personnel natural join attribuer where personnel.ID_personnel = "+ ID_perso +";";
                        lecteur = sqlCommand.ExecuteReader();
                     if (lecteur.HasRows)
                        {
                            while (lecteur.Read())
                            {
                                /*recupération du role de l'utilisateur*/
                                role = lecteur.GetString(4);
                            }
                        MessageBox.Show("Bienvenue " + textBoxID.Text +" et l'ID est" + ID_perso + "et votre role est "+ role +".");                            
                        this.Close();
                        lecteur.Close();
                        }              
                     else
                    {
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
