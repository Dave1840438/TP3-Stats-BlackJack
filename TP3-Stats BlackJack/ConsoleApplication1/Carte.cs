using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFI2
{
    public class Carte
    {
        //Membres
        public titre _valeur;
        public type _type;

        public int valeurEnPointage { get { return getValeur(); } }

        //Construit la carte à partir d'entiers
        public Carte(int valeur, int type) { _valeur = (titre)valeur; _type = (type)type; }

        //Le titre de la carte
        public enum titre
        {
            As, Deux, Trois, Quatre, Cinq, Six, Sept, Huit, Neuf, Dix, Valet, Dame, Roi
        }

        //Le type de la carte
        public enum type
        {
            Trèfle, Pique, Coeur, Carreau
        }

        //Retourne la valeur de la carte
        private int getValeur()
        {
            const int valeurFigures = 10;
            const int valeurAs = 11;
            int resultat;
            switch (_valeur)
            {
                case titre.Valet:
                case titre.Dame:
                case titre.Roi:
                    resultat = valeurFigures;
                    break;

                case titre.As:
                    resultat = valeurAs;
                    break;

                default:
                    resultat = (int)_valeur + 1;
                    break;
            }
            return resultat;
        }
    }
}
