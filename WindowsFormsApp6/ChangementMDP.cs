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
                {
                    try
                    {
                        
                        sqlCommand.CommandText = "Use ppe";
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand.CommandText = "Update personnel SET Mot_de_passe = ('" + Libe.Hash(source) + "') where Nom = ('" + IDEnregistree + "')";
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Votre mot de passe a bien été enregistré.");
                        this.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Les mots de passe ne sont pas identique");
            }
        }
        private void ChangementMDP_Load(object sender, EventArgs e)
        {

        }

        private void cbxVisibleMDP_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxVisibleMDP.Checked == true)
            {
                textBoxNvMDP1.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxNvMDP1.UseSystemPasswordChar = true;
            }
        }
    }
    }

