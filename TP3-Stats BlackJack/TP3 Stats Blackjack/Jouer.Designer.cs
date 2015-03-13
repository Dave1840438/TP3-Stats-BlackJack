namespace TP3_Stats_Blackjack
{
    partial class Jouer
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jouer));
         this.BTN_J1_Piger = new System.Windows.Forms.Button();
         this.BTN_J2_Piger = new System.Windows.Forms.Button();
         this.BTN_J2_Passer = new System.Windows.Forms.Button();
         this.BTN_J1_Passer = new System.Windows.Forms.Button();
         this.BTN_IA1_Journal = new System.Windows.Forms.Button();
         this.BTN_IA1_Jouer = new System.Windows.Forms.Button();
         this.BTN_IA2_Jouer = new System.Windows.Forms.Button();
         this.BTN_IA2_Journal = new System.Windows.Forms.Button();
         this.GB_Controles_J1 = new System.Windows.Forms.GroupBox();
         this.GB_Controles_J2 = new System.Windows.Forms.GroupBox();
         this.BTN_StopGame = new System.Windows.Forms.Button();
         this.BTN_Restart = new System.Windows.Forms.Button();
         this.BTN_Quit = new System.Windows.Forms.Button();
         this.Main_Joueur2 = new TP3_Stats_Blackjack.UC_Main();
         this.Main_Joueur1 = new TP3_Stats_Blackjack.UC_Main();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.GB_Controles_J1.SuspendLayout();
         this.GB_Controles_J2.SuspendLayout();
         this.SuspendLayout();
         // 
         // BTN_J1_Piger
         // 
         this.BTN_J1_Piger.Location = new System.Drawing.Point(95, 24);
         this.BTN_J1_Piger.Name = "BTN_J1_Piger";
         this.BTN_J1_Piger.Size = new System.Drawing.Size(75, 23);
         this.BTN_J1_Piger.TabIndex = 1;
         this.BTN_J1_Piger.Text = "Piger";
         this.BTN_J1_Piger.UseVisualStyleBackColor = true;
         this.BTN_J1_Piger.Click += new System.EventHandler(this.BTN_J1_Piger_Click);
         // 
         // BTN_J2_Piger
         // 
         this.BTN_J2_Piger.Enabled = false;
         this.BTN_J2_Piger.Location = new System.Drawing.Point(95, 30);
         this.BTN_J2_Piger.Name = "BTN_J2_Piger";
         this.BTN_J2_Piger.Size = new System.Drawing.Size(75, 23);
         this.BTN_J2_Piger.TabIndex = 3;
         this.BTN_J2_Piger.Text = "Piger";
         this.BTN_J2_Piger.UseVisualStyleBackColor = true;
         this.BTN_J2_Piger.Click += new System.EventHandler(this.BTN_J2_Piger_Click);
         // 
         // BTN_J2_Passer
         // 
         this.BTN_J2_Passer.Enabled = false;
         this.BTN_J2_Passer.Location = new System.Drawing.Point(176, 30);
         this.BTN_J2_Passer.Name = "BTN_J2_Passer";
         this.BTN_J2_Passer.Size = new System.Drawing.Size(75, 23);
         this.BTN_J2_Passer.TabIndex = 4;
         this.BTN_J2_Passer.Text = "Passer";
         this.BTN_J2_Passer.UseVisualStyleBackColor = true;
         this.BTN_J2_Passer.Click += new System.EventHandler(this.BTN_J2_Passer_Click);
         // 
         // BTN_J1_Passer
         // 
         this.BTN_J1_Passer.Location = new System.Drawing.Point(176, 24);
         this.BTN_J1_Passer.Name = "BTN_J1_Passer";
         this.BTN_J1_Passer.Size = new System.Drawing.Size(75, 23);
         this.BTN_J1_Passer.TabIndex = 5;
         this.BTN_J1_Passer.Text = "Passer";
         this.BTN_J1_Passer.UseVisualStyleBackColor = true;
         this.BTN_J1_Passer.Click += new System.EventHandler(this.BTN_J1_Passer_Click);
         // 
         // BTN_IA1_Journal
         // 
         this.BTN_IA1_Journal.Location = new System.Drawing.Point(478, 147);
         this.BTN_IA1_Journal.Name = "BTN_IA1_Journal";
         this.BTN_IA1_Journal.Size = new System.Drawing.Size(75, 23);
         this.BTN_IA1_Journal.TabIndex = 6;
         this.BTN_IA1_Journal.Text = "Journal (IA)";
         this.BTN_IA1_Journal.UseVisualStyleBackColor = true;
         this.BTN_IA1_Journal.Click += new System.EventHandler(this.BTN_IA1_Journal_Click);
         // 
         // BTN_IA1_Jouer
         // 
         this.BTN_IA1_Jouer.Location = new System.Drawing.Point(14, 24);
         this.BTN_IA1_Jouer.Name = "BTN_IA1_Jouer";
         this.BTN_IA1_Jouer.Size = new System.Drawing.Size(75, 23);
         this.BTN_IA1_Jouer.TabIndex = 7;
         this.BTN_IA1_Jouer.Text = "Jouer (IA)";
         this.BTN_IA1_Jouer.UseVisualStyleBackColor = true;
         this.BTN_IA1_Jouer.Click += new System.EventHandler(this.BTN_IA1_Jouer_Click);
         // 
         // BTN_IA2_Jouer
         // 
         this.BTN_IA2_Jouer.Enabled = false;
         this.BTN_IA2_Jouer.Location = new System.Drawing.Point(14, 30);
         this.BTN_IA2_Jouer.Name = "BTN_IA2_Jouer";
         this.BTN_IA2_Jouer.Size = new System.Drawing.Size(75, 23);
         this.BTN_IA2_Jouer.TabIndex = 8;
         this.BTN_IA2_Jouer.Text = "Jouer (IA)";
         this.BTN_IA2_Jouer.UseVisualStyleBackColor = true;
         this.BTN_IA2_Jouer.Click += new System.EventHandler(this.BTN_IA2_Jouer_Click);
         // 
         // BTN_IA2_Journal
         // 
         this.BTN_IA2_Journal.Location = new System.Drawing.Point(478, 221);
         this.BTN_IA2_Journal.Name = "BTN_IA2_Journal";
         this.BTN_IA2_Journal.Size = new System.Drawing.Size(75, 23);
         this.BTN_IA2_Journal.TabIndex = 9;
         this.BTN_IA2_Journal.Text = "Journal (IA)";
         this.BTN_IA2_Journal.UseVisualStyleBackColor = true;
         this.BTN_IA2_Journal.Click += new System.EventHandler(this.BTN_IA2_Journal_Click);
         // 
         // GB_Controles_J1
         // 
         this.GB_Controles_J1.Controls.Add(this.BTN_J1_Passer);
         this.GB_Controles_J1.Controls.Add(this.BTN_J1_Piger);
         this.GB_Controles_J1.Controls.Add(this.BTN_IA1_Jouer);
         this.GB_Controles_J1.Location = new System.Drawing.Point(559, 123);
         this.GB_Controles_J1.Name = "GB_Controles_J1";
         this.GB_Controles_J1.Size = new System.Drawing.Size(261, 62);
         this.GB_Controles_J1.TabIndex = 10;
         this.GB_Controles_J1.TabStop = false;
         this.GB_Controles_J1.Text = "Controles Joueur 1";
         // 
         // GB_Controles_J2
         // 
         this.GB_Controles_J2.Controls.Add(this.BTN_IA2_Jouer);
         this.GB_Controles_J2.Controls.Add(this.BTN_J2_Passer);
         this.GB_Controles_J2.Controls.Add(this.BTN_J2_Piger);
         this.GB_Controles_J2.Location = new System.Drawing.Point(559, 191);
         this.GB_Controles_J2.Name = "GB_Controles_J2";
         this.GB_Controles_J2.Size = new System.Drawing.Size(261, 74);
         this.GB_Controles_J2.TabIndex = 11;
         this.GB_Controles_J2.TabStop = false;
         this.GB_Controles_J2.Text = "Controles Joueur 2";
         // 
         // BTN_StopGame
         // 
         this.BTN_StopGame.Location = new System.Drawing.Point(12, 162);
         this.BTN_StopGame.Name = "BTN_StopGame";
         this.BTN_StopGame.Size = new System.Drawing.Size(108, 23);
         this.BTN_StopGame.TabIndex = 12;
         this.BTN_StopGame.Text = "Arreter la partie";
         this.BTN_StopGame.UseVisualStyleBackColor = true;
         this.BTN_StopGame.Click += new System.EventHandler(this.BTN_StopGame_Click);
         // 
         // BTN_Restart
         // 
         this.BTN_Restart.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.BTN_Restart.Location = new System.Drawing.Point(12, 191);
         this.BTN_Restart.Name = "BTN_Restart";
         this.BTN_Restart.Size = new System.Drawing.Size(108, 23);
         this.BTN_Restart.TabIndex = 13;
         this.BTN_Restart.Text = "Rejouer";
         this.BTN_Restart.UseVisualStyleBackColor = true;
         this.BTN_Restart.Visible = false;
         // 
         // BTN_Quit
         // 
         this.BTN_Quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.BTN_Quit.Location = new System.Drawing.Point(12, 221);
         this.BTN_Quit.Name = "BTN_Quit";
         this.BTN_Quit.Size = new System.Drawing.Size(108, 23);
         this.BTN_Quit.TabIndex = 14;
         this.BTN_Quit.Text = "Quitter";
         this.BTN_Quit.UseVisualStyleBackColor = true;
         this.BTN_Quit.Visible = false;
         // 
         // Main_Joueur2
         // 
         this.Main_Joueur2.Location = new System.Drawing.Point(12, 271);
         this.Main_Joueur2.Name = "Main_Joueur2";
         this.Main_Joueur2.Size = new System.Drawing.Size(808, 133);
         this.Main_Joueur2.TabIndex = 2;
         // 
         // Main_Joueur1
         // 
         this.Main_Joueur1.Location = new System.Drawing.Point(12, 12);
         this.Main_Joueur1.Name = "Main_Joueur1";
         this.Main_Joueur1.Size = new System.Drawing.Size(808, 144);
         this.Main_Joueur1.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(240, 151);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(147, 76);
         this.label1.TabIndex = 15;
         this.label1.Text = "LE 21";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(219, 221);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(182, 13);
         this.label2.TabIndex = 16;
         this.label2.Text = "Par David Sylvestre et Patrick Lemay";
         // 
         // Jouer
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.ActiveCaption;
         this.ClientSize = new System.Drawing.Size(837, 400);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.BTN_Quit);
         this.Controls.Add(this.BTN_IA2_Journal);
         this.Controls.Add(this.BTN_IA1_Journal);
         this.Controls.Add(this.BTN_Restart);
         this.Controls.Add(this.BTN_StopGame);
         this.Controls.Add(this.GB_Controles_J2);
         this.Controls.Add(this.GB_Controles_J1);
         this.Controls.Add(this.Main_Joueur2);
         this.Controls.Add(this.Main_Joueur1);
         this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "Jouer";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Much 21";
         this.GB_Controles_J1.ResumeLayout(false);
         this.GB_Controles_J2.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private UC_Main Main_Joueur1;
        private System.Windows.Forms.Button BTN_J1_Piger;
        private UC_Main Main_Joueur2;
        private System.Windows.Forms.Button BTN_J2_Piger;
        private System.Windows.Forms.Button BTN_J2_Passer;
        private System.Windows.Forms.Button BTN_J1_Passer;
        private System.Windows.Forms.Button BTN_IA1_Journal;
        private System.Windows.Forms.Button BTN_IA1_Jouer;
        private System.Windows.Forms.Button BTN_IA2_Jouer;
        private System.Windows.Forms.Button BTN_IA2_Journal;
        private System.Windows.Forms.GroupBox GB_Controles_J1;
        private System.Windows.Forms.GroupBox GB_Controles_J2;
        private System.Windows.Forms.Button BTN_StopGame;
        private System.Windows.Forms.Button BTN_Restart;
        private System.Windows.Forms.Button BTN_Quit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

