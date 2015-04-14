using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFI2
{
   public partial class UC_Main 
   {
      //Les cartes que chaque joueurs ont.
      List<Carte> _cartesEnMain;

      //Combien de carte chaque joueur à en main
      private int _nbCartesEnMain;

      //Strings affichés à l'écran
      private const string messageScore = "Votre score est présentement de : ";
      private const string messageToursPasses = "Tours passés : ";

      //Vrai ou faux si le joueur dépasserai avec un as.
      public bool depasseAvecLAS { get; private set; }

      //Détecte si un joueur à un as dans ses mains.
      public bool AUnAs
      {
         get
         {
            bool resultat = false;
            foreach (Carte c in _cartesEnMain)
               resultat |= c.valeurEnPointage == 11;
            return resultat;
         }
      }

      //Initialise la main du joueur, vide la main et remet le score à zéro.
      public UC_Main()
      {
         _cartesEnMain = new List<Carte>();
         _nbCartesEnMain = 0;
         RefreshScore();
         depasseAvecLAS = false;
      }

      //Ajoute la carte sélectionnée aléatoirement de la pile restant et l'ajoute à la main du joueur qui joue.
      //De plus, la carte est affichée à l'écran dans la main du joueur qui joue.
      public void AjouterCarte(Carte carte)
      {
         _cartesEnMain.Add(carte);
         _nbCartesEnMain++;
         RefreshScore();
      }

      //Recalcul à chaque tour les points des deux joueurs et les affiche à l'écran.
      public int RefreshScore()
      {
         int score1, score2;
         int resultat = 0;
         int nbAs = 0;
         int total = 0;
         int buffer;
         const int differencePointageAs = 10;
         foreach (Carte c in _cartesEnMain)
         {
            buffer = c.valeurEnPointage;
            if (buffer == 11)
               nbAs++;
            total += buffer;
         }
         if (nbAs > 0)
         {
            score1 = (total - (nbAs * differencePointageAs));
            score2 = total;

            if (score1 > 21 && score2 > 21)
               resultat = score1 < score2 ? score1 : score2;
            else if (score1 <= 21 && score2 > 21)
            {
               resultat = score1;
               depasseAvecLAS = true;
            }
            else resultat = score2;
         }
         else
         {
            resultat = total;
         }

         return resultat;
      }
   }
}
