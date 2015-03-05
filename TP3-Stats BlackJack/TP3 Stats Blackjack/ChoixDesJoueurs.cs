using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_Stats_Blackjack
{

    public partial class ChoixDesJoueurs : Form
    {
        public Joueur.NiveauDeRisque joueur1NVR;
        public Joueur.NiveauDeRisque joueur2NVR;
        public bool joueur1Compte;
        public bool joueur2Compte;

        public ChoixDesJoueurs()
        {
            InitializeComponent();
            joueur1NVR = joueur2NVR = Joueur.NiveauDeRisque.Aucun;
        }

        private void RB_J1_IA_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control c in GB_J1_Diff.Controls)
                c.Enabled = RB_J1_IA.Checked;
        }

        private void RB_J2_IA_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control c in GB_J2_Diff.Controls)
                c.Enabled = RB_J2_IA.Checked;
        }

        private void BTN_Demarrer_Click(object sender, EventArgs e)
        {
            if (RB_J1_IA.Checked)
            {
                joueur1NVR = (Joueur.NiveauDeRisque)Enum.Parse(typeof(Joueur.NiveauDeRisque), GB_J1_Diff.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked).Text);
                joueur1Compte = CHBX_J1_Compte.Checked;
            }


            if (RB_J2_IA.Checked)
            {
                joueur2NVR = (Joueur.NiveauDeRisque)Enum.Parse(typeof(Joueur.NiveauDeRisque), GB_J2_Diff.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked).Text);
                joueur2Compte = CHBX_J2_Compte.Checked;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
