using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFI2
{
    class Program
    {

        public struct range
        {

            public int joueur1;
            public int joueur2;
            public int nulles;

            public void afficher()
            {
                Console.Out.WriteLine(joueur1 + "|" + joueur2 + "|" + nulles);
                if (joueur1 + joueur2 + nulles != 1000)
                    Console.Out.WriteLine("Erreur!!");
            }
        }
        static void Main(string[] args)
        {
            Jouer leJeu = new Jouer();

            List<range> results = new List<range>();
            
            List<double> aiContre = new List<double>();
            aiContre.Add(40);
           // aiContre.Add(60);
           // aiContre.Add(80);

            foreach (double d in aiContre)
            {
                for (double i = 40; i < 80; i++)
                {
                    range resultat = new range();

                    for (double j = 0; j < 1000; j++)
                    {
                        switch (leJeu.JouerUnePartie(i, d))
                        {
                            case Jouer.Gagnant.JoueurUn:
                                resultat.joueur1++;
                                break;
                            case Jouer.Gagnant.JoueurDeux:
                                resultat.joueur2++;
                                break;
                            case Jouer.Gagnant.Nulle:
                                resultat.nulles++;
                                break;
                        }
                    }

                    results.Add(resultat);
                }
            }

            Console.Out.WriteLine("Fin!");
            foreach (range r in results)
                r.afficher();
        }
    }
}
