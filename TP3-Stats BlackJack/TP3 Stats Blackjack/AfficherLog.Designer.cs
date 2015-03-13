namespace TP3_Stats_Blackjack
{
    partial class AfficherLog
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
         this.BTN_OK = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // BTN_OK
         // 
         this.BTN_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.BTN_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.BTN_OK.Location = new System.Drawing.Point(917, 236);
         this.BTN_OK.Name = "BTN_OK";
         this.BTN_OK.Size = new System.Drawing.Size(75, 23);
         this.BTN_OK.TabIndex = 0;
         this.BTN_OK.Text = "Ok";
         this.BTN_OK.UseVisualStyleBackColor = true;
         // 
         // AfficherLog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.ActiveCaption;
         this.ClientSize = new System.Drawing.Size(1004, 271);
         this.Controls.Add(this.BTN_OK);
         this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.MaximizeBox = false;
         this.Name = "AfficherLog";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Journal de l\'IA";
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_OK;


    }
}