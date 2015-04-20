using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_Stats_Blackjack
{
    public class Joueur
    {
        //Membres de la classe
        public enum NiveauDeRisque { Aucun, Courageux = 50, Moyen = 65, Prudent = 80, Quarante = 40 }
        public bool _compteLesCartes { get; private set; }
        public bool estUneIA { get; private set;}
        public NiveauDeRisque _niveauDeRisque;
        public UC_Main _maMain { get; private set; }
        public int pointageTotal { get { return _maMain.RefreshScore(); } }
        public bool AFini { get; set; }
        public List<String> log { get; private set; }


        //Constructeurs
        public Joueur(UC_Main maMain) { _maMain = maMain; estUneIA = false; AFini = false; log = new List<string>(); }
        public Joueur(UC_Main maMain, NiveauDeRisque niveauDeRisque, bool compteLesCartes) { _maMain = maMain; estUneIA = true; _niveauDeRisque = niveauDeRisque; _compteLesCartes = compteLesCartes; AFini = false; log = new List<string>(); }


        //Retourne un booléen indiquant si l'IA veut piger une carte
        public bool pigeUneCarte(double possibilitéDeNePasDépasser)
        {
            return possibilitéDeNePasDépasser >= ((double)_niveauDeRisque / 100.0);
        }

        //La méthode écrit un message décrivant la pensée de l'IA
        public void AjouterAuLog(int nbBonnesCartes, double possibilitéDeNePasDépasser, int nbCartes)
        {
            string message = "J'ai un score de " + _maMain.RefreshScore() + ". ";
            message += "Je pige si j'ai " + ((int)_niveauDeRisque).ToString() + "% de chance de ne pas dépasser, ";
            message += "il y a présentement " + nbBonnesCartes.ToString() + " bonnes cartes sur " + nbCartes.ToString();
            message += ", les chances de ne pas dépasser sont évaluées à " + ((int)(possibilitéDeNePasDépasser * 100)).ToString() + "%";

            if ((double)_niveauDeRisque / 100 < possibilitéDeNePasDépasser)
                message += ", donc je pige une carte.";
            else
                message += ", donc je passe mon tour.";

            log.Add(message);
        }

        //Ajoute le messaage envoyé directement au journal
        public void AjouterAuLog(String message)
        {
            log.Add(message);
        }
    }
}
