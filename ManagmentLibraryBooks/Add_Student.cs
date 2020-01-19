using ManagmentLibraryBooks.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ManagmentLibraryBooks
{
    public partial class Add_Student : Form
    {
        Main_Form Grid;
        public Add_Student(Main_Form gf)
        {
            InitializeComponent();
            this.Grid = gf;
        }


        private void ButtonAddtion2_Click_1(object sender, EventArgs e)
        {
            PictureBox pic = new PictureBox();
            string read = "";
            if (TextBoxName.Text == "" || TextBoxHome.Text == "" || TextBoxPhone.Text == "")
            {
                Dialuge_Add DF = new Dialuge_Add();
                DF.gunaLinePanel1.LineColor = Color.FromArgb(66, 58, 170);
                DF.Title_Label.Text = "اكمل عملية الادخال اولاً";
                Transition.ShowSync(DF);
              //  DF.Show();
            }

            if (ButtonAddtion2.Text == "اضافة")
            {
                pic.Image = PictureBoxStudent.Image;
                if (File.Exists("student.txt"))
                    File.Delete("student.txt");
                if (!Directory.Exists("photo Books"))
                    Directory.CreateDirectory("photo Books");
                else
                {
                    if(!File.Exists("photo Books\\" + TextBoxName.Text + ".png"))
                      PictureBoxStudent.Image.Save("photo Books\\" + TextBoxName.Text + ".png");
                }
                Grid.DataGridStudent.Rows.Add(TextBoxName.Text, TextBoxHome.Text, TextBoxPhone.Text, TextBoxCollage.Text, TextBoxSection.Text, pic.Image);
                for (int x = 0; x < Grid.DataGridStudent.Rows.Count; x++)
                {
                    for (int y = 0; y < Grid.DataGridStudent.ColumnCount - 1; y++)
                    {
                        read += Grid.DataGridStudent.Rows[x].Cells[y].Value.ToString() + ";";
                    }
                    StreamWriter sw = new StreamWriter("student.txt", true);
                    sw.WriteLine(read);
                    read = "";
                    sw.Close();
                }
                Dialuge_Add DF = new Dialuge_Add();
                DF.gunaLinePanel1.LineColor = Color.FromArgb(66, 58, 170);
                DF.Title_Label.Text = "تمت عملية الاضافه بنجاح";
                Transition.ShowSync(DF);
              //  DF.Show();
                this.Close();
            }
            else
            {
                Grid.DataGridStudent.CurrentRow.Cells[0].Value = TextBoxName.Text;
                Grid.DataGridStudent.CurrentRow.Cells[1].Value = TextBoxHome.Text;
                Grid.DataGridStudent.CurrentRow.Cells[2].Value = TextBoxPhone.Text;
                Grid.DataGridStudent.CurrentRow.Cells[3].Value = TextBoxCollage.Text;
                Grid.DataGridStudent.CurrentRow.Cells[4].Value = TextBoxSection.Text;
                Grid.DATAGRID.CurrentRow.Cells[5].Value = PictureBoxStudent;
                if (!File.Exists("photo Books//" + TextBoxName.Text + ".png"))
                    PictureBoxStudent.Image.Save("photo Books//" + TextBoxName.Text + ".png");
                this.Close();
                File.Delete("student.txt");
                for (int x = 0; x < Grid.DataGridStudent.Rows.Count; x++)
                {

                    for (int y = 0; y < Grid.DataGridStudent.ColumnCount - 1; y++)
                        read += Grid.DataGridStudent.Rows[x].Cells[y].Value.ToString() + ";";
                    StreamWriter sw = new StreamWriter("student.txt", true);
                    sw.WriteLine(read);
                    read = "";
                    sw.Close();
                }
                Dialuge_Add DF = new Dialuge_Add();
                DF.gunaLinePanel1.LineColor = Color.FromArgb(66, 58, 170);
                DF.Title_Label.Text = " تمت عملية التعديل بنجاح";
                Transition.ShowSync(DF);
               // DF.Show();
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "أختر الصورة";
            ofd.Filter = "All Image|*.*";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
               PictureBoxStudent.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}

    
