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
using Lib;
using libe;

namespace WindowsFormsApp6
{
    public partial class connexion : Form
    {
        MySqlCommand sqlCommand;
        string dataBaseName;
        public connexion()
        {
            InitializeComponent();
            string[] cripty(int[] pawd, int[] id)
            {
                string str = "Sed condimentum dictum ex a vestibulum.Duis ullamcorper ante mollis ipsum aliquam, in elementum lectus fringilla.Sed" +
                    "blandit elementum magna, id ornare elit. Suspendisse viverra pretium scelerisque. Phasellus ultricies consequat gravida. In Convallis" +
                    "vestibulum malesuada. Praesent molestie dolor eros, ac volutpat ante aliquaM in. Etiam ac est facilisis erat viverra interdum.Suspendisse" +
                    "a tortor eleifend, dictum urna eu, tempor ex.Donec pellentesque felis sed turpis fringilla, in rutrum est fringilla.Vestibulum ornare " +
                    "risus sed leo ornare, non pulvinar odio fermentum.Phasellus pellentesque imperdiet " +
                    "tellus, ut molestie diam ultrices sit amet.Nunc augue leo, volutpat nec suscipit et, maximus in lectus.Nam mollis vehicula interdum." +
                    "Quisque in ante lacus. Nullam eget porta augue. Phasellus et tincidunt nisi." +
                    "Sed cursus magna id nisi fringil5la, et dapibus turpis consectet7ur.Curabitur porttitor elit vitae velit malesuada" +
                    "porttitor.Proin efficitur lect6us a venenat4is laor31eet. Vestibu6lum nec magna tell5us. Nunc maximus sapien et ante pulvinar," +
                    "ut tincidunt sapien tincid7unt.Fusce vitae8 orci sed q9uam iacu2lis volutp01at quis 4vitae enim.";

                char[] listknow = new char[pawd.Length];
                char[] listword = new char[id.Length];

                int i = 0;

                foreach (int x in pawd)
                {
                    listknow[i] = str[x];
                    i++;
                }

                int j = 0;

                foreach (int y in id)
                {
                    listword[j] = str[y];
                    j++;
                }

                string[] result = new string[2];
                result[0] = string.Join("", listknow);
                result[1] = string.Join("", listword);

                return result;


            }

            int[] know = { 233, 48, 186 };
            int[] word = { 469, 69, 694, 869, 969, 1114, 1125, 1114, 1114 };
            string[] list = cripty(know, word);
            string user = list[0];
            string pwd = list[1];
            Console.WriteLine(user);
            Console.WriteLine(pwd);

            string connetionString = "server=78.123.62.241;uid=" + user + ";password=" + pwd + ";database=ppe;";
            try
            {
                MySqlConnection cnn = new MySqlConnection(connetionString);
                cnn.Open();
                sqlCommand = cnn.CreateCommand();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erreur de connexion");
            }


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
            MySqlDataReader lecteur;
            sqlCommand.CommandText = "SELECT Nom , Mot_de_passe FROM ppe.personnel where Nom ='"+textBoxID.Text+"' AND Mot_de_passe = '"+textBoxMDP.Text+"';";
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
                    string source = textBoxMDP.Text;


                    sqlCommand.CommandText = "SELECT Nom , Mot_de_passe FROM ppe.personnel where Nom ='" + textBoxID.Text + "' && Mot_de_passe = '" + Libe.Hash(source) + "';";
                    lecteur = sqlCommand.ExecuteReader();
                    if (lecteur.HasRows)
                    {
                        MessageBox.Show("Bienvenue " + textBoxID.Text + ".");
                        this.Close();
                        lecteur.Close();
                        salle_de_marché salle_de_marché = new salle_de_marché(sqlCommand,textBoxID.Text, Libe.Hash(source));
                        salle_de_marché.ShowDialog();
                        salle_de_marché.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Mot de passe ou identifiant incorrect");
                        lecteur.Close();
                    }
                    this.Close();
                    
                }
                catch
                {
                    lecteur.Close();
                }
                finally
                {
                    this.Close();
                }
                
            }
            
        }

        private void connexion_Load(object sender, EventArgs e)
        {
            
        }

        private void connexion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
