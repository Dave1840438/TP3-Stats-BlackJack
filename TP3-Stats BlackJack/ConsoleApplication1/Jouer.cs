using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PFI2
{
    public partial class Jouer 
    {
        public enum Gagnant { JoueurUn, JoueurDeux, Nulle, Aucun, yboy };

        //Initialisation des variables
        PaquetCartes paquet;
        Joueur joueur1;
        Joueur joueur2;
        public Gagnant gagnant;
        const int objectifPointage = 21;

        public Jouer(){}
        public Gagnant JouerUnePartie(double probailiteUn, double probabiliteDeux)
        {
            paquet = new PaquetCartes();
            joueur1 = new Joueur(probailiteUn, true);
            joueur2 = new Joueur(probabiliteDeux, true);
            gagnant = Gagnant.yboy;

            while (!DetecterFinDePartie())
            {
                if (!joueur1.AFini)
                    IA_Jouer(joueur1);
                if (!joueur2.AFini)
                    IA_Jouer(joueur2);
            }

            return gagnant;
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
            }
            else if (autreJoueur.pointageTotal == objectifPointage)
            {
                IA._maMain.AjouterCarte(paquet.pigerUneCarte());
            }
            else if (IA.pointageTotal <= 10 || IA._maMain.AUnAs && !IA._maMain.depasseAvecLAS)
            {
                IA._maMain.AjouterCarte(paquet.pigerUneCarte());
            }
            //Joue si les probabilités sont bonnes
            else if (IA.pigeUneCarte(paquet.probabiliteDeNePasDepasser(objectifPointage - IA.pointageTotal, IA._compteLesCartes, IA)))
                IA._maMain.AjouterCarte(paquet.pigerUneCarte());
            //Passe son tour
            else
                aPasser = true;

            IA.AFini = aPasser;
            DetecterFinDePartie();
        }

        //Détecte la fin de partie
        public bool DetecterFinDePartie()
        {
            if (joueur1.pointageTotal >= objectifPointage)
                joueur1.AFini = true;

            if (joueur2.pointageTotal >= objectifPointage)
                joueur2.AFini = true;

            if (joueur1.AFini && joueur2.AFini)
            {
                FinDePartie();
                return true;
            }

            return false;
        }

        //Détermine le gagnant et affiche le message correspondant
        public void FinDePartie()
        {
            if (joueur1.pointageTotal > objectifPointage && joueur2.pointageTotal > objectifPointage)
                gagnant = Gagnant.Aucun;
            else if (joueur1.pointageTotal > objectifPointage || joueur2.pointageTotal > objectifPointage)
            {
                if (joueur1.pointageTotal < joueur2.pointageTotal)
                    gagnant = Gagnant.JoueurUn;
                else if (joueur2.pointageTotal < joueur1.pointageTotal)
                    gagnant = Gagnant.JoueurDeux;
            }
            else
            {
                if (joueur1.pointageTotal == joueur2.pointageTotal)
                    gagnant = Gagnant.Nulle;
                else if (joueur1.pointageTotal > joueur2.pointageTotal)
                    gagnant = Gagnant.JoueurUn;
                else
                    gagnant = Gagnant.JoueurDeux;
            }
        }
    }
}
