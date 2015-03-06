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
        //Initialisation des variables
        PaquetCartes paquet;
        Joueur joueur1;
        Joueur joueur2;
        const int objectifPointage = 21;

        public Jouer()
        {
            InitializeComponent();
            //Nouveau paquet de carte
            paquet = new PaquetCartes();

            //On choisi le type des joueurs
            ChoixDesJoueurs dlg = new ChoixDesJoueurs();
            dlg.ShowDialog();

            //On affiche les différents boutons en conséquence
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


        //Le joueur 1 pige une carte
        private void BTN_J1_Piger_Click(object sender, EventArgs e)
        {
            Main_Joueur1.AjouterCarte(paquet.pigerUneCarte());
            TourEstFini();
            DetecterFinDePartie();
        }

        //Le joueur 2 pige une carte
        private void BTN_J2_Piger_Click(object sender, EventArgs e)
        {
            Main_Joueur2.AjouterCarte(paquet.pigerUneCarte());
            TourEstFini();
            DetecterFinDePartie();
        }

        //Le joueur 1 passe son tour
        private void BTN_J1_Passer_Click(object sender, EventArgs e)
        {
            TourEstFini();
            joueur1.AFini = true;
            DetecterFinDePartie();
        }

        //Le joueur 2 passe son tour
        private void BTN_J2_Passer_Click(object sender, EventArgs e)
        {
            TourEstFini();
            joueur2.AFini = true;
            DetecterFinDePartie();
        }

        //La fonction garde les boutons cohérents lors de la fin d'un tour
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

        //Click du bouton qui dit à l'IA 1 de jouer
        private void BTN_IA1_Jouer_Click(object sender, EventArgs e)
        {
            IA_Jouer(joueur1);
        }

        //Click du bouton qui dit à l'IA 2 de jouer
        private void BTN_IA2_Jouer_Click(object sender, EventArgs e)
        {
            IA_Jouer(joueur2);
        }

        //Algorithme de jeu de l'IA
        private void IA_Jouer(Joueur IA)
        {
            bool aPasser = false;
            Joueur autreJoueur = IA == joueur1 ? joueur2 : joueur1; //Trouve l'adversaire

            if (autreJoueur.pointageTotal > objectifPointage)
            {
                aPasser = true;
                IA.AjouterAuLog("Mon adversaire a déja perdu, donc je passe.");
            }
            else if (autreJoueur.pointageTotal == objectifPointage)
            {
                IA._maMain.AjouterCarte(paquet.pigerUneCarte());
                IA.AjouterAuLog("Mon adversaire a 21, donc je pige.");
            }
            else if (IA.pointageTotal <= 10)
            {
                IA._maMain.AjouterCarte(paquet.pigerUneCarte());
                IA.AjouterAuLog("J'ai un pointage 10 ou moins, donc je pige.");
            }
            //Joue si les probabilités sont bonnes
            else if (IA.pigeUneCarte(paquet.probabiliteDeNePasDepasser(objectifPointage - IA.pointageTotal, IA._compteLesCartes, IA)))
                IA._maMain.AjouterCarte(paquet.pigerUneCarte());
            //Passe son tour
            else
                aPasser = true;

            TourEstFini();
            IA.AFini = aPasser;
            DetecterFinDePartie();
        }

        //Détecte la fin de partie
        public void DetecterFinDePartie()
        {
            if (joueur1.pointageTotal >= objectifPointage)
                joueur1.AFini = true;

            if (joueur2.pointageTotal >= objectifPointage)
                joueur2.AFini = true;

            if (joueur1.AFini && joueur2.AFini)
                FinDePartie();
        }

        //Détermine le gagnant et affiche le message correspondant
        public void FinDePartie()
        {
            string messageDeFin = "";

            foreach (Control c in GB_Controles_J1.Controls)
                c.Enabled = false;

            foreach (Control c in GB_Controles_J2.Controls)
                c.Enabled = false;

            BTN_StopGame.Enabled = false;
            BTN_Restart.Visible = true;
            BTN_Quit.Visible = true;
            
            if (joueur1.pointageTotal > objectifPointage && joueur2.pointageTotal > objectifPointage)
                messageDeFin = "Les deux joueurs sont perdants";
            else if (joueur1.pointageTotal == joueur2.pointageTotal)
                messageDeFin = "Partie nulle";
            else if (joueur1.pointageTotal <= objectifPointage || joueur2.pointageTotal <= objectifPointage)
            {
                if (joueur1.pointageTotal < joueur2.pointageTotal)
                    messageDeFin = "Le joueur 1 gagne!";
                else if (joueur2.pointageTotal < joueur1.pointageTotal)
                    messageDeFin = "Le joueur 2 gagne!";

            }

            MessageBox.Show(messageDeFin);
        }

        //Click du bouton pour arrêter le jeu
        private void BTN_StopGame_Click(object sender, EventArgs e)
        {
            FinDePartie();
        }

        //Affiche le journal de l'IA 1
        private void BTN_IA1_Journal_Click(object sender, EventArgs e)
        {
            new AfficherLog(joueur1.log).ShowDialog();
        }

        //Affiche le journal de l'IA 2
        private void BTN_IA2_Journal_Click(object sender, EventArgs e)
        {
            new AfficherLog(joueur2.log).ShowDialog();
        }
    }
}
