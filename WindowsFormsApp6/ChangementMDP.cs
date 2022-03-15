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
    public partial class ChangementMDP : Form
    {
        MySqlCommand sqlCommand;
        string dataBaseName;
        string IDEnregistree;
        public ChangementMDP(string ID, MySqlCommand sqlC)
        {
            InitializeComponent();
            IDEnregistree = ID;
            sqlCommand = sqlC;
        }

        private void btnEnregistreNvMDP_Click(object sender, EventArgs e)
        {
            if (textBoxNvMDP1.Text == textBoxNvMDP2.Text)
            {
                string source = textBoxNvMDP1.Text;
                /*using (SHA512 sha512Hash = SHA512.Create())
                {
                    try
                    {

                        //From String to byte array
                        byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
                        byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes);
                        string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                        sqlCommand.CommandText = "Use ppe";
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.CommandText = "Update personnel SET Mot_de_passe = ('" + hash + "') where Nom = ('" + IDEnregistree + "')";
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show(IDEnregistree);

                    }*/
                    try
                    {
                    sqlCommand.CommandText = "Update personnel SET Mot_de_passe = ('123') where Nom = ('test')";
                    sqlCommand.ExecuteNonQuery();
                }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            /*else
            {
                MessageBox.Show("Les mots de passe ne sont pas identique");
            }
        }*/
    }
}
