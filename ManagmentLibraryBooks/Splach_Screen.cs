using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagmentLibraryBooks
{
    public partial class Splach_Screen : Form
    {
        List<Color> colours = new List<Color>();
        public Splach_Screen()
        {
            colours.Add(Color.FromArgb(108, 90, 196));
            colours.Add(Color.FromArgb(180, 92, 189));
            colours.Add(Color.FromArgb(255, 92, 94));
            colours.Add(Color.FromArgb(255, 111, 43));
            colours.Add(Color.FromArgb(0, 139, 255));
            colours.Add(Color.FromArgb(0, 111, 142));
            colours.Add(Color.FromArgb(56, 132, 72));
            colours.Add(Color.FromArgb(255, 212, 34));

            InitializeComponent();
        }
        int countcolor = 0;
        int loop = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            // timer1.Enabled = false;

            this.BackColor = colours[countcolor];
           
            countcolor++;
            if (countcolor == colours.Count)
                countcolor = 0;
        }



        //  timer1.Enabled = true;

    }
}
