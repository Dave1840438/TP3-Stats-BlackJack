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
            this.GB_Controles_J1.SuspendLayout();
            this.GB_Controles_J2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_J1_Piger
            // 
            this.BTN_J1_Piger.Location = new System.Drawing.Point(533, 19);
            this.BTN_J1_Piger.Name = "BTN_J1_Piger";
            this.BTN_J1_Piger.Size = new System.Drawing.Size(75, 23);
            this.BTN_J1_Piger.TabIndex = 1;
            this.BTN_J1_Piger.Text = "Piger";
            this.BTN_J1_Piger.UseVisualStyleBackColor = true;
            this.BTN_J1_Piger.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_J2_Piger
            // 
            this.BTN_J2_Piger.Enabled = false;
            this.BTN_J2_Piger.Location = new System.Drawing.Point(527, 45);
            this.BTN_J2_Piger.Name = "BTN_J2_Piger";
            this.BTN_J2_Piger.Size = new System.Drawing.Size(75, 23);
            this.BTN_J2_Piger.TabIndex = 3;
            this.BTN_J2_Piger.Text = "Piger";
            this.BTN_J2_Piger.UseVisualStyleBackColor = true;
            this.BTN_J2_Piger.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_J2_Passer
            // 
            this.BTN_J2_Passer.Enabled = false;
            this.BTN_J2_Passer.Location = new System.Drawing.Point(634, 45);
            this.BTN_J2_Passer.Name = "BTN_J2_Passer";
            this.BTN_J2_Passer.Size = new System.Drawing.Size(75, 23);
            this.BTN_J2_Passer.TabIndex = 4;
            this.BTN_J2_Passer.Text = "Passer";
            this.BTN_J2_Passer.UseVisualStyleBackColor = true;
            this.BTN_J2_Passer.Click += new System.EventHandler(this.BTN_J2_Passer_Click);
            // 
            // BTN_J1_Passer
            // 
            this.BTN_J1_Passer.Location = new System.Drawing.Point(640, 19);
            this.BTN_J1_Passer.Name = "BTN_J1_Passer";
            this.BTN_J1_Passer.Size = new System.Drawing.Size(75, 23);
            this.BTN_J1_Passer.TabIndex = 5;
            this.BTN_J1_Passer.Text = "Passer";
            this.BTN_J1_Passer.UseVisualStyleBackColor = true;
            this.BTN_J1_Passer.Click += new System.EventHandler(this.BTN_J1_Passer_Click);
            // 
            // BTN_IA1_Journal
            // 
            this.BTN_IA1_Journal.Location = new System.Drawing.Point(24, 162);
            this.BTN_IA1_Journal.Name = "BTN_IA1_Journal";
            this.BTN_IA1_Journal.Size = new System.Drawing.Size(75, 23);
            this.BTN_IA1_Journal.TabIndex = 6;
            this.BTN_IA1_Journal.Text = "Journal (IA)";
            this.BTN_IA1_Journal.UseVisualStyleBackColor = true;
            this.BTN_IA1_Journal.Click += new System.EventHandler(this.BTN_IA1_Journal_Click);
            // 
            // BTN_IA1_Jouer
            // 
            this.BTN_IA1_Jouer.Location = new System.Drawing.Point(6, 17);
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
            this.BTN_IA2_Jouer.Location = new System.Drawing.Point(6, 45);
            this.BTN_IA2_Jouer.Name = "BTN_IA2_Jouer";
            this.BTN_IA2_Jouer.Size = new System.Drawing.Size(75, 23);
            this.BTN_IA2_Jouer.TabIndex = 8;
            this.BTN_IA2_Jouer.Text = "Jouer (IA)";
            this.BTN_IA2_Jouer.UseVisualStyleBackColor = true;
            this.BTN_IA2_Jouer.Click += new System.EventHandler(this.BTN_IA2_Jouer_Click);
            // 
            // BTN_IA2_Journal
            // 
            this.BTN_IA2_Journal.Location = new System.Drawing.Point(24, 288);
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
            this.GB_Controles_J1.Location = new System.Drawing.Point(105, 145);
            this.GB_Controles_J1.Name = "GB_Controles_J1";
            this.GB_Controles_J1.Size = new System.Drawing.Size(724, 62);
            this.GB_Controles_J1.TabIndex = 10;
            this.GB_Controles_J1.TabStop = false;
            this.GB_Controles_J1.Text = "Controles Joueur 1";
            // 
            // GB_Controles_J2
            // 
            this.GB_Controles_J2.Controls.Add(this.BTN_IA2_Jouer);
            this.GB_Controles_J2.Controls.Add(this.BTN_J2_Passer);
            this.GB_Controles_J2.Controls.Add(this.BTN_J2_Piger);
            this.GB_Controles_J2.Location = new System.Drawing.Point(105, 243);
            this.GB_Controles_J2.Name = "GB_Controles_J2";
            this.GB_Controles_J2.Size = new System.Drawing.Size(715, 74);
            this.GB_Controles_J2.TabIndex = 11;
            this.GB_Controles_J2.TabStop = false;
            this.GB_Controles_J2.Text = "Controles Joueur 2";
            // 
            // BTN_StopGame
            // 
            this.BTN_StopGame.Location = new System.Drawing.Point(104, 214);
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
            this.BTN_Restart.Location = new System.Drawing.Point(218, 214);
            this.BTN_Restart.Name = "BTN_Restart";
            this.BTN_Restart.Size = new System.Drawing.Size(75, 23);
            this.BTN_Restart.TabIndex = 13;
            this.BTN_Restart.Text = "Rejouer";
            this.BTN_Restart.UseVisualStyleBackColor = true;
            this.BTN_Restart.Visible = false;
            // 
            // BTN_Quit
            // 
            this.BTN_Quit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Quit.Location = new System.Drawing.Point(300, 213);
            this.BTN_Quit.Name = "BTN_Quit";
            this.BTN_Quit.Size = new System.Drawing.Size(75, 23);
            this.BTN_Quit.TabIndex = 14;
            this.BTN_Quit.Text = "Quitter";
            this.BTN_Quit.UseVisualStyleBackColor = true;
            this.BTN_Quit.Visible = false;
            // 
            // Main_Joueur2
            // 
            this.Main_Joueur2.Location = new System.Drawing.Point(12, 323);
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
            // Jouer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 488);
            this.Controls.Add(this.BTN_Quit);
            this.Controls.Add(this.BTN_IA2_Journal);
            this.Controls.Add(this.BTN_IA1_Journal);
            this.Controls.Add(this.BTN_Restart);
            this.Controls.Add(this.BTN_StopGame);
            this.Controls.Add(this.GB_Controles_J2);
            this.Controls.Add(this.GB_Controles_J1);
            this.Controls.Add(this.Main_Joueur2);
            this.Controls.Add(this.Main_Joueur1);
            this.Name = "Jouer";
            this.Text = "Form1";
            this.GB_Controles_J1.ResumeLayout(false);
            this.GB_Controles_J2.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

