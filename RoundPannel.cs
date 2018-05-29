using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumbers
{
    public class RoundPannel : Form
    {
        public int margin = 20;
        public int index;
        private int i;

        public RoundPannel(int index)
        {
            this.index = index;
            Panel panel = new Panel();
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Location = new Point(105 + margin * 2 * index, 200);
            panel.Name = "Round" + index.ToString();
            panel.Size = new Size(20, 20);
        }
    }
}