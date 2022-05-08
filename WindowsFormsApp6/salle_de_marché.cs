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
using System.Diagnostics;
using System.Reflection;

namespace WindowsFormsApp6
{

    public partial class salle_de_marché : Form
    {
        MySqlCommand sqlCommand;
        int ID_User;
        static int ID_test;
        Process VAR;
        public salle_de_marché()
        {
            /*connexion a la db*/
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
            string connetionString = "server=78.123.62.241;uid=" + user + ";password=" + pwd + ";database=ppe;";
            try
            {
                MySqlConnection cnn = new MySqlConnection(connetionString);
                cnn.Open();
                label1.BackColor = Color.Green;
                sqlCommand = cnn.CreateCommand();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erreur de connexion");
            }

        }
        private void personnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_role_onglet_utilisateur();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tooldeco_Click(object sender, EventArgs e)
        {
            /*déco du compte et remise a false du visible en fonction du profil*/
            connexion connexion = new connexion(sqlCommand);
            ID_User = -1;
            if (ID_User < 0)
            {
                lblCompte.Text = "Connectez vous";
                lblCompte.BackColor = Color.Red;
                toolco.Enabled = true;
                tooldeco.Enabled = false;
                personnelToolStripMenuItem1.Visible = false;
                administrationToolStripMenuItem.Visible = false;
                documentsToolStripMenuItem.Visible = false;
                opérationsToolStripMenuItem.Visible = false;
                produitsToolStripMenuItem.Visible = false;
            }
            connexion.Dispose();

        }

        private void ajouterUnePersonneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajout_personnel form2 = new ajout_personnel(sqlCommand);
            form2.ShowDialog();
            form2.Dispose();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            Gestion_role_onglet_utilisateur();
            VAR = start_variation();
        }

        private void visualiserLePersonnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(sqlCommand);
            form4.ShowDialog();
            form4.Dispose();
        }

        private void gérerLesBudgetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            budgets budgets = new budgets(sqlCommand);
            budgets.ShowDialog();
            budgets.Dispose();
        }

        private void testFicherPersoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string num = "-1";
            Fiche_personnel fiche_personnel = new Fiche_personnel(sqlCommand, num);
            fiche_personnel.ShowDialog();
            fiche_personnel.Dispose();
        }

        private void administrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void opérationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opérations operation = new Opérations(sqlCommand);
            operation.ShowDialog();
            operation.Dispose();
        }

        private void créationDesTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void coursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cours cours = new Cours(sqlCommand);
            cours.ShowDialog();
            cours.Dispose();
        }

        private void lblCompte_Click(object sender, EventArgs e)
        {

        }

        private void coursToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Cours cours = new Cours(sqlCommand);
            cours.ShowDialog();
            cours.Dispose();
        }

        private void créationDesTablesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void personnelToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void salle_de_marché_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void salle_de_marché_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop_variation(VAR);
        }

        private void opérationsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Opérations opérations = new Opérations(sqlCommand);
            opérations.ShowDialog();
            opérations.Dispose();
        }

        private void opérationsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Gestion_role_onglet_utilisateur()
        {
            connexion connexion = new connexion(sqlCommand);
            connexion.ShowDialog();
            int ID_User = connexion.getID();
            ID_test = ID_User;
            string role = connexion.getRole();
            if (ID_User > 0)
            {
                toolco.Enabled = false;
                tooldeco.Enabled = true;

                if (role == "ADM")
                {
                    lblCompte.Text = role.ToString();
                    lblCompte.BackColor = Color.Red;
                    /*autorisé*/
                    personnelToolStripMenuItem1.Visible = true;
                    administrationToolStripMenuItem.Visible = true;
                    personnelToolStripMenuItem1.Visible = true;
                    ajouterUnePersonneToolStripMenuItem.Visible = true;
                    visualiserLePersonnelToolStripMenuItem.Visible = true;
                    testFicherPersoToolStripMenuItem.Visible = false;

                    /*interdit*/
                    gérerLesBudgetsToolStripMenuItem.Visible = false;


                }
                else if (role == "RES")
                {
                    lblCompte.Text = role.ToString();
                    lblCompte.BackColor = Color.Green;
                    /*autorisé*/
                    personnelToolStripMenuItem1.Visible = true;
                    documentsToolStripMenuItem.Visible = true;
                    gérerLesBudgetsToolStripMenuItem.Visible = true;
                    /*interdit*/
                    ajouterUnePersonneToolStripMenuItem.Visible = false;
                    visualiserLePersonnelToolStripMenuItem.Visible = false;
                    testFicherPersoToolStripMenuItem.Visible = false;

                }
                else if (role == "TRD")
                {
                    lblCompte.Text = role.ToString();
                    lblCompte.BackColor = Color.Orange;
                    /*autorisé*/
                    produitsToolStripMenuItem.Visible = true;
                    opérationsToolStripMenuItem.Visible = true;

                }

            }
            else
            {
                lblCompte.Text = "Connectez vous";
                lblCompte.BackColor = Color.Red;
                toolco.Enabled = true;
                tooldeco.Enabled = false;
                personnelToolStripMenuItem1.Visible = false;
                ajouterUnePersonneToolStripMenuItem.Visible = false;
                visualiserLePersonnelToolStripMenuItem.Visible = false;
                testFicherPersoToolStripMenuItem.Visible = false;
                documentsToolStripMenuItem.Visible = false;
                produitsToolStripMenuItem.Visible = false;
                opérationsToolStripMenuItem.Visible = false;
                personnelToolStripMenuItem1.Visible = false;
                documentsToolStripMenuItem.Visible = false;
                gérerLesBudgetsToolStripMenuItem.Visible = false;
                personnelToolStripMenuItem1.Visible = false;
                administrationToolStripMenuItem.Visible = false;
                personnelToolStripMenuItem1.Visible = false;
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            
        }

        private Process start_variation()
        {
            string execPath = AppDomain.CurrentDomain.BaseDirectory;
            //MessageBox.Show(execPath);
            Process process = new Process();
            process.StartInfo.FileName = execPath+"\\Variation\\Variation.exe";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.Start();
            return process;
        }
        public void stop_variation(Process process)
        {
            process.Kill();
        }
        public int getID()
        {
            return ID_test;
        }
    }
}
