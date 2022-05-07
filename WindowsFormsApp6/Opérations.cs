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
    public partial class Opérations : Form
    {
        MySqlCommand sqlCommand;
        MySqlDataReader lecteur;
        MySqlCommand sqlC;
        int id1;
        float prix;
        float budget_dispo;
        public Opérations(MySqlCommand sqlC)
        {
            InitTimer();
            salle_de_marché sdl = new salle_de_marché();
            id1 = sdl.getID();
            sdl.Dispose();
            /*datagridview opération*/
            InitializeComponent();
            dtgTitre.ClearSelection();
            sqlCommand = sqlC;
            sqlC = Refresh(sqlC);
            dtgTitre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgTitre.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgTitre.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgTitre.AllowUserToAddRows = false;
            dtgTitre.AllowUserToDeleteRows = false;
            dtgTitre.ReadOnly = true;
            dtgTitre.RowHeadersVisible = false;
            dtgTitre.DefaultCellStyle.BackColor = Color.IndianRed;
            foreach (DataGridViewColumn column in dtgTitre.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dtgTitre.ClearSelection();
            sqlCommand = sqlC;
            sqlC = Refresh1(sqlC);
            dtgOperation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgOperation.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgOperation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgOperation.AllowUserToAddRows = false;
            dtgOperation.AllowUserToDeleteRows = false;
            dtgOperation.ReadOnly = true;
            dtgOperation.RowHeadersVisible = false;
            dtgOperation.RowsDefaultCellStyle.SelectionBackColor = Color.Empty;
            foreach (DataGridViewColumn column in dtgOperation.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            
        }

        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(refreshdata);
            timer1.Interval = 5000;
            timer1.Start();
        }

        private void refreshdata(object sender, EventArgs e)
        {
            Refresh(sqlCommand);
        }
        MySqlCommand Refresh(MySqlCommand sqlC)
        {
            string commande = "SELECT libelles.ISIN, libelles.Cours, libelles.Produits, produits_financier.Cour_min, produits_financier.Cour_max  FROM produits_financier natural join libelles where produits_financier.Code_ISIN = libelles.ISIN";
            MySqlDataAdapter sqlDa = new MySqlDataAdapter(commande, sqlCommand.Connection);
            DataTable dt1 = new DataTable();
            sqlDa.Fill(dt1);
            dtgTitre.DataSource = dt1;
            return (sqlC);
        }

        MySqlCommand Refresh1(MySqlCommand sqlC)
        {
            string commande = "SELECT ID_achat, Cotation_acheter, Volume,prix, libelles.Produits,achete_des_actions.Date_d_achat FROM ppe.portefeuille_de_cotation natural join libelles,achete_des_actions where portefeuille_de_cotation.Cotation_acheter = libelles.ISIN && portefeuille_de_cotation.ID_achat = achete_des_actions.ID_cotation && portefeuille_de_cotation.ID_personnel = "+ id1 + ";";
            MySqlDataAdapter sqlDa1 = new MySqlDataAdapter(commande, sqlCommand.Connection);
            DataTable dt2 = new DataTable();
            sqlDa1.Fill(dt2);
            dtgOperation.DataSource = dt2;
            return (sqlC);
        }

        private void budget_total()
        {
            salle_de_marché sdl = new salle_de_marché();
            int id = sdl.getID();
            sdl.Dispose();
            sqlCommand.CommandText = "SELECT * FROM ppe.budget where ID_personnel = " + id + " ";
            lecteur = sqlCommand.ExecuteReader();
            if (lecteur.HasRows)
            {
                while (lecteur.Read())
                {
                    /*recupération le budget total*/
                    lbl_budget_total.Text = lecteur.GetString(1);
                    lbl_budget_total.Text.Replace('.', ',');
                }
            }
            lecteur.Close();
        }

        private void cout_portefeuille()
        {
            salle_de_marché sdl = new salle_de_marché();
            int id = sdl.getID();
            sdl.Dispose();
            sqlCommand.CommandText = "SELECT Volume * Prix , Cotation_acheter FROM ppe.portefeuille_de_cotation where Id_personnel = " + id + " ";
            lecteur = sqlCommand.ExecuteReader();
            prix = 0;
            if (lecteur.HasRows)
            {
                while (lecteur.Read())
                {
                    /*recupération du cout du portefeuille*/
                    float tmp = lecteur.GetFloat(0);
                    lblcoutport.Text.Replace('.', ',');
                    prix = tmp + prix;
                }
                lblcoutport.Text = prix.ToString();
            }
            lblcoutport.Text = prix.ToString();
            lecteur.Close();
        }

        private void Valeur_portefeuille()
        {
            salle_de_marché sdl = new salle_de_marché();
            int id = sdl.getID();
            sdl.Dispose();
            /*Valeur portefeuille*/
            sqlCommand.CommandText = "select sum(Volume * libelles.Cours) Cotation_acheter from portefeuille_de_cotation natural join libelles where ID_personnel = " + id + " && portefeuille_de_cotation.Cotation_acheter = libelles.ISIN";
            lecteur = sqlCommand.ExecuteReader();
            if (lecteur.HasRows)
            {
                float valeur_portefeuille = 0;
                while (lecteur.Read())
                {
                    if (!lecteur.IsDBNull(0))
                    {
                        /*recupération du cout du portefeuille*/
                        valeur_portefeuille = lecteur.GetFloat(0);
                        lbl_valeur.Text = valeur_portefeuille.ToString();
                        lbl_valeur.Text.Replace('.', ',');
                    }
                    else { lbl_valeur.Text = "0"; }
                }
                lecteur.Close();
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Opérations_Load(object sender, EventArgs e)
        {
            this.budget_total();
            this.cout_portefeuille();
            this.Valeur_portefeuille();
            this.couleur_dtg();
            if (dtgOperation.Rows.Count != 0) { dtgOperation.Rows[0].Selected = false; }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtgTitre_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dtgTitre_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var ISN = dtgTitre.SelectedCells[0].Value;
            var cour = dtgTitre.SelectedCells[1].Value;
            string ID_ISN = Convert.ToString(ISN);
            string Prix_cour = Convert.ToString(cour);
            float test = float.Parse(Prix_cour);
            Quantité_operation quantité_Operation = new Quantité_operation(sqlCommand, ID_ISN, test, budget_dispo);
            quantité_Operation.ShowDialog();
            this.Refresh(sqlC);
            this.Refresh1(sqlC);
            this.budget_total();
            this.cout_portefeuille();
            this.Valeur_portefeuille();
            this.couleur_dtg();
        }

        private void dtgOperation_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var ID_achat = dtgOperation.SelectedCells[0].Value;
            var Volume = dtgOperation.SelectedCells[2].Value;
            var Cotation = dtgOperation.SelectedCells[3].Value;
            string id_achat = Convert.ToString(ID_achat);
            string cotation = Convert.ToString(Cotation);
            string volume = Convert.ToString(Volume);
            int volume_int = Int32.Parse(volume);
            Vente vente = new Vente(sqlCommand, id_achat,cotation,volume_int);
            vente.ShowDialog();
            this.Refresh(sqlC);
            this.Refresh1(sqlC);
            this.budget_total();
            this.Valeur_portefeuille();
            this.cout_portefeuille();
            this.couleur_dtg();
        }

       private void couleur_dtg()
        {
           for (int i =  0; i <= dtgOperation.RowCount-1; i++)
            {
                for (int j = 0; j <= dtgTitre.RowCount-1; j++)
                {
                    string grid2 = dtgTitre.Rows[j].Cells[1].Value.ToString();
                    string grid1 = dtgOperation.Rows[i].Cells[3].Value.ToString();
                    string ISN2 = dtgTitre.Rows[j].Cells[0].Value.ToString();
                    string ISN1 = dtgOperation.Rows[i].Cells[1].Value.ToString();
                    float v2 = float.Parse(grid2);
                    float v1 = float.Parse(grid1);
                    if (v1 > v2 && ISN1 == ISN2)
                    {
                        DataGridViewRow ligne = dtgOperation.Rows[i];
                        ligne.DefaultCellStyle.BackColor = Color.Green;
                        break;
                    }
                    else { dtgOperation.Rows[i].DefaultCellStyle.BackColor = Color.IndianRed; }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void dtgOperation_BindingContextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
