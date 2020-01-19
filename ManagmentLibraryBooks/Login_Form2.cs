using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagmentLibraryBooks
{
    public partial class Login_Form2 : Form
    {
        string str = "";
        string str2 = "";
        public Login_Form2()
        {
            InitializeComponent();
        }

        private void Login_Form2_Load(object sender, EventArgs e)
        {
        
            Button1.Focus();

        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            

            ////////////////////////
            StreamReader sw = new StreamReader("user.txt");
            string line = "";
           
            bool found = false;
            do
            {
                line = sw.ReadLine();
                if (line != null)
                {
                    string[] lineuser = line.Split(';');
                    if (lineuser[1] == TextBox_User.Text && lineuser[0] == TextBox_Pass.Text)
                    {
                        found = true;
                        str = lineuser[3];
                        str2 = lineuser[2];
                    }
                }
            } while (line != null);
            if (found)
            {
                gunaProgressBar1.Visible = true;
                timer1.Start();          
              
            }
            else
            {
                PL.Dialuge_Add DA = new PL.Dialuge_Add();           
                DA.Title_Label.Text = "عـفواً اسم المستخدم او كلمة السر غير صحيحه";
                DA.ShowDialog();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            gunaProgressBar1.Increment(1);
            label3.Text = "%" + gunaProgressBar1.Value.ToString();

            if (gunaProgressBar1.Value == 100)
            {
                timer1.Stop();

                PL.Main_Form PL = new PL.Main_Form();
                PL.Label_User.Text = str;
                PL.Private.Text = str2;
              
           Transition.ShowSync(PL);
           //    PL.ShowDialog();
                Hide();
               
              


            }
        }
        private void gunaLineTextBox1_Click_1(object sender, EventArgs e)
        {
            TextBox_User.Text = "";
        }

        private void gunaLineTextBox2_Click_1(object sender, EventArgs e)
        {
            TextBox_Pass.PasswordChar = '*';
            TextBox_Pass.Text = "";
           
        }

        private void TextBox_Pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
