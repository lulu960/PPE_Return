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
    public partial class Vente : Form
    {
        MySqlCommand sqlC;
        MySqlDataReader lecteur;
        MySqlCommand sqlCommand;

        int Qunatité_action;
        int nb_vente;
        int id;
        int id_port;
        string ID_achat;
        string Prix;
        float font_trd;
        public Vente(MySqlCommand sqlC, string id_achat, string prix, int qunatité_action )
        {
            InitializeComponent();
            label1.Text = ("Qu'elle quantité d'action voulez vous vendre du groupe ?");
            sqlCommand = sqlC;
            Qunatité_action = qunatité_action;
            ID_achat = id_achat;
            Prix = prix;
            salle_de_marché sdl = new salle_de_marché();
            id = sdl.getID();
            sdl.Dispose();
            numericUpDown1.Minimum = 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            nb_vente = Convert.ToInt32(numericUpDown1.Value);
        }

        private void btnVald_Click(object sender, EventArgs e)
        {
            string message = "Etre vous sur de vouloir Valider l'opération?";
            string titre = "Valider transaction";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, titre, buttons);
            if (result == DialogResult.Yes)
            {
                if (nb_vente <= Qunatité_action)
                {
                    sqlCommand.CommandText = "Use ppe";
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.CommandText = "SELECT budget, ID_budget FROM ppe.budget where ID_personnel = " + id + "";
                    lecteur = sqlCommand.ExecuteReader();
                    if (lecteur.HasRows)
                    {
                        while (lecteur.Read())
                        {
                            id_port = lecteur.GetInt32(1);
                            font_trd = lecteur.GetFloat(0);
                        }
                    }
                    lecteur.Close();
                    if (nb_vente == Qunatité_action)
                    {
                        float Prix_action = float.Parse(Prix);
                        float Prix_tt = nb_vente * Prix_action;
                        string Prix_tts = Prix_tt.ToString();
                        Prix_tts = Prix_tts.Replace(",", ".");
                        Prix = Prix.Replace(",", ".");
                        sqlCommand.CommandText = "UPDATE `ppe`.`budget` SET `Budget` = Budget + " + Prix_tts + " WHERE (`ID_budget` = " + id_port + ")";
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.CommandText = "DELETE FROM portefeuille_de_cotation WHERE ID_achat = '" + ID_achat + "'";
                        sqlCommand.ExecuteNonQuery();
                        lecteur.Close();
                        MessageBox.Show("L'opération a été éfectué avec succès");
                        this.Close();
                    }
                    else
                    {
                        float Prix_action = float.Parse(Prix);
                        float Prix_tt = nb_vente * Prix_action;
                        string Prix_tts = Prix_tt.ToString();
                        Prix_tts = Prix_tts.Replace(",", ".");
                        sqlCommand.CommandText = "UPDATE `ppe`.`budget` SET `Budget` = Budget + '" + Prix_tts + "' WHERE (`ID_budget` = " + id_port + ")";
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.CommandText = "update portefeuille_de_cotation set Volume = Volume - " + nb_vente + " WHERE ID_achat = '" + ID_achat + "'";
                        sqlCommand.ExecuteNonQuery();
                        lecteur.Close();
                        MessageBox.Show("L'opération a été éfectué avec succès");
                        this.Close();
                    }
                }
                else { MessageBox.Show("Vous ne pouvez pas vendre plus d'action plus que vous n'en posséder"); }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Vente_Load(object sender, EventArgs e)
        {

        }
    }
}
