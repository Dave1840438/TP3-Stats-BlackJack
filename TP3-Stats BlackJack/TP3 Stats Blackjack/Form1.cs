using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_Stats_Blackjack
{
    public partial class Form1 : Form
    {
        PaquetCartes paquet;
        Joueur joueur1;
        Joueur joueur2;
        const int objectifPointage = 21;

        public Form1()
        {
            InitializeComponent();
            paquet = new PaquetCartes();

            ChoixDesJoueurs dlg = new ChoixDesJoueurs();
            dlg.ShowDialog();

            if (dlg.joueur1NVR == Joueur.NiveauDeRisque.Aucun)
            {
                joueur1 = new Joueur(Main_Joueur1);
                BTN_IA1_Jouer.Visible = false;
                BTN_IA1_Journal.Visible = false;
            }
            else
            {
                joueur1 = new Joueur(Main_Joueur1, dlg.joueur1NVR, dlg.joueur1Compte);
                BTN_J1_Piger.Visible = false;
                BTN_J1_Passer.Visible = false;
            }

            if (dlg.joueur2NVR == Joueur.NiveauDeRisque.Aucun)
            {
                joueur2 = new Joueur(Main_Joueur2);
                BTN_IA2_Jouer.Visible = false;
                BTN_IA2_Journal.Visible = false;
            }
            else
            {
                joueur2 = new Joueur(Main_Joueur2, dlg.joueur2NVR, dlg.joueur2Compte);
                BTN_J2_Piger.Visible = false;
                BTN_J2_Passer.Visible = false;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Main_Joueur1.AjouterCarte(paquet.pigerUneCarte());
            TourEstFini();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main_Joueur2.AjouterCarte(paquet.pigerUneCarte());
            TourEstFini();
        }

        private void BTN_J1_Passer_Click(object sender, EventArgs e)
        {
            Main_Joueur1.leJoueurPasseSonTour();
            TourEstFini();
        }

        private void TourEstFini()
        {
            foreach (Control c in GB_Controles_J2.Controls)
                c.Enabled = !c.Enabled;

            foreach (Control c in GB_Controles_J1.Controls)
                c.Enabled = !c.Enabled;
        }

        private void BTN_J2_Passer_Click(object sender, EventArgs e)
        {
            Main_Joueur2.leJoueurPasseSonTour();
            TourEstFini();
        }

        private void BTN_IA2_Jouer_Click(object sender, EventArgs e)
        {
            IA_Jouer(joueur2);
        }

        private void BTN_IA1_Jouer_Click(object sender, EventArgs e)
        {
            IA_Jouer(joueur1);
        }

        private void IA_Jouer(Joueur IA)
        {
            if (IA.pigeUneCarte(paquet.probabiliteDeNePasDepasser(objectifPointage - IA.pointageTotal, IA._compteLesCartes)))
                IA._maMain.AjouterCarte(paquet.pigerUneCarte());
            else
                IA._maMain.leJoueurPasseSonTour();
            TourEstFini();
        }
    }
}
