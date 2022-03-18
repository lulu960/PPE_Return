
namespace WindowsFormsApp6
{
    partial class Cours
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
            this.Cours_gridview = new System.Windows.Forms.DataGridView();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.Quitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Cours_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Cours_gridview
            // 
            this.Cours_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Cours_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cours_gridview.Location = new System.Drawing.Point(12, 12);
            this.Cours_gridview.Name = "Cours_gridview";
            this.Cours_gridview.Size = new System.Drawing.Size(776, 373);
            this.Cours_gridview.TabIndex = 0;
            this.Cours_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cours_gridview_CellContentClick);
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Refreshbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refreshbtn.Location = new System.Drawing.Point(12, 402);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(164, 36);
            this.Refreshbtn.TabIndex = 1;
            this.Refreshbtn.Text = "Rafraîchir";
            this.Refreshbtn.UseVisualStyleBackColor = false;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // Quitbtn
            // 
            this.Quitbtn.BackColor = System.Drawing.Color.IndianRed;
            this.Quitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitbtn.Location = new System.Drawing.Point(624, 402);
            this.Quitbtn.Name = "Quitbtn";
            this.Quitbtn.Size = new System.Drawing.Size(164, 36);
            this.Quitbtn.TabIndex = 2;
            this.Quitbtn.Text = "Quitter";
            this.Quitbtn.UseVisualStyleBackColor = false;
            this.Quitbtn.Click += new System.EventHandler(this.Quitbtn_Click);
            // 
            // Cours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Quitbtn);
            this.Controls.Add(this.Refreshbtn);
            this.Controls.Add(this.Cours_gridview);
            this.Name = "Cours";
            this.Text = "Cours";
            this.Load += new System.EventHandler(this.Cours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cours_gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Cours_gridview;
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.Button Quitbtn;
    }
}