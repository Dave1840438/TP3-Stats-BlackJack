using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Stats_Blackjack
{
    public class Joueur
    {
        public enum NiveauDeRisque { Aucun, courageux = 50, moyen = 65, prudent = 80 }

        public bool estUneIA { get; private set;}
        private NiveauDeRisque _niveauDeRisque;
        UC_Main _maMain;
        public int pointageTotal { get { return _maMain.RefreshScore(); } }

        public Joueur(UC_Main maMain) { _maMain = maMain; estUneIA = false; }
        public Joueur(UC_Main maMain, NiveauDeRisque niveauDeRisque) { _maMain = maMain; estUneIA = true; _niveauDeRisque = niveauDeRisque; }

        /// <summary>
        /// Returns a bool saying if the AI wants to draw another card
        /// </summary>
        /// <param name="possibilitéDeDépasser"></param>
        /// <returns></returns>
        public bool pigeUneCarte(double possibilitéDeDépasser)
        {
            return possibilitéDeDépasser <= (double)_niveauDeRisque / 100.0;
        }
    }
}
