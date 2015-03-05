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
    public partial class AfficherLog : Form
    {
        private const int offset = 23;
        public AfficherLog(List<String> actions)
        {
            InitializeComponent();

            int counter = 0;

            foreach (String s in actions)
            {
                counter++;
                Label indice = new Label();
                indice.AutoSize = true;
                indice.Text = counter.ToString();
                indice.Location = new Point(offset, offset * counter);
                this.Controls.Add(indice);

                Label textAction = new Label();
                textAction.AutoSize = true;
                textAction.Text = s;
                textAction.Location = new Point(offset + offset, offset * counter);
                this.Controls.Add(textAction);
            }
        }
    }
}
