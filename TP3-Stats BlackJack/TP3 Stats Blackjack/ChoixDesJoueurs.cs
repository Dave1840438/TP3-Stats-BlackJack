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
        public Joueur.NiveauDeRisque joueur1;
        public Joueur.NiveauDeRisque joueur2;
        public ChoixDesJoueurs()
        {
            InitializeComponent();
            joueur1 = joueur2 = Joueur.NiveauDeRisque.Aucun;
        }

        private void RB_J1_IA_CheckedChanged(object sender, EventArgs e)
        {
            bool status = RB_J1_IA.Checked;

            foreach (Control c in GB_J1_Diff.Controls)
                c.Enabled = status;
        }

        private void RB_J2_IA_CheckedChanged(object sender, EventArgs e)
        {
            bool status = RB_J2_IA.Checked;

            foreach (Control c in GB_J2_Diff.Controls)
                c.Enabled = status;
        }
    }
}
