
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Quitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Cours_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Cours_gridview
            // 
            this.Cours_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cours_gridview.Location = new System.Drawing.Point(12, 12);
            this.Cours_gridview.Name = "Cours_gridview";
            this.Cours_gridview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Cours_gridview.Size = new System.Drawing.Size(776, 371);
            this.Cours_gridview.TabIndex = 0;
            this.Cours_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(12, 400);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(174, 33);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Rafraîchir";
<<<<<<< HEAD
            this.btnRefresh.UseVisualStyleBackColor = false;
=======
            this.btnRefresh.UseVisualStyleBackColor = true;
>>>>>>> e7c87de541f073e882e3446375944d7353a57412
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Quitbtn
            // 
            this.Quitbtn.BackColor = System.Drawing.Color.IndianRed;
            this.Quitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitbtn.Location = new System.Drawing.Point(614, 400);
            this.Quitbtn.Name = "Quitbtn";
            this.Quitbtn.Size = new System.Drawing.Size(174, 33);
            this.Quitbtn.TabIndex = 2;
            this.Quitbtn.Text = "Quitter";
            this.Quitbtn.UseVisualStyleBackColor = false;
            // 
            // Cours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Quitbtn);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.Cours_gridview);
            this.Name = "Cours";
            this.Text = "Cours";
            ((System.ComponentModel.ISupportInitialize)(this.Cours_gridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Cours_gridview;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button Quitbtn;
    }
}