﻿namespace TP3_Stats_Blackjack
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
         this.GB_J1_Diff = new System.Windows.Forms.GroupBox();
         this.CHBX_J1_Compte = new System.Windows.Forms.CheckBox();
         this.RB_J1_Prudent = new System.Windows.Forms.RadioButton();
         this.RB_J1_Moyen = new System.Windows.Forms.RadioButton();
         this.RB_J1_Courageux = new System.Windows.Forms.RadioButton();
         this.RB_J1_IA = new System.Windows.Forms.RadioButton();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.GB_J2_Diff = new System.Windows.Forms.GroupBox();
         this.CHBX_J2_Compte = new System.Windows.Forms.CheckBox();
         this.RB_J2_Prudent = new System.Windows.Forms.RadioButton();
         this.RB_J2_Moyen = new System.Windows.Forms.RadioButton();
         this.RB_J2_Courageux = new System.Windows.Forms.RadioButton();
         this.RB_J2_IA = new System.Windows.Forms.RadioButton();
         this.RB_J2_Humain = new System.Windows.Forms.RadioButton();
         this.BTN_Demarrer = new System.Windows.Forms.Button();
         this.radioButton1 = new System.Windows.Forms.RadioButton();
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
         // GB_J1_Diff
         // 
         this.GB_J1_Diff.Controls.Add(this.CHBX_J1_Compte);
         this.GB_J1_Diff.Controls.Add(this.RB_J1_Prudent);
         this.GB_J1_Diff.Controls.Add(this.RB_J1_Moyen);
         this.GB_J1_Diff.Controls.Add(this.RB_J1_Courageux);
         this.GB_J1_Diff.Location = new System.Drawing.Point(147, 28);
         this.GB_J1_Diff.Name = "GB_J1_Diff";
         this.GB_J1_Diff.Size = new System.Drawing.Size(145, 123);
         this.GB_J1_Diff.TabIndex = 2;
         this.GB_J1_Diff.TabStop = false;
         this.GB_J1_Diff.Text = "Paramètres";
         // 
         // CHBX_J1_Compte
         // 
         this.CHBX_J1_Compte.AutoSize = true;
         this.CHBX_J1_Compte.Enabled = false;
         this.CHBX_J1_Compte.Location = new System.Drawing.Point(16, 91);
         this.CHBX_J1_Compte.Name = "CHBX_J1_Compte";
         this.CHBX_J1_Compte.Size = new System.Drawing.Size(126, 17);
         this.CHBX_J1_Compte.TabIndex = 3;
         this.CHBX_J1_Compte.Text = "Comptage des cartes";
         this.CHBX_J1_Compte.UseVisualStyleBackColor = true;
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
         // groupBox3
         // 
         this.groupBox3.Controls.Add(this.GB_J2_Diff);
         this.groupBox3.Controls.Add(this.RB_J2_IA);
         this.groupBox3.Controls.Add(this.RB_J2_Humain);
         this.groupBox3.Location = new System.Drawing.Point(12, 185);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(319, 199);
         this.groupBox3.TabIndex = 2;
         this.groupBox3.TabStop = false;
         this.groupBox3.Text = "Joueur 1";
         // 
         // GB_J2_Diff
         // 
         this.GB_J2_Diff.Controls.Add(this.radioButton1);
         this.GB_J2_Diff.Controls.Add(this.CHBX_J2_Compte);
         this.GB_J2_Diff.Controls.Add(this.RB_J2_Prudent);
         this.GB_J2_Diff.Controls.Add(this.RB_J2_Moyen);
         this.GB_J2_Diff.Controls.Add(this.RB_J2_Courageux);
         this.GB_J2_Diff.Location = new System.Drawing.Point(147, 28);
         this.GB_J2_Diff.Name = "GB_J2_Diff";
         this.GB_J2_Diff.Size = new System.Drawing.Size(145, 146);
         this.GB_J2_Diff.TabIndex = 2;
         this.GB_J2_Diff.TabStop = false;
         this.GB_J2_Diff.Text = "Paramètres";
         // 
         // CHBX_J2_Compte
         // 
         this.CHBX_J2_Compte.AutoSize = true;
         this.CHBX_J2_Compte.Enabled = false;
         this.CHBX_J2_Compte.Location = new System.Drawing.Point(16, 90);
         this.CHBX_J2_Compte.Name = "CHBX_J2_Compte";
         this.CHBX_J2_Compte.Size = new System.Drawing.Size(126, 17);
         this.CHBX_J2_Compte.TabIndex = 3;
         this.CHBX_J2_Compte.Text = "Comptage des cartes";
         this.CHBX_J2_Compte.UseVisualStyleBackColor = true;
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
         // BTN_Demarrer
         // 
         this.BTN_Demarrer.Location = new System.Drawing.Point(217, 390);
         this.BTN_Demarrer.Name = "BTN_Demarrer";
         this.BTN_Demarrer.Size = new System.Drawing.Size(111, 23);
         this.BTN_Demarrer.TabIndex = 3;
         this.BTN_Demarrer.Text = "Démarrer la partie";
         this.BTN_Demarrer.UseVisualStyleBackColor = true;
         this.BTN_Demarrer.Click += new System.EventHandler(this.BTN_Demarrer_Click);
         // 
         // radioButton1
         // 
         this.radioButton1.AutoSize = true;
         this.radioButton1.Enabled = false;
         this.radioButton1.Location = new System.Drawing.Point(16, 114);
         this.radioButton1.Name = "radioButton1";
         this.radioButton1.Size = new System.Drawing.Size(69, 17);
         this.radioButton1.TabIndex = 4;
         this.radioButton1.TabStop = true;
         this.radioButton1.Text = "Quarante";
         this.radioButton1.UseVisualStyleBackColor = true;
         // 
         // ChoixDesJoueurs
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.ActiveCaption;
         this.ClientSize = new System.Drawing.Size(340, 425);
         this.Controls.Add(this.BTN_Demarrer);
         this.Controls.Add(this.groupBox3);
         this.Controls.Add(this.groupBox1);
         this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.MaximizeBox = false;
         this.Name = "ChoixDesJoueurs";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.CheckBox CHBX_J1_Compte;
        private System.Windows.Forms.CheckBox CHBX_J2_Compte;
        private System.Windows.Forms.Button BTN_Demarrer;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}