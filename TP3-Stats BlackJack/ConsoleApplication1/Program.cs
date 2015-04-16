using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFI2
{
    class Program
    {
        const int nbParties = 100000;
        const int bondIA = 1;


        public struct range
        {

            public int joueur1;
            public int joueur2;
            public int nulles;

            public void afficher()
            {
                if (joueur1 + joueur2 + nulles != nbParties)
                    Console.Out.WriteLine("-----------------------------------------");
                else
                    Console.Out.WriteLine(joueur1 + "|" + joueur2 + "|" + nulles);
            }
        }
        static void Main(string[] args)
        {
            Jouer leJeu = new Jouer();

            List<range> results = new List<range>();

            List<double> aiContre = new List<double>();
            aiContre.Add(50);
            aiContre.Add(65);
            aiContre.Add(80);

            foreach (double d in aiContre)
            {
                for (double i = 40; i <= 80; i += bondIA)
                {
                    range resultat = new range();

                    for (double j = 0; j < nbParties; j++)
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
                results.Add(new range());
            }

            Console.Out.WriteLine("Fin!");
            foreach (range r in results)
                r.afficher();
        }
    }
}
