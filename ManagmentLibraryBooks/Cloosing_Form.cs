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
    public partial class Cloosing_Form : Form
    {
        public Cloosing_Form()
        {
            InitializeComponent();
        }

        private void Cloosing_Form_Load(object sender, EventArgs e)
        {

        }


        private void NO_Click(object sender, EventArgs e)
        {
           
        }

        private void YES_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
