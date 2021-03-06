﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_Stats_Blackjack
{
   public partial class UC_Main : UserControl
   {
      //Image de toutes les cartes
      public static Bitmap imageCartes;

      //Les cartes que chaque joueurs ont.
      List<Carte> _cartesEnMain;

      //Données des images en pixels d'une carte.
      private const int largeurCarte = 73;
      private const int HauteurCarte = 98;

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
         InitializeComponent();
         _cartesEnMain = new List<Carte>();
         imageCartes = new Bitmap(Properties.Resources.cartes);
         _nbCartesEnMain = 0;
         RefreshScore();
         depasseAvecLAS = false;
      }

      //Ajoute la carte sélectionnée aléatoirement de la pile restant et l'ajoute à la main du joueur qui joue.
      //De plus, la carte est affichée à l'écran dans la main du joueur qui joue.
      public void AjouterCarte(Carte carte)
      {
         _cartesEnMain.Add(carte);
         PictureBox uneCarte = new PictureBox();
         Rectangle cropArea = new Rectangle(largeurCarte * (int)carte._valeur, HauteurCarte * (int)carte._type, largeurCarte, HauteurCarte);
         uneCarte.Image = imageCartes.Clone(cropArea, System.Drawing.Imaging.PixelFormat.DontCare);
         uneCarte.SetBounds(largeurCarte * _nbCartesEnMain, 0, largeurCarte, HauteurCarte);
         PN_MainPanel.Controls.Add(uneCarte);
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
            LBL_Score.Text = messageScore + score1.ToString() + " ou " + score2.ToString();

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
            LBL_Score.Text = messageScore + total.ToString();
         }

         return resultat;
      }
   }
}
