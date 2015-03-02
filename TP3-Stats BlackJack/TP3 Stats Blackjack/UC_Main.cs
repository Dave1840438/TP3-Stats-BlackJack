using System;
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
        public static Bitmap imageCartes;
        List<Carte> _cartesEnMain;
        private const int largeurCarte = 73;
        private const int HauteurCarte = 98;
        private int _nbCartesEnMain;
        private int _nbToursPasses;
        private const string messageScore = "Votre score est présentement de : ";
        private const string messageToursPasses = "Tours passés : ";

        public UC_Main()
        {
            InitializeComponent();
            _cartesEnMain = new List<Carte>();
            imageCartes = new Bitmap(Properties.Resources.cartes);
            _nbCartesEnMain = 0;
            RefreshScore();
        }

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
                LBL_Score.Text = messageScore + score1.ToString() + " ou de " + score2.ToString();

                if (score1 > 21 & score2 > 21)
                    resultat = score1 < score2 ? score1 : score2;
                else if (score1 <= 21 & score2 > 21)
                    resultat = score1;
                else resultat = score2;
            }
            else
            {
                resultat = total;
                LBL_Score.Text = messageScore + total.ToString();
            }

            return resultat;
        }

        public void leJoueurPasseSonTour()
        {
            _nbToursPasses++;
            LBL_ToursPasses.Text = messageToursPasses + _nbToursPasses.ToString();
        }
    }
}
