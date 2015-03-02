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

        public Form1()
        {
            InitializeComponent();

            paquet = new PaquetCartes();
            (new ChoixDesJoueurs()).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Joueur1.AjouterCarte(paquet.pigerUneCarte());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Joueur2.AjouterCarte(paquet.pigerUneCarte());
        }
    }
}
