using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Stats_Blackjack
{
    public class Joueur
    {
        public enum NiveauDeRisque { Aucun, Courageux = 50, Moyen = 65, Prudent = 80 }
        public bool _compteLesCartes { get; private set; }
        public bool estUneIA { get; private set;}
        private NiveauDeRisque _niveauDeRisque;
        public UC_Main _maMain { get; private set; }
        public int pointageTotal { get { return _maMain.RefreshScore(); } }

        public Joueur(UC_Main maMain) { _maMain = maMain; estUneIA = false; }
        public Joueur(UC_Main maMain, NiveauDeRisque niveauDeRisque, bool compteLesCartes) { _maMain = maMain; estUneIA = true; _niveauDeRisque = niveauDeRisque; _compteLesCartes = compteLesCartes; }

        /// <summary>
        /// Returns a bool saying if the AI wants to draw another card
        /// </summary>
        /// <param name="possibilitéDeDépasser"></param>
        /// <returns></returns>
        public bool pigeUneCarte(double possibilitéDeDépasser)
        {
            return possibilitéDeDépasser >= 1.0 - ((double)_niveauDeRisque / 100.0);
        }
    }
}
