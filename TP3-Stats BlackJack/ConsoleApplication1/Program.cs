using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFI2
{
   class Program
   {
      //Constantes
      const int nbParties = 1000;
      const int bondIA = 1;

      //Stocke les résultats de chaque IA
      public struct range
      {
         //Variable pour les totaux
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

         //Les trois IA de base
         List<double> aiContre = new List<double>();
         aiContre.Add(50);
         aiContre.Add(65);
         aiContre.Add(80);

         //Pour chaque IA de base
         foreach (double d in aiContre)
         {
            //Les difficultés des IA à tester
            for (double i = 40; i <= 80; i += bondIA)
            {
               range resultat = new range();

               //On joue un certain nombre de parties
               for (double j = 0; j < nbParties; j++)
               {
                  //On stocke le résultat
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
               //Résultat pour un IA
               results.Add(resultat);
            }
            //Pour faire une ligne (-------)
            results.Add(new range());
         }

         //On affiche tous les résultats
         Console.Out.WriteLine("Fin!");
         foreach (range r in results)
            r.afficher();
      }
   }
}
