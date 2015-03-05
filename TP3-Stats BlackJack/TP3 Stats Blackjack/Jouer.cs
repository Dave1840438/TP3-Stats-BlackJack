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
    public partial class Jouer : Form
    {
        PaquetCartes paquet;
        Joueur joueur1;
        Joueur joueur2;
        const int objectifPointage = 31;

        public Jouer()
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
            DetecterFinDePartie();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main_Joueur2.AjouterCarte(paquet.pigerUneCarte());
            TourEstFini();
            DetecterFinDePartie();
        }

        private void BTN_J1_Passer_Click(object sender, EventArgs e)
        {
            Main_Joueur1.leJoueurPasseSonTour();
            TourEstFini();
            joueur1.AFini = true;
            DetecterFinDePartie();
        }

        private void TourEstFini()
        {
            if (!joueur1.AFini && !joueur2.AFini)
            {
                foreach (Control c in GB_Controles_J1.Controls)
                    c.Enabled = !c.Enabled;

                foreach (Control c in GB_Controles_J2.Controls)
                    c.Enabled = !c.Enabled;
            }
        }

        private void BTN_J2_Passer_Click(object sender, EventArgs e)
        {
            Main_Joueur2.leJoueurPasseSonTour();
            TourEstFini();
            joueur2.AFini = true;
            DetecterFinDePartie();
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
            bool aPasser = false;

            Joueur autreJoueur = IA == joueur1 ? joueur2 : joueur1;

            if (IA.pointageTotal <= 10 )
            {
                IA._maMain.AjouterCarte(paquet.pigerUneCarte());
                IA.AjouterAuLog("J'ai un pointage 10 ou moins, donc je pige.");
            }
            else if (autreJoueur.pointageTotal == objectifPointage && IA.pointageTotal <= objectifPointage)
            {
                IA._maMain.AjouterCarte(paquet.pigerUneCarte());
                IA.AjouterAuLog("Mon adversaire a 21, donc je pige.");
            }
            else if (IA.pigeUneCarte(paquet.probabiliteDeNePasDepasser(objectifPointage - IA.pointageTotal, IA._compteLesCartes, IA)))
                IA._maMain.AjouterCarte(paquet.pigerUneCarte());
            else
            {
                IA._maMain.leJoueurPasseSonTour();
                aPasser = true;
            }
            TourEstFini();
            IA.AFini = aPasser;
            DetecterFinDePartie();
        }

        public void DetecterFinDePartie()
        {
            if (joueur1.pointageTotal >= objectifPointage)
                joueur1.AFini = true;

            if (joueur2.pointageTotal >= objectifPointage)
                joueur2.AFini = true;

            if (joueur1.AFini && joueur2.AFini)
                FinDePartie();
        }

        public void FinDePartie()
        {
            string messageDeFin;

            foreach (Control c in GB_Controles_J1.Controls)
                c.Enabled = false;

            foreach (Control c in GB_Controles_J2.Controls)
                c.Enabled = false;

            BTN_StopGame.Enabled = false;
            BTN_Restart.Visible = true;
            BTN_Quit.Visible = true;

            if (joueur1.pointageTotal <= objectifPointage && joueur2.pointageTotal <= objectifPointage)
            {
                if (joueur1.pointageTotal > joueur2.pointageTotal)
                    messageDeFin = "Le joueur 1 gagne!";
                else if (joueur2.pointageTotal > joueur1.pointageTotal)
                    messageDeFin = "Le joueur 2 gagne!";
                else
                    messageDeFin = "Partie nulle";
            }
            else
                messageDeFin = "Les deux joueurs sont perdrants";

            MessageBox.Show(messageDeFin);
        }

        private void BTN_StopGame_Click(object sender, EventArgs e)
        {
            FinDePartie();
        }

        private void BTN_IA2_Journal_Click(object sender, EventArgs e)
        {
            //joueur2.AfficherLog();
            new AfficherLog(joueur2.log).ShowDialog();
        }

        private void BTN_IA1_Journal_Click(object sender, EventArgs e)
        {
            //joueur1.AfficherLog();
            new AfficherLog(joueur1.log).ShowDialog();
        }
    }
}
