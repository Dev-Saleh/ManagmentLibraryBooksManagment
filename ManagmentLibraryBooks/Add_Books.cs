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
    public partial class Add_Books : Form
    {
        Main_Form Grid;
        public Add_Books(Main_Form MyGrid)
        {
            InitializeComponent();
            this.Grid = MyGrid;
            StreamReader sw = new StreamReader("Add.txt");
            string line = "";
            do
            {
                line = sw.ReadLine();
                if (line != null)
                {
                    string[] str = line.Split(';');
                    comitems.Items.Add(str[0]);
                }
            } while (line != null);
            sw.Close();
        }
         string read = "";
        PictureBox pic = new PictureBox();
        private void Button1_Click_1(object sender, EventArgs e)
        {


            if (txtbookname.Text == "" || txtnamefile.Text == "" || comitems.Text == "" || txtprise.Text == "")
            {
                Dialuge_Add DF = new Dialuge_Add();
                DF.gunaLinePanel1.LineColor = Color.FromArgb(232, 30, 99);
                DF.Title_Label.Text = "اكمل عملية الادخال اولاً";
                Transition.ShowSync(DF);
               // DF.Show();
            }
            else
            {

                if (BunAdd.Text == "اضافة")
                {

                    pic.Image = picbook.Image;
                    if (File.Exists("book.txt"))
                        File.Delete("book.txt");
                    if (!Directory.Exists("photo Books"))
                        Directory.CreateDirectory("photo Books");
                    else picbook.Image.Save("photo Books\\" + txtbookname.Text + ".png");

                    Grid.DATAGRID.Rows.Add(txtbookname.Text, txtnamefile.Text, comitems.Text, txtprise.Text, Data.Value, RatingBooks.Value, pic.Image);
                    for (int x = 0; x < Grid.DATAGRID.Rows.Count; x++)
                    {
                        for (int y = 0; y < Grid.DATAGRID.ColumnCount - 1; y++)
                        {
                            read += Grid.DATAGRID.Rows[x].Cells[y].Value.ToString() + ";";
                        }
                        StreamWriter sw = new StreamWriter("book.txt", true);
                        sw.WriteLine(read);
                        read = "";
                        sw.Close();
                    }
                    Dialuge_Add DF = new Dialuge_Add();
                    DF.gunaLinePanel1.LineColor = Color.FromArgb(232, 30, 99);
                    DF.Title_Label.Text = "تمت عملية الاضافه بنجاح";
                    Transition.ShowSync(DF);
                  //  DF.Show();
                    this.Close();
                }

                else
                {
                    Grid.DATAGRID.CurrentRow.Cells[0].Value = txtbookname.Text;
                    Grid.DATAGRID.CurrentRow.Cells[1].Value = txtnamefile.Text;
                    Grid.DATAGRID.CurrentRow.Cells[2].Value = comitems.Text;
                    Grid.DATAGRID.CurrentRow.Cells[3].Value = txtprise.Text;
                    Grid.DATAGRID.CurrentRow.Cells[4].Value = Data.Value;
                    Grid.DATAGRID.CurrentRow.Cells[5].Value = RatingBooks.Value;
                    Grid.DATAGRID.CurrentRow.Cells[6].Value = picbook.Image;
                    if (!File.Exists("photo Books//" + txtbookname.Text + ".png"))
                    {
                        pic.Image = picbook.Image;
                        pic.Image.Save("photo Books//" + txtbookname.Text + ".png");
                    }
                    this.Close();
                    File.Delete("book.txt");
                    for (int x = 0; x < Grid.DATAGRID.Rows.Count; x++)
                    {

                        for (int y = 0; y < Grid.DATAGRID.ColumnCount - 1; y++)
                        {
                            read += Grid.DATAGRID.Rows[x].Cells[y].Value.ToString() + ";";
                        }
                        StreamWriter sw = new StreamWriter("book.txt", true);
                        sw.WriteLine(read);
                        read = "";
                        sw.Close();
                    }
                    Dialuge_Add DF = new Dialuge_Add();
                    DF.gunaLinePanel1.LineColor = Color.FromArgb(232, 30, 99);
                    DF.Title_Label.Text = " تمت عملية التعديل بنجاح";
                    Transition.ShowSync(DF);
                   // DF.Show();
                }

            }
        } 
        private void Selectphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "أختر الصورة";
            ofd.Filter = "All Image|*.*";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                picbook.Image=Image.FromFile(ofd.FileName);
            }

        }

        private void comitems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Books_Load(object sender, EventArgs e)
        {

        }

        private void txtprise_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
