using ManagmentLibraryBooks.PL;
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
    public partial class Add_User : Form
    {
        PL.Main_Form Grid;
        public Add_User(PL.Main_Form ff)
        {
            InitializeComponent();
            this.Grid = ff;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                PictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void Add_User_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString();
        }

        private void ButtonAddtion2_Click(object sender, EventArgs e)
        {
            if (txtnamestudent.Text == "" || nameuser.Text == "" || txtpassword.Text == "" || gunaComboBox1.Text == "")
            {
                Dialuge_Add DF = new Dialuge_Add();
                DF.Title_Label.Text = "اكمل عملية الادخال اولاً";
                Transition.ShowSync(DF);
                //DF.Show();
            }
           if (ButtonAddtion2.Text == "اضـافـة")
             {
                    string read = "";
                    if (File.Exists("user.txt"))
                        File.Delete("user.txt");
                    if (gunaComboBox1.Text== "مدير")
                        PictureBox.Image = Properties.Resources.Manager;
                    else
                        PictureBox.Image = Properties.Resources.User;
                    Grid.gunaDataGridView2.Rows.Add(txtpassword.Text, nameuser.Text, txtnamestudent.Text, gunaComboBox1.Text,PictureBox.Image);
                    for (int x = 0; x < Grid.gunaDataGridView2.Rows.Count; x++)
                    {
                        for (int y = 0; y < Grid.gunaDataGridView2.ColumnCount - 1; y++)
                        {
                            read += Grid.gunaDataGridView2.Rows[x].Cells[y].Value.ToString() + ";";
                        }
                        StreamWriter sw = new StreamWriter("user.txt", true);
                        sw.WriteLine(read);
                        read = "";
                        sw.Close();
                    }
                    Dialuge_Add DF = new Dialuge_Add();
                    DF.Title_Label.Text = "تمت عملية الاضافه بنجاح";
                    Transition.ShowSync(DF);
                    this.Close();
                    //   DF.Show();
                }
                else 
                {
                    Grid.gunaDataGridView2.CurrentRow.Cells[0].Value = txtpassword.Text;
                    Grid.gunaDataGridView2.CurrentRow.Cells[1].Value = nameuser.Text;
                    Grid.gunaDataGridView2.CurrentRow.Cells[2].Value = txtnamestudent.Text;
                    Grid.gunaDataGridView2.CurrentRow.Cells[3].Value = gunaComboBox1.Text;
                    if (gunaComboBox1.Text == "مدير")
                        PictureBox.Image = Properties.Resources.Manager;
                    else
                        PictureBox.Image = Properties.Resources.User;
                    this.Close();
                    File.Delete("user.txt");
                    string read = "";
                    for (int x = 0; x < Grid.gunaDataGridView2.Rows.Count; x++)
                    {
                        for (int y = 0; y < Grid.gunaDataGridView2.ColumnCount - 1; y++)
                        {
                            read += Grid.gunaDataGridView2.Rows[x].Cells[y].Value.ToString() + ";";
                        }
                        StreamWriter sw = new StreamWriter("user.txt", true);
                        sw.WriteLine(read);
                        read = "";
                        sw.Close();
                    }

                    Dialuge_Add DF = new Dialuge_Add();
                    DF.gunaLinePanel1.LineColor = Color.FromArgb(66, 58, 170);
                    DF.Title_Label.Text = " تمت عملية التعديل بنجاح";
                    Transition.ShowSync(DF);
                    //   // DF.Show();
            }
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "أختر الصورة";
            ofd.Filter = "All Image|*.*";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                PictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gunaComboBox1.SelectedItem.ToString()== "مدير")
                PictureBox.Image = Properties.Resources.Manager;
            else
                PictureBox.Image = Properties.Resources.User;
        }
    }
}
