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

    public partial class Quantité_operation : Form
    {
        MySqlCommand sqlC;
        MySqlDataReader lecteur;
        MySqlCommand sqlCommand;
        float prix;
        string ISN;
        int nb;
        int id;
        int id_compte;
        float Budget;
        float nbactn;
        public Quantité_operation(MySqlCommand sqlC, string isn, float cour, float budgetdispo)
        {
            InitializeComponent();
            label1.Text =("Qu'elle quantité d'action voulez vous acheter du groupe ?") + isn +"  "+ cour;
            prix = cour;
            salle_de_marché sdl = new salle_de_marché();
            id = sdl.getID();
            ISN = isn;
            sdl.Dispose();
            sqlCommand = sqlC;
            Budget = budgetdispo;
            numericUpDown1.Minimum = 1;
        }

        private void Quantité_operation_Load(object sender, EventArgs e)
        {

        }

        private void btnVald_Click(object sender, EventArgs e)
        {
            string message = "Etre vous sur de vouloir Valider l'opération?";
            string titre = "Valider transaction";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, titre, buttons);
            if (result == DialogResult.Yes)
            { 
                try
            {
                float Prix_tt = nb * prix;
                sqlCommand.CommandText = "SELECT budget, ID_budget FROM ppe.budget where ID_personnel = "+id+"";
                lecteur = sqlCommand.ExecuteReader();
                if (lecteur.HasRows)
                {
                    while (lecteur.Read())
                    {
                        id_compte = lecteur.GetInt32(1);
                        Budget = lecteur.GetFloat(0);
                    }
                }
                lecteur.Close();
                if (Prix_tt <= Budget)
                {
                    string prix_tts = Prix_tt.ToString();
                    prix_tts = prix_tts.Replace(",", ".");
                    string prixs = prix.ToString();
                    prixs = prixs.Replace(",", ".");

                    sqlCommand.CommandText = "Use ppe";
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.CommandText = "UPDATE `ppe`.`budget` SET `Budget` = Budget - "+ prix_tts + " WHERE (`ID_budget` = "+ id_compte + ")";
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.CommandText = "insert into portefeuille_de_cotation set ID_Portefeuille = "+id_compte+" , Cotation_acheter = '"+ISN+"', Volume =  Volume + "+nb+", Prix ="+ prixs + " ,plafond = 0, ID_personnel = "+id+"";
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.CommandText = "SELECT ID_achat FROM portefeuille_de_cotation WHERE ID_achat=LAST_INSERT_ID()";
                    int last_id = (Int32)sqlCommand.ExecuteScalar();
                    sqlCommand.CommandText = "insert into achete_des_actions (ID_personnel, ID_cotation,Date_d_achat) value ("+id+","+last_id+",'"+DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")+"')";
                    sqlCommand.ExecuteNonQuery();
                    lecteur.Close();
                    MessageBox.Show("Vous avez achetez");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vous ne disposer pas assez d'argent pour acheter " + nb + " du groupe " + ISN + "");
                }
            }
            catch
            {
            }
        }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            nb = Convert.ToInt32(numericUpDown1.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
