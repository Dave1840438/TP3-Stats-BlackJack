namespace TP3_Stats_Blackjack
{
    partial class ChoixDesJoueurs
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
            this.RB_J1_Joueur = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_J1_IA = new System.Windows.Forms.RadioButton();
            this.GB_J1_Diff = new System.Windows.Forms.GroupBox();
            this.RB_J1_Courageux = new System.Windows.Forms.RadioButton();
            this.RB_J1_Moyen = new System.Windows.Forms.RadioButton();
            this.RB_J1_Prudent = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GB_J2_Diff = new System.Windows.Forms.GroupBox();
            this.RB_J2_Prudent = new System.Windows.Forms.RadioButton();
            this.RB_J2_Moyen = new System.Windows.Forms.RadioButton();
            this.RB_J2_Courageux = new System.Windows.Forms.RadioButton();
            this.RB_J2_IA = new System.Windows.Forms.RadioButton();
            this.RB_J2_Humain = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.GB_J1_Diff.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.GB_J2_Diff.SuspendLayout();
            this.SuspendLayout();
            // 
            // RB_J1_Joueur
            // 
            this.RB_J1_Joueur.AutoSize = true;
            this.RB_J1_Joueur.Checked = true;
            this.RB_J1_Joueur.Location = new System.Drawing.Point(16, 28);
            this.RB_J1_Joueur.Name = "RB_J1_Joueur";
            this.RB_J1_Joueur.Size = new System.Drawing.Size(61, 17);
            this.RB_J1_Joueur.TabIndex = 0;
            this.RB_J1_Joueur.TabStop = true;
            this.RB_J1_Joueur.Text = "Humain";
            this.RB_J1_Joueur.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GB_J1_Diff);
            this.groupBox1.Controls.Add(this.RB_J1_IA);
            this.groupBox1.Controls.Add(this.RB_J1_Joueur);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Joueur 1";
            // 
            // RB_J1_IA
            // 
            this.RB_J1_IA.AutoSize = true;
            this.RB_J1_IA.Location = new System.Drawing.Point(16, 51);
            this.RB_J1_IA.Name = "RB_J1_IA";
            this.RB_J1_IA.Size = new System.Drawing.Size(74, 17);
            this.RB_J1_IA.TabIndex = 1;
            this.RB_J1_IA.Text = "Ordinateur";
            this.RB_J1_IA.UseVisualStyleBackColor = true;
            this.RB_J1_IA.CheckedChanged += new System.EventHandler(this.RB_J1_IA_CheckedChanged);
            // 
            // GB_J1_Diff
            // 
            this.GB_J1_Diff.Controls.Add(this.RB_J1_Prudent);
            this.GB_J1_Diff.Controls.Add(this.RB_J1_Moyen);
            this.GB_J1_Diff.Controls.Add(this.RB_J1_Courageux);
            this.GB_J1_Diff.Location = new System.Drawing.Point(147, 28);
            this.GB_J1_Diff.Name = "GB_J1_Diff";
            this.GB_J1_Diff.Size = new System.Drawing.Size(145, 101);
            this.GB_J1_Diff.TabIndex = 2;
            this.GB_J1_Diff.TabStop = false;
            this.GB_J1_Diff.Text = "groupBox2";
            // 
            // RB_J1_Courageux
            // 
            this.RB_J1_Courageux.AutoSize = true;
            this.RB_J1_Courageux.Checked = true;
            this.RB_J1_Courageux.Enabled = false;
            this.RB_J1_Courageux.Location = new System.Drawing.Point(16, 19);
            this.RB_J1_Courageux.Name = "RB_J1_Courageux";
            this.RB_J1_Courageux.Size = new System.Drawing.Size(76, 17);
            this.RB_J1_Courageux.TabIndex = 0;
            this.RB_J1_Courageux.TabStop = true;
            this.RB_J1_Courageux.Text = "Courageux";
            this.RB_J1_Courageux.UseVisualStyleBackColor = true;
            // 
            // RB_J1_Moyen
            // 
            this.RB_J1_Moyen.AutoSize = true;
            this.RB_J1_Moyen.Enabled = false;
            this.RB_J1_Moyen.Location = new System.Drawing.Point(16, 43);
            this.RB_J1_Moyen.Name = "RB_J1_Moyen";
            this.RB_J1_Moyen.Size = new System.Drawing.Size(57, 17);
            this.RB_J1_Moyen.TabIndex = 1;
            this.RB_J1_Moyen.Text = "Moyen";
            this.RB_J1_Moyen.UseVisualStyleBackColor = true;
            // 
            // RB_J1_Prudent
            // 
            this.RB_J1_Prudent.AutoSize = true;
            this.RB_J1_Prudent.Enabled = false;
            this.RB_J1_Prudent.Location = new System.Drawing.Point(16, 67);
            this.RB_J1_Prudent.Name = "RB_J1_Prudent";
            this.RB_J1_Prudent.Size = new System.Drawing.Size(62, 17);
            this.RB_J1_Prudent.TabIndex = 2;
            this.RB_J1_Prudent.Text = "Prudent";
            this.RB_J1_Prudent.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GB_J2_Diff);
            this.groupBox3.Controls.Add(this.RB_J2_IA);
            this.groupBox3.Controls.Add(this.RB_J2_Humain);
            this.groupBox3.Location = new System.Drawing.Point(12, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 147);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Joueur 1";
            // 
            // GB_J2_Diff
            // 
            this.GB_J2_Diff.Controls.Add(this.RB_J2_Prudent);
            this.GB_J2_Diff.Controls.Add(this.RB_J2_Moyen);
            this.GB_J2_Diff.Controls.Add(this.RB_J2_Courageux);
            this.GB_J2_Diff.Location = new System.Drawing.Point(147, 28);
            this.GB_J2_Diff.Name = "GB_J2_Diff";
            this.GB_J2_Diff.Size = new System.Drawing.Size(145, 101);
            this.GB_J2_Diff.TabIndex = 2;
            this.GB_J2_Diff.TabStop = false;
            this.GB_J2_Diff.Text = "groupBox4";
            // 
            // RB_J2_Prudent
            // 
            this.RB_J2_Prudent.AutoSize = true;
            this.RB_J2_Prudent.Enabled = false;
            this.RB_J2_Prudent.Location = new System.Drawing.Point(16, 67);
            this.RB_J2_Prudent.Name = "RB_J2_Prudent";
            this.RB_J2_Prudent.Size = new System.Drawing.Size(62, 17);
            this.RB_J2_Prudent.TabIndex = 2;
            this.RB_J2_Prudent.Text = "Prudent";
            this.RB_J2_Prudent.UseVisualStyleBackColor = true;
            // 
            // RB_J2_Moyen
            // 
            this.RB_J2_Moyen.AutoSize = true;
            this.RB_J2_Moyen.Enabled = false;
            this.RB_J2_Moyen.Location = new System.Drawing.Point(16, 43);
            this.RB_J2_Moyen.Name = "RB_J2_Moyen";
            this.RB_J2_Moyen.Size = new System.Drawing.Size(57, 17);
            this.RB_J2_Moyen.TabIndex = 1;
            this.RB_J2_Moyen.Text = "Moyen";
            this.RB_J2_Moyen.UseVisualStyleBackColor = true;
            // 
            // RB_J2_Courageux
            // 
            this.RB_J2_Courageux.AutoSize = true;
            this.RB_J2_Courageux.Checked = true;
            this.RB_J2_Courageux.Enabled = false;
            this.RB_J2_Courageux.Location = new System.Drawing.Point(16, 19);
            this.RB_J2_Courageux.Name = "RB_J2_Courageux";
            this.RB_J2_Courageux.Size = new System.Drawing.Size(76, 17);
            this.RB_J2_Courageux.TabIndex = 0;
            this.RB_J2_Courageux.TabStop = true;
            this.RB_J2_Courageux.Text = "Courageux";
            this.RB_J2_Courageux.UseVisualStyleBackColor = true;
            // 
            // RB_J2_IA
            // 
            this.RB_J2_IA.AutoSize = true;
            this.RB_J2_IA.Location = new System.Drawing.Point(16, 51);
            this.RB_J2_IA.Name = "RB_J2_IA";
            this.RB_J2_IA.Size = new System.Drawing.Size(74, 17);
            this.RB_J2_IA.TabIndex = 1;
            this.RB_J2_IA.Text = "Ordinateur";
            this.RB_J2_IA.UseVisualStyleBackColor = true;
            this.RB_J2_IA.CheckedChanged += new System.EventHandler(this.RB_J2_IA_CheckedChanged);
            // 
            // RB_J2_Humain
            // 
            this.RB_J2_Humain.AutoSize = true;
            this.RB_J2_Humain.Checked = true;
            this.RB_J2_Humain.Location = new System.Drawing.Point(16, 28);
            this.RB_J2_Humain.Name = "RB_J2_Humain";
            this.RB_J2_Humain.Size = new System.Drawing.Size(61, 17);
            this.RB_J2_Humain.TabIndex = 0;
            this.RB_J2_Humain.TabStop = true;
            this.RB_J2_Humain.Text = "Humain";
            this.RB_J2_Humain.UseVisualStyleBackColor = true;
            // 
            // ChoixDesJoueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 341);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChoixDesJoueurs";
            this.Text = "Choix des joueurs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GB_J1_Diff.ResumeLayout(false);
            this.GB_J1_Diff.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GB_J2_Diff.ResumeLayout(false);
            this.GB_J2_Diff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RB_J1_Joueur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_J1_IA;
        private System.Windows.Forms.GroupBox GB_J1_Diff;
        private System.Windows.Forms.RadioButton RB_J1_Prudent;
        private System.Windows.Forms.RadioButton RB_J1_Moyen;
        private System.Windows.Forms.RadioButton RB_J1_Courageux;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox GB_J2_Diff;
        private System.Windows.Forms.RadioButton RB_J2_Prudent;
        private System.Windows.Forms.RadioButton RB_J2_Moyen;
        private System.Windows.Forms.RadioButton RB_J2_Courageux;
        private System.Windows.Forms.RadioButton RB_J2_IA;
        private System.Windows.Forms.RadioButton RB_J2_Humain;
    }
}