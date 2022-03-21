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
        string dataBaseName;
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
                sqlCommand.CommandText = "INSERT INTO personnel (Nom, Prenom, mot_de_passe) VALUES ('" + textBoxNom.Text + "', '" + textBoxPrenom.Text + "', '" + textBoxNom.Text + "')";
                sqlCommand.ExecuteNonQuery();
                MySqlDataReader lecteur;
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
                    sqlCommand.CommandText = "INSERT INTO attribuer (ID_categorie, ID_personnel, date_debut, date_fin) VALUES ('" +id_categorie+"',"+ID+",'"+ dateTimeDebut.Value.ToString("u").Substring(0, 19) + "', '" + dateTimeFin.Value.ToString("u").Substring(0, 19) + "')";
                    sqlCommand.ExecuteNonQuery();

                }
                else
                {
                    sqlCommand.CommandText = "INSERT INTO attribuer (ID_categorie, ID_personnel, date_debut) VALUES ('" + id_categorie + "'," + ID + ",'" + dateTimeDebut.Value.ToString("u").Substring(0, 19) + "')";
                    sqlCommand.ExecuteNonQuery();
                }
                sqlCommand.CommandText = "commit";
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("L'utilisateur a été créer");
                this.Close();
            }

            catch (Exception ex)
            {
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
    }
}