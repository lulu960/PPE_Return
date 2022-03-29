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
        int ID_user = -1;
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataReader lecteur;
            sqlCommand.CommandText = "SELECT Nom , Mot_de_passe FROM ppe.personnel where Binary Nom ='" + textBoxID.Text + "' AND Binary Mot_de_passe = '" + textBoxMDP.Text + "';";
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
                    int ID_perso = -1;
                    string role = null;
                    string source = textBoxMDP.Text;
                    string mdp = Libe.Hash(source);
                    Compte compte = new Compte();
                    sqlCommand.CommandText = "SELECT Nom , Mot_de_passe, ID_personnel FROM ppe.personnel where Nom ='" + textBoxID.Text + "' && Mot_de_passe = '" + mdp + "';";
                    lecteur = sqlCommand.ExecuteReader();
                    if (lecteur.HasRows)
                    {
                        compte.Nom = textBoxID.Text;
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
                        MessageBox.Show("Mot de passe ou identifiant incorrect");
                        lecteur.Close();
                    }

                    sqlCommand.CommandText = "select * from personnel natural join attribuer where personnel.ID_personnel = " + ID_perso + ";";
                    lecteur = sqlCommand.ExecuteReader();
                    if (lecteur.HasRows)
                    {
                        while (lecteur.Read())
                        {
                            /*recupération du role de l'utilisateur*/
                            role = lecteur.GetString(4);
                        }
                        compte.Role = role;
                        MessageBox.Show(compte.Nom + "  " + ID_user + " " + compte.Role);
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
        

        public int getID()
        {
            return ID_user;
        }

        private void connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
