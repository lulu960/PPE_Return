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
            sqlCommand.CommandText = "start transaction";
            sqlCommand.ExecuteNonQuery();
            MySqlDataReader lecteur;
            sqlCommand.CommandText = "SELECT Nom , Mot_de_passe FROM ppe.personnel where Nom ='"+textBoxID.Text+"' && Mot_de_passe = '"+textBoxID.Text+"';";
            lecteur = sqlCommand.ExecuteReader();
            if (lecteur.HasRows)
            {
                lecteur.Close();
                ChangementMDP ChangementMDP = new ChangementMDP(textBoxID.Text, sqlCommand);
                ChangementMDP.ShowDialog();
                ChangementMDP.Dispose();
            }
            else {
                try
                {
                    string source = textBoxMDP.Text;
                    using (SHA512 sha512Hash = SHA512.Create())
                    {
                        //From String to byte array
                        byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
                        byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes);
                        string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                        MessageBox.Show("The SHA512 hash of " + source + " is: " + hash);
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
    }
}
