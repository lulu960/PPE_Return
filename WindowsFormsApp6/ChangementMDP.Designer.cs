﻿
namespace WindowsFormsApp6
{
    partial class ChangementMDP
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
            this.lblNvMDP = new System.Windows.Forms.Label();
            this.lblConfNvMDP = new System.Windows.Forms.Label();
            this.textBoxNvMDP1 = new System.Windows.Forms.TextBox();
            this.textBoxNvMDP2 = new System.Windows.Forms.TextBox();
            this.btnEnregistreNvMDP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNvMDP
            // 
            this.lblNvMDP.AutoSize = true;
            this.lblNvMDP.Location = new System.Drawing.Point(104, 146);
            this.lblNvMDP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNvMDP.Name = "lblNvMDP";
            this.lblNvMDP.Size = new System.Drawing.Size(163, 17);
            this.lblNvMDP.TabIndex = 0;
            this.lblNvMDP.Text = "Changer mot de passe : ";
            // 
            // lblConfNvMDP
            // 
            this.lblConfNvMDP.AutoSize = true;
            this.lblConfNvMDP.Location = new System.Drawing.Point(104, 207);
            this.lblConfNvMDP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfNvMDP.Name = "lblConfNvMDP";
            this.lblConfNvMDP.Size = new System.Drawing.Size(166, 17);
            this.lblConfNvMDP.TabIndex = 1;
            this.lblConfNvMDP.Text = "Confirmer mot de passe :";
            // 
            // textBoxNvMDP1
            // 
            this.textBoxNvMDP1.Location = new System.Drawing.Point(411, 146);
            this.textBoxNvMDP1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNvMDP1.Name = "textBoxNvMDP1";
            this.textBoxNvMDP1.Size = new System.Drawing.Size(377, 22);
            this.textBoxNvMDP1.TabIndex = 2;
            // 
            // textBoxNvMDP2
            // 
            this.textBoxNvMDP2.Location = new System.Drawing.Point(411, 207);
            this.textBoxNvMDP2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNvMDP2.Name = "textBoxNvMDP2";
            this.textBoxNvMDP2.Size = new System.Drawing.Size(377, 22);
            this.textBoxNvMDP2.TabIndex = 3;
            // 
            // btnEnregistreNvMDP
            // 
            this.btnEnregistreNvMDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnEnregistreNvMDP.Location = new System.Drawing.Point(349, 321);
            this.btnEnregistreNvMDP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnregistreNvMDP.Name = "btnEnregistreNvMDP";
            this.btnEnregistreNvMDP.Size = new System.Drawing.Size(313, 129);
            this.btnEnregistreNvMDP.TabIndex = 4;
            this.btnEnregistreNvMDP.Text = "Enregistrer";
            this.btnEnregistreNvMDP.UseVisualStyleBackColor = true;
            this.btnEnregistreNvMDP.Click += new System.EventHandler(this.btnEnregistreNvMDP_Click);
            // 
            // ChangementMDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnEnregistreNvMDP);
            this.Controls.Add(this.textBoxNvMDP2);
            this.Controls.Add(this.textBoxNvMDP1);
            this.Controls.Add(this.lblConfNvMDP);
            this.Controls.Add(this.lblNvMDP);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangementMDP";
            this.Text = "Changement de mot de passe";
            this.Load += new System.EventHandler(this.ChangementMDP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNvMDP;
        private System.Windows.Forms.Label lblConfNvMDP;
        private System.Windows.Forms.TextBox textBoxNvMDP1;
        private System.Windows.Forms.TextBox textBoxNvMDP2;
        private System.Windows.Forms.Button btnEnregistreNvMDP;
    }
}