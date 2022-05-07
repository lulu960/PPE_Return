using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libe;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp6
{
    public partial class Fiche_personnel : Form
    {
        MySqlDataReader lecteur;
        MySqlCommand sqlCommand;
        MySqlCommand sqlC;
        string idp;
        string id_categorie = "";
        string nom = "";
        string dated = "";
        string datef = "";
        public Fiche_personnel(MySqlCommand sqlC, string id)
        {
            InitializeComponent();
            sqlCommand = sqlC;
            idp = id;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Etre vous sur de voulouir appliquer les modifications ?";
            string titre = "Compte ID " + idp + "";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, titre, buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                    sqlCommand.CommandText = "update personnel set Nom ='" + textBox1.Text + "' , Prenom = '" + textBox2.Text + "' where ID_personnel = " + idp + "";
                    sqlCommand.ExecuteNonQuery();
                    if (radioButtonADM.Checked == true && checkBoxNoDate.Checked == false)
                    {
                        sqlCommand.CommandText = "update attribuer set ID_categorie = 'ADM' , date_debut ='" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "' , date_fin = '" + dateTimePicker2.Value.ToString("u").Substring(0, 19) + "' where ID_personnel = " + idp + "";
                        sqlCommand.ExecuteNonQuery();
                    }
                    else if (radioButtonADM.Checked == true && checkBoxNoDate.Checked == true)
                    {
                        sqlCommand.CommandText = "update attribuer set ID_categorie = 'ADM' , date_debut ='" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "' , date_fin = NULL where ID_personnel = " + idp + "";
                        sqlCommand.ExecuteNonQuery();
                    }
                    if (radioButtonTRD.Checked == true && checkBoxNoDate.Checked == false)
                    {
                        sqlCommand.CommandText = "update attribuer set ID_categorie = 'TRD' , date_debut ='" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "' , date_fin = '" + dateTimePicker2.Value.ToString("u").Substring(0, 19) + "' where ID_personnel = " + idp + "";
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.CommandText = "insert into budget (Budget, Date, ID_personnel) value ('1000','" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "', " + idp + ")";
                        sqlCommand.ExecuteNonQuery();
                    }
                    else if (radioButtonTRD.Checked == true && checkBoxNoDate.Checked == true)
                    {
                        sqlCommand.CommandText = "update attribuer set ID_categorie = 'TRD' , date_debut ='" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "' , date_fin = NULL where ID_personnel = " + idp + "";
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.CommandText = "insert into budget (Budget, Date, ID_personnel) value ('1000','" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "', " + idp + ")";
                        sqlCommand.ExecuteNonQuery();
                    }
                    if (radioButtonRSP.Checked == true && checkBoxNoDate.Checked == false)
                    {
                        sqlCommand.CommandText = "update attribuer set ID_categorie = 'RES' , date_debut ='" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "' , date_fin = '" + dateTimePicker2.Value.ToString("u").Substring(0, 19) + "' where ID_personnel = " + idp + "";
                        sqlCommand.ExecuteNonQuery();

                    }
                    else if (radioButtonRSP.Checked == true && checkBoxNoDate.Checked == true)
                    {
                        sqlCommand.CommandText = "update attribuer set ID_categorie = 'RES' , date_debut ='" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "'  , date_fin = NULL  where ID_personnel = " + idp + "";
                        sqlCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Les modifications on bien été apporter");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Les modifications on bien été apporter");
                    this.Close();
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fiche_personnel_Load(object sender, EventArgs e)
        {
            
            
            sqlCommand.CommandText = "select Nom,Prenom,ID_categorie,date_debut,date_fin from personnel natural join attribuer where personnel.ID_personnel =" + idp + " && isnull(date_fin); ";
            lecteur = sqlCommand.ExecuteReader();
            if (lecteur.HasRows)
            {
                while (lecteur.Read())
                {
                    /*recupération de l'id utilisateur*/
                    textBox1.Text = lecteur.GetString(0);
                    textBox2.Text = lecteur.GetString(1);
                    id_categorie = lecteur.GetString(2);
                    dated = lecteur.GetString(3);
                }
                checkBoxNoDate.Checked = true;
                DateTime datedDateTime = DateTime.Parse(dated);
                dateTimePicker1.Value = datedDateTime;
                dateTimePicker2.Value = DateTime.Now;

                lecteur.Close();
            }
            else
            {
                lecteur.Close();
                sqlCommand.CommandText = "select Nom,Prenom,ID_categorie,date_debut,date_fin from personnel natural join attribuer where personnel.ID_personnel = " + idp + "";
                lecteur = sqlCommand.ExecuteReader();
                if (lecteur.HasRows)
                {
                    while (lecteur.Read())
                    {
                        /*recupération de l'id utilisateur*/
                        textBox1.Text = lecteur.GetString(0);
                        textBox2.Text = lecteur.GetString(1);
                        id_categorie = lecteur.GetString(2);
                        dated = lecteur.GetString(3);
                        datef = lecteur.GetString(4);
                    }
                    lecteur.Close();
                    dateTimePicker2.Visible = true;
                    checkBoxNoDate.Checked = false;
                    DateTime datedDateTime = DateTime.Parse(dated);
                    dateTimePicker1.Value = datedDateTime;
                    DateTime datefDateTime = DateTime.Parse(datef);
                    dateTimePicker2.Value = datefDateTime;
                }
            }
            if (id_categorie == "TRD")
            {
                radioButtonTRD.Checked = true;
            }
            else if (id_categorie == "ADM")
            {
                radioButtonADM.Checked = true;
            }
            else
            {
                radioButtonRSP.Checked = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonADM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           string message = "Etre vous sur de supprimer le compte " + textBox1.Text + " qui a comme role " + id_categorie + "?";
            string titre = "Compte ID " + idp + "";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, titre, buttons);
            if(result == DialogResult.Yes)
            {
            try
            {
                sqlCommand.CommandText = "delete from Budget where ID_personnel =" + idp + "";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "delete from attribuer where ID_personnel =" + idp + "";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = "delete from personnel where ID_personnel =" + idp + "";
                sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Le compte a bien été supprimé.");
            }
            catch
            {
                MessageBox.Show("Erreur lors de la suppression du compte");
            }
            }
        }

        private void Fiche_personnel_Leave(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Etre vous sur de vouloir réinitialiser le mot de passe (nom d'utilisateur)?";
            string titre = "Compte ID " + idp + "";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, titre, buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                sqlCommand.CommandText = "Update personnel SET Mot_de_passe = ('" + nom + "') where ID_personnel = ('" + idp + "')";
                sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Le mot de passe a bien été réinitialiser");
                }
                catch
                {
                    MessageBox.Show("Erreur lors de la réinitialiser du mot de passe.");
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxNoDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNoDate.Checked == true)
            {
                dateTimePicker2.Visible = false;
            }

            else
            {
                dateTimePicker2.Visible = true;
            }
        }
    }
    }
