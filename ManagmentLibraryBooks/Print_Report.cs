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
    public partial class Print_Report : Form
    {
        public Print_Report()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap img = new Bitmap(ElipsePanel.Width,ElipsePanel.Height);
            ElipsePanel.DrawToBitmap(img, new Rectangle(Point.Empty, ElipsePanel.Size));
            e.Graphics.DrawImage(img,0,0);
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void Print_Report_Load(object sender, EventArgs e)
        {

        }
    }
}
