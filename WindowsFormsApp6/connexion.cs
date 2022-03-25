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
                    int IDP;
                    string source = textBoxMDP.Text;
                    string mdp = Libe.Hash(source);
                    //Compte compte = new Compte();
                    sqlCommand.CommandText = "SELECT Nom , Mot_de_passe, ID_personnel FROM ppe.personnel where Nom ='" + textBoxID.Text + "' && Mot_de_passe = '" + mdp + "';";
                    lecteur = sqlCommand.ExecuteReader();
                    if (lecteur.HasRows)
                    {
                        //compte.Nom = textBoxID.Text;
                        while (lecteur.Read())
                        {
                            /*recupération de l'id utilisateur*/
                            ID_perso = lecteur.GetInt32(2);
                        }
                        //compte.ID_Perso = ID_perso;
                        
                        lecteur.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mot de passe ou identifiant incorrect");
                        lecteur.Close();
                    }
                    IDP = ID_perso;
                    sqlCommand.CommandText = "select * from personnel natural join attribuer where personnel.ID_personnel = " + ID_perso + ";";
                    lecteur = sqlCommand.ExecuteReader();
                    if (lecteur.HasRows)
                    {
                        while (lecteur.Read())
                        {
                            /*recupération du role de l'utilisateur*/
                            role = lecteur.GetString(4);
                        }
                        //compte.Role = role;
                        //MessageBox.Show(compte.Nom + "  " + compte.ID_Perso + " " + compte.Role);
                        salle_de_marché salle_De_marché = new salle_de_marché(IDP, sqlCommand);
                        lecteur.Close();
                        salle_De_marché.ShowDialog();
                        salle_De_marché.Dispose();
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

        private void connexion_Load(object sender, EventArgs e)
        {
            
        }

        private void connexion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
