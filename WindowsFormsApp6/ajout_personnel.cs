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
    public partial class ajout_personnel : Form
    {
        MySqlCommand sqlCommand;
        public ajout_personnel(MySqlCommand sqlC)
        {
            InitializeComponent();
            sqlCommand = sqlC;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlCommand.CommandText = "start transaction";
            sqlCommand.ExecuteNonQuery();
            try
            {
                /*choix radius du role*/
                string id_categorie;
                if(radioButtonTRD.Checked == true)
                {
                    id_categorie = "TRD";
                }
                else if (radioButtonADM.Checked == true)
                {
                    id_categorie = "ADM";
                }
                else
                {
                    id_categorie = "RES";
                }
                int ID = -1;
                /*création du compte dans la bdd avec mdp = nom*/
                sqlCommand.CommandText = "INSERT INTO personnel (Nom, Prenom, mot_de_passe) VALUES ('" + textBoxNom.Text + "', '" + textBoxPrenom.Text + "', '" + textBoxNom.Text + "')";
                sqlCommand.ExecuteNonQuery();
                MySqlDataReader lecteur;
                /*on récupère l'id du compte créer pour le réutiliser pour attribuer le role*/
                sqlCommand.CommandText = "SELECT Last_Insert_ID()";
                lecteur = sqlCommand.ExecuteReader();
                if (lecteur.HasRows)
                {
                    while (lecteur.Read())
                    {
                        ID = lecteur.GetInt16(0);
                    }

                }
                lecteur.Close();
                if (checkBoxNoDate.Checked == false)
                {
                    /*Date de début et date de fin du compte*/
                    sqlCommand.CommandText = "INSERT INTO attribuer (ID_categorie, ID_personnel, date_debut, date_fin) VALUES ('" +id_categorie+"',"+ID+",'"+ dateTimeDebut.Value.ToString("u").Substring(0, 19) + "', '" + dateTimeFin.Value.ToString("u").Substring(0, 19) + "')";
                    sqlCommand.ExecuteNonQuery();

                }
                else
                {
                    /*Date de début et PAS de date de fin du compte*/
                    sqlCommand.CommandText = "INSERT INTO attribuer (ID_categorie, ID_personnel, date_debut) VALUES ('" + id_categorie + "'," + ID + ",'" + dateTimeDebut.Value.ToString("u").Substring(0, 19) + "')";
                    sqlCommand.ExecuteNonQuery();
                }
                if (radioButtonADM.Checked == false)
                {
                    /*si création d'un trader alors initialisation du budget pour tarder*/
                    sqlCommand.CommandText = "insert into budget (Budget, Date, ID_personnel) value ('1000','"+ dateTimeDebut.Value.ToString("u").Substring(0, 19) +"', "+ ID + ")";
                    sqlCommand.ExecuteNonQuery();
                }
                /*si tout ce passe bien on commit les commande sql et le compte se créé*/
                sqlCommand.CommandText = "commit";
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("L'utilisateur a été créer");
                //MessageBox.Show(compte.Nom + "  " + compte.ID_Perso + " " + compte.Role);
                this.Close();
            }

            catch (Exception ex)
            {
                /*Pb dans la création du compte donc erreur*/
                sqlCommand.CommandText = "rollback";
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show(ex.Message);

            }
        }

        private void checkBoxNoDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNoDate.Checked == true)
            {
                dateTimeFin.Visible = false;
            }

            else
            {
                dateTimeFin.Visible = true;
            }
        }

        private void radioButtonTRD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonADM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonRSP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeFin_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}