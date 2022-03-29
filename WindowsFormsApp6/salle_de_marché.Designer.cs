
namespace WindowsFormsApp6
{
    partial class salle_de_marché
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tooldeco = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personnelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnePersonneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserLePersonnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesBudgetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testFicherPersoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opérationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créationDesTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remplirLesTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.personnelToolStripMenuItem1,
            this.produitsToolStripMenuItem,
            this.opérationsToolStripMenuItem,
            this.documentsToolStripMenuItem,
            this.aProposToolStripMenuItem,
            this.administrationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(741, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personnelToolStripMenuItem,
            this.tooldeco,
            this.quitterToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.testToolStripMenuItem.Text = "Fichier ";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // personnelToolStripMenuItem
            // 
            this.personnelToolStripMenuItem.Name = "personnelToolStripMenuItem";
            this.personnelToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.personnelToolStripMenuItem.Text = "Connexion ";
            this.personnelToolStripMenuItem.Click += new System.EventHandler(this.personnelToolStripMenuItem_Click);
            // 
            // tooldeco
            // 
            this.tooldeco.Enabled = false;
            this.tooldeco.Name = "tooldeco";
            this.tooldeco.Size = new System.Drawing.Size(183, 26);
            this.tooldeco.Text = "Déconnexion ";
            this.tooldeco.Click += new System.EventHandler(this.tooldeco_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.quitterToolStripMenuItem.Text = "Quitter ";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // personnelToolStripMenuItem1
            // 
            this.personnelToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnePersonneToolStripMenuItem,
            this.visualiserLePersonnelToolStripMenuItem,
            this.gérerLesBudgetsToolStripMenuItem,
            this.testFicherPersoToolStripMenuItem});
            this.personnelToolStripMenuItem1.Name = "personnelToolStripMenuItem1";
            this.personnelToolStripMenuItem1.Size = new System.Drawing.Size(86, 24);
            this.personnelToolStripMenuItem1.Text = "Personnel";
            // 
            // ajouterUnePersonneToolStripMenuItem
            // 
            this.ajouterUnePersonneToolStripMenuItem.Name = "ajouterUnePersonneToolStripMenuItem";
            this.ajouterUnePersonneToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.ajouterUnePersonneToolStripMenuItem.Text = "Ajouter une personne";
            this.ajouterUnePersonneToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnePersonneToolStripMenuItem_Click);
            // 
            // visualiserLePersonnelToolStripMenuItem
            // 
            this.visualiserLePersonnelToolStripMenuItem.Name = "visualiserLePersonnelToolStripMenuItem";
            this.visualiserLePersonnelToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.visualiserLePersonnelToolStripMenuItem.Text = "Visualiser le personnel";
            this.visualiserLePersonnelToolStripMenuItem.Click += new System.EventHandler(this.visualiserLePersonnelToolStripMenuItem_Click);
            // 
            // gérerLesBudgetsToolStripMenuItem
            // 
            this.gérerLesBudgetsToolStripMenuItem.Name = "gérerLesBudgetsToolStripMenuItem";
            this.gérerLesBudgetsToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.gérerLesBudgetsToolStripMenuItem.Text = "Gérer les budgets";
            this.gérerLesBudgetsToolStripMenuItem.Click += new System.EventHandler(this.gérerLesBudgetsToolStripMenuItem_Click);
            // 
            // testFicherPersoToolStripMenuItem
            // 
            this.testFicherPersoToolStripMenuItem.Name = "testFicherPersoToolStripMenuItem";
            this.testFicherPersoToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.testFicherPersoToolStripMenuItem.Text = "test ficher perso";
            this.testFicherPersoToolStripMenuItem.Click += new System.EventHandler(this.testFicherPersoToolStripMenuItem_Click);
            // 
            // produitsToolStripMenuItem
            // 
            this.produitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coursToolStripMenuItem});
            this.produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
            this.produitsToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.produitsToolStripMenuItem.Text = "Produits";
            // 
            // coursToolStripMenuItem
            // 
            this.coursToolStripMenuItem.Name = "coursToolStripMenuItem";
            this.coursToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.coursToolStripMenuItem.Text = "Cours";
            this.coursToolStripMenuItem.Click += new System.EventHandler(this.coursToolStripMenuItem_Click);
            // 
            // opérationsToolStripMenuItem
            // 
            this.opérationsToolStripMenuItem.Name = "opérationsToolStripMenuItem";
            this.opérationsToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.opérationsToolStripMenuItem.Text = "Opérations";
            this.opérationsToolStripMenuItem.Click += new System.EventHandler(this.opérationsToolStripMenuItem_Click);
            // 
            // documentsToolStripMenuItem
            // 
            this.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem";
            this.documentsToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.documentsToolStripMenuItem.Text = "Documents";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créationDesTablesToolStripMenuItem,
            this.remplirLesTablesToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.administrationToolStripMenuItem.Text = "Administration";
            this.administrationToolStripMenuItem.Visible = false;
            this.administrationToolStripMenuItem.Click += new System.EventHandler(this.administrationToolStripMenuItem_Click);
            // 
            // créationDesTablesToolStripMenuItem
            // 
            this.créationDesTablesToolStripMenuItem.Name = "créationDesTablesToolStripMenuItem";
            this.créationDesTablesToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.créationDesTablesToolStripMenuItem.Text = "Création des tables";
            this.créationDesTablesToolStripMenuItem.Click += new System.EventHandler(this.créationDesTablesToolStripMenuItem_Click);
            // 
            // remplirLesTablesToolStripMenuItem
            // 
            this.remplirLesTablesToolStripMenuItem.Name = "remplirLesTablesToolStripMenuItem";
            this.remplirLesTablesToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.remplirLesTablesToolStripMenuItem.Text = "Remplir les tables";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Etat_bd";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // salle_de_marché
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "salle_de_marché";
            this.Text = "Salle de marché";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tooldeco;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnePersonneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserLePersonnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesBudgetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opérationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testFicherPersoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem coursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créationDesTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remplirLesTablesToolStripMenuItem;
    }
}

