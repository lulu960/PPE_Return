
namespace WindowsFormsApp6
{
    partial class Opérations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgTitre = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcoutport = new System.Windows.Forms.Label();
            this.lbl_budget_total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgOperation = new System.Windows.Forms.DataGridView();
            this.lbl_valeur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTitre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOperation)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgTitre
            // 
            this.dtgTitre.AllowUserToAddRows = false;
            this.dtgTitre.AllowUserToDeleteRows = false;
            this.dtgTitre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTitre.Location = new System.Drawing.Point(600, 55);
            this.dtgTitre.Name = "dtgTitre";
            this.dtgTitre.ReadOnly = true;
            this.dtgTitre.RowHeadersWidth = 51;
            this.dtgTitre.RowTemplate.Height = 24;
            this.dtgTitre.Size = new System.Drawing.Size(584, 313);
            this.dtgTitre.TabIndex = 1;
            this.dtgTitre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dtgTitre.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTitre_CellDoubleClick);
            this.dtgTitre.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgTitre_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Opérations";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(875, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Coût du portefeuille :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Budget Total :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblcoutport
            // 
            this.lblcoutport.AutoSize = true;
            this.lblcoutport.Location = new System.Drawing.Point(306, 386);
            this.lblcoutport.Name = "lblcoutport";
            this.lblcoutport.Size = new System.Drawing.Size(17, 17);
            this.lblcoutport.TabIndex = 6;
            this.lblcoutport.Text = "0";
            this.lblcoutport.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_budget_total
            // 
            this.lbl_budget_total.AutoSize = true;
            this.lbl_budget_total.Location = new System.Drawing.Point(108, 442);
            this.lbl_budget_total.Name = "lbl_budget_total";
            this.lbl_budget_total.Size = new System.Drawing.Size(17, 17);
            this.lbl_budget_total.TabIndex = 7;
            this.lbl_budget_total.Text = "0";
            this.lbl_budget_total.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(750, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Valeur du portefeuille :";
            // 
            // dtgOperation
            // 
            this.dtgOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOperation.Location = new System.Drawing.Point(3, 55);
            this.dtgOperation.Name = "dtgOperation";
            this.dtgOperation.RowHeadersWidth = 51;
            this.dtgOperation.RowTemplate.Height = 24;
            this.dtgOperation.Size = new System.Drawing.Size(577, 313);
            this.dtgOperation.TabIndex = 0;
            this.dtgOperation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dtgOperation.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgOperation_CellMouseDoubleClick);
            this.dtgOperation.BindingContextChanged += new System.EventHandler(this.dtgOperation_BindingContextChanged);
            // 
            // lbl_valeur
            // 
            this.lbl_valeur.AutoSize = true;
            this.lbl_valeur.Location = new System.Drawing.Point(931, 386);
            this.lbl_valeur.Name = "lbl_valeur";
            this.lbl_valeur.Size = new System.Drawing.Size(17, 17);
            this.lbl_valeur.TabIndex = 13;
            this.lbl_valeur.Text = "0";
            // 
            // Opérations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 468);
            this.Controls.Add(this.lbl_valeur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_budget_total);
            this.Controls.Add(this.lblcoutport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgTitre);
            this.Controls.Add(this.dtgOperation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Opérations";
            this.Text = "Opérations";
            this.Load += new System.EventHandler(this.Opérations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTitre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOperation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgTitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcoutport;
        private System.Windows.Forms.Label lbl_budget_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgOperation;
        private System.Windows.Forms.Label lbl_valeur;
    }
}