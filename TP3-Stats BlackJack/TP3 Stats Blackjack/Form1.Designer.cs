namespace TP3_Stats_Blackjack
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
            this.button2 = new System.Windows.Forms.Button();
            this.Main_Joueur2 = new TP3_Stats_Blackjack.UC_Main();
            this.Main_Joueur1 = new TP3_Stats_Blackjack.UC_Main();
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
            // Main_Joueur2
            // 
            this.Main_Joueur2.Location = new System.Drawing.Point(12, 361);
            this.Main_Joueur2.Name = "Main_Joueur2";
            this.Main_Joueur2.Size = new System.Drawing.Size(808, 133);
            this.Main_Joueur2.TabIndex = 2;
            // 
            // Main_Joueur1
            // 
            this.Main_Joueur1.Location = new System.Drawing.Point(12, 12);
            this.Main_Joueur1.Name = "Main_Joueur1";
            this.Main_Joueur1.Size = new System.Drawing.Size(808, 133);
            this.Main_Joueur1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 520);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Main_Joueur2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Main_Joueur1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Main Main_Joueur1;
        private System.Windows.Forms.Button button1;
        private UC_Main Main_Joueur2;
        private System.Windows.Forms.Button button2;
    }
}

