using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Stats_Blackjack
{
    public class PaquetCartes
    {
        private const int NB_CARTES = 52;
        private static Random _randomGenerator;
        private List<Carte> _deck = new List<Carte>(NB_CARTES);
        private int _counter;

        public PaquetCartes ()
        {
            if (_randomGenerator == null)
                _randomGenerator = new Random();

            _counter = -1;
            for (int i = 0; i < Enum.GetNames(typeof(Carte.titre)).Length; i++)
            {
                for (int j = 0; j < Enum.GetNames(typeof(Carte.type)).Length; j++)
                {
                    _deck.Add(new Carte(i, j));
                }
            }
            this.shuffle();
        }

        public Carte pigerUneCarte()
        {
            _counter++;
            _counter %= NB_CARTES;
            return _deck[_counter];
        }

        private void shuffle()
        {
            int random = 0;
            Carte buffer;

            for (int i = 0; i < NB_CARTES; i++)
            {
                random = _randomGenerator.Next(NB_CARTES);
                buffer = _deck[i];
                _deck[i] = _deck[random];
                _deck[random] = buffer;
            }
        }

        public double probabiliteDeNePasDepasser(int valeurANePasDepasser, bool compteLesCartes)
        {
            int nbCartesRstantes = compteLesCartes ? NB_CARTES - _counter - 1 : NB_CARTES;
            int nbBonnesCartesRestantes = 0;
            for (int i = _counter + 1; i < NB_CARTES; i++)
            {
                if (_deck[i].valeurEnPointage <= valeurANePasDepasser)
                    nbBonnesCartesRestantes++;
            }
            return (double)nbBonnesCartesRestantes / (double)nbCartesRstantes;
        }
    }
}
