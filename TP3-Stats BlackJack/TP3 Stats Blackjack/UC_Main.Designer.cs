namespace TP3_Stats_Blackjack
{
    partial class UC_Main
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PN_MainPanel = new System.Windows.Forms.Panel();
            this.LBL_Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PN_MainPanel
            // 
            this.PN_MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PN_MainPanel.Location = new System.Drawing.Point(0, 0);
            this.PN_MainPanel.Name = "PN_MainPanel";
            this.PN_MainPanel.Size = new System.Drawing.Size(808, 102);
            this.PN_MainPanel.TabIndex = 0;
            // 
            // LBL_Score
            // 
            this.LBL_Score.AutoSize = true;
            this.LBL_Score.Location = new System.Drawing.Point(3, 105);
            this.LBL_Score.Name = "LBL_Score";
            this.LBL_Score.Size = new System.Drawing.Size(83, 13);
            this.LBL_Score.TabIndex = 0;
            this.LBL_Score.Text = "Label de score :";
            // 
            // UC_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LBL_Score);
            this.Controls.Add(this.PN_MainPanel);
            this.Name = "UC_Main";
            this.Size = new System.Drawing.Size(808, 131);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PN_MainPanel;
        private System.Windows.Forms.Label LBL_Score;
    }
}
