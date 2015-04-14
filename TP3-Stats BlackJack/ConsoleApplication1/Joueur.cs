using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFI2
{
    public class Joueur
    {
        //Membres de la classe
        public bool _compteLesCartes { get; private set; }
        public bool estUneIA { get; private set;}
        public double _niveauDeRisque;
        public UC_Main _maMain { get; private set; }
        public int pointageTotal { get { return _maMain.RefreshScore(); } }
        public bool AFini { get; set; }


        public Joueur(double niveauDeRisque, bool compteLesCartes)
        {
            _maMain = new UC_Main(); 
            estUneIA = true;
            _niveauDeRisque = niveauDeRisque; 
            _compteLesCartes = compteLesCartes; 
            AFini = false; 
        }


        //Retourne un booléen indiquant si l'IA veut piger une carte
        public bool pigeUneCarte(double possibilitéDeNePasDépasser)
        {
            return possibilitéDeNePasDépasser >= ((double)_niveauDeRisque / 100.0);
        }
    }
}
