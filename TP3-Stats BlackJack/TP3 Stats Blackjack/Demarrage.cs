using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_Stats_Blackjack
{
    public partial class Demarrage : Form
    {
        public Demarrage()
        {
            InitializeComponent();
        }

        //Permet de boucler le jeu pour rejouer
        private void Demarrage_Load(object sender, EventArgs e)
        {
            while (new Jouer().ShowDialog() == DialogResult.OK);
            this.Close();
        }
    }
}
