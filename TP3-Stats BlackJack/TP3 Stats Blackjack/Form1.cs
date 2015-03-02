using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_Stats_Blackjack
{
    public partial class Form1 : Form
    {
        PaquetCartes paquet;
        Joueur joueur1;
        Joueur joueur2;

        public Form1()
        {
            InitializeComponent();
            paquet = new PaquetCartes();

            ChoixDesJoueurs dlg = new ChoixDesJoueurs();
            dlg.ShowDialog();

            if (dlg.joueur1NVR == Joueur.NiveauDeRisque.Aucun)
                joueur1 = new Joueur(Main_Joueur1);
            else
                joueur1 = new Joueur(Main_Joueur1, dlg.joueur1NVR, dlg.joueur1Compte);

            if (dlg.joueur1NVR == Joueur.NiveauDeRisque.Aucun)
                joueur1 = new Joueur(Main_Joueur2);
            else
                joueur1 = new Joueur(Main_Joueur2, dlg.joueur2NVR, dlg.joueur2Compte);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Main_Joueur1.AjouterCarte(paquet.pigerUneCarte());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main_Joueur2.AjouterCarte(paquet.pigerUneCarte());
        }
    }
}
