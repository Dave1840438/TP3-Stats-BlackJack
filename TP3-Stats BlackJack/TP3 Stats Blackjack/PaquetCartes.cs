using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Stats_Blackjack
{
    public class PaquetCartes
    {
        private const int _nbCartes = 52;
        private static Random _randomGenerator;
        private List<Carte> _deck = new List<Carte>(_nbCartes);
        private int _counter;

        public PaquetCartes ()
        {
            if (_randomGenerator == null)
                _randomGenerator = new Random();

            _counter = _nbCartes - 1;
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
            _counter %= _nbCartes;
            return _deck[_counter];
        }

        private void shuffle()
        {
            int random = 0;
            Carte buffer;

            for (int i = 0; i < _nbCartes; i++)
            {
                random = _randomGenerator.Next(_nbCartes);
                buffer = _deck[i];
                _deck[i] = _deck[random];
                _deck[random] = buffer;
            }
        }

        public double probabiliteDeNePasDepasser(int valeurANePasDepasser)
        {
            int nbCartesRstantes = _nbCartes - _counter - 1;
            int nbBonnesCartesRestantes = 0;
            for (int i = _counter + 1; i < _nbCartes; i++)
            {
                if (_deck[i].valeurEnPointage <= valeurANePasDepasser)
                    nbBonnesCartesRestantes++;
            }
            return (double)nbBonnesCartesRestantes / (double)nbCartesRstantes;
        }
    }
}
