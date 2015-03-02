using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Stats_Blackjack
{
    public class Carte
    {
        public titre _valeur;
        public type _type;

        public int valeurEnPointage { get { return getValeur(); } }

        public Carte(titre valeur, type type) { _valeur = valeur; _type = type; }
        public Carte(int valeur, int type) { _valeur = (titre)valeur; _type = (type)type; }

        public enum titre
        {
            As, Deux, Trois, Quatre, Cinq, Six, Sept, Huit, Neuf, Dix, Valet, Dame, Roi
        }

        public enum type
        {
            Trèfle, Pique, Coeur, Carreau
        }

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
