﻿namespace TP3_Stats_Blackjack
{
    partial class Form1
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
            this.Joueur1 = new TP3_Stats_Blackjack.UC_Main();
            this.Joueur2 = new TP3_Stats_Blackjack.UC_Main();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Piger";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Joueur1
            // 
            this.Joueur1.Location = new System.Drawing.Point(12, 12);
            this.Joueur1.Name = "Joueur1";
            this.Joueur1.Size = new System.Drawing.Size(662, 133);
            this.Joueur1.TabIndex = 0;
            // 
            // Joueur2
            // 
            this.Joueur2.Location = new System.Drawing.Point(12, 361);
            this.Joueur2.Name = "Joueur2";
            this.Joueur2.Size = new System.Drawing.Size(662, 133);
            this.Joueur2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Piger";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 520);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Joueur2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Joueur1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Main Joueur1;
        private System.Windows.Forms.Button button1;
        private UC_Main Joueur2;
        private System.Windows.Forms.Button button2;
    }
}

