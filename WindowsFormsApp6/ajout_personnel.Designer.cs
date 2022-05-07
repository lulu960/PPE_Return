
namespace WindowsFormsApp6
{
    partial class ajout_personnel
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimeDebut = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.radioButtonRSP = new System.Windows.Forms.RadioButton();
            this.radioButtonADM = new System.Windows.Forms.RadioButton();
            this.radioButtonTRD = new System.Windows.Forms.RadioButton();
            this.checkBoxNoDate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Location = new System.Drawing.Point(8, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Appliquer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(108, 18);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(469, 22);
            this.textBoxNom.TabIndex = 6;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(108, 60);
            this.textBoxPrenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(469, 22);
            this.textBoxPrenom.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Depuis le :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Jusqu\'au :";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Tomato;
            this.button3.Location = new System.Drawing.Point(441, 231);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "Abandonner";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimeDebut
            // 
            this.dateTimeDebut.Location = new System.Drawing.Point(313, 119);
            this.dateTimeDebut.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeDebut.Name = "dateTimeDebut";
            this.dateTimeDebut.Size = new System.Drawing.Size(265, 22);
            this.dateTimeDebut.TabIndex = 15;
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Location = new System.Drawing.Point(311, 194);
            this.dateTimeFin.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(265, 22);
            this.dateTimeFin.TabIndex = 16;
            this.dateTimeFin.Visible = false;
            this.dateTimeFin.ValueChanged += new System.EventHandler(this.dateTimeFin_ValueChanged);
            // 
            // radioButtonRSP
            // 
            this.radioButtonRSP.AutoSize = true;
            this.radioButtonRSP.Location = new System.Drawing.Point(24, 119);
            this.radioButtonRSP.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonRSP.Name = "radioButtonRSP";
            this.radioButtonRSP.Size = new System.Drawing.Size(124, 21);
            this.radioButtonRSP.TabIndex = 17;
            this.radioButtonRSP.Text = "Responsable ?";
            this.radioButtonRSP.UseVisualStyleBackColor = true;
            this.radioButtonRSP.CheckedChanged += new System.EventHandler(this.radioButtonRSP_CheckedChanged);
            // 
            // radioButtonADM
            // 
            this.radioButtonADM.AutoSize = true;
            this.radioButtonADM.Location = new System.Drawing.Point(24, 148);
            this.radioButtonADM.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonADM.Name = "radioButtonADM";
            this.radioButtonADM.Size = new System.Drawing.Size(132, 21);
            this.radioButtonADM.TabIndex = 18;
            this.radioButtonADM.Text = "Administrateur ?";
            this.radioButtonADM.UseVisualStyleBackColor = true;
            this.radioButtonADM.CheckedChanged += new System.EventHandler(this.radioButtonADM_CheckedChanged);
            // 
            // radioButtonTRD
            // 
            this.radioButtonTRD.AutoSize = true;
            this.radioButtonTRD.Checked = true;
            this.radioButtonTRD.Location = new System.Drawing.Point(24, 176);
            this.radioButtonTRD.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonTRD.Name = "radioButtonTRD";
            this.radioButtonTRD.Size = new System.Drawing.Size(92, 21);
            this.radioButtonTRD.TabIndex = 19;
            this.radioButtonTRD.TabStop = true;
            this.radioButtonTRD.Text = "Tradeur ?";
            this.radioButtonTRD.UseVisualStyleBackColor = true;
            this.radioButtonTRD.CheckedChanged += new System.EventHandler(this.radioButtonTRD_CheckedChanged);
            // 
            // checkBoxNoDate
            // 
            this.checkBoxNoDate.AutoSize = true;
            this.checkBoxNoDate.Checked = true;
            this.checkBoxNoDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNoDate.Location = new System.Drawing.Point(312, 166);
            this.checkBoxNoDate.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxNoDate.Name = "checkBoxNoDate";
            this.checkBoxNoDate.Size = new System.Drawing.Size(110, 21);
            this.checkBoxNoDate.TabIndex = 20;
            this.checkBoxNoDate.Text = "Non Spécifié";
            this.checkBoxNoDate.UseVisualStyleBackColor = true;
            this.checkBoxNoDate.CheckedChanged += new System.EventHandler(this.checkBoxNoDate_CheckedChanged);
            this.checkBoxNoDate.VisibleChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ajout_personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(596, 265);
            this.Controls.Add(this.checkBoxNoDate);
            this.Controls.Add(this.radioButtonTRD);
            this.Controls.Add(this.radioButtonADM);
            this.Controls.Add(this.radioButtonRSP);
            this.Controls.Add(this.dateTimeFin);
            this.Controls.Add(this.dateTimeDebut);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(614, 312);
            this.MinimumSize = new System.Drawing.Size(614, 312);
            this.Name = "ajout_personnel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiche Personnel";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimeDebut;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.RadioButton radioButtonRSP;
        private System.Windows.Forms.RadioButton radioButtonADM;
        private System.Windows.Forms.RadioButton radioButtonTRD;
        private System.Windows.Forms.CheckBox checkBoxNoDate;
    }
}