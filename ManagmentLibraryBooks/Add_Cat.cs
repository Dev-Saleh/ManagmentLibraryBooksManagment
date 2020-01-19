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
namespace ManagmentLibraryBooks.PL
{
    public partial class Add_Cat : Form
    {
        Main_Form Grid;
        public Add_Cat(Main_Form MyGrid)
        {
            InitializeComponent();
            this.Grid = MyGrid;
        
        }
        private void gunaLinePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Cat_Load(object sender, EventArgs e)
        {
            
        }

        private void BTN_ADD_Click_1(object sender, EventArgs e)
        {
            if (TexCAt.Text == "")
            {
                Dialuge_Add DF = new Dialuge_Add();
                DF.gunaLinePanel1.LineColor = Color.FromArgb(0, 150, 136);
                DF.Title_Label.Text = "اكمل عملية الادخال اولاً";
                Transition.ShowSync(DF);
               // DF.Show();
            }
            else
            {

                if (BTN_ADD.Text == "اضافه")
                {
                
                    for (int x = 0; x < Grid.DataGridView2.Rows.Count; x++)
                    {  if (Grid.DataGridView2.Rows[x].Cells[0].Value.ToString() == TexCAt.Text)
                        {
                            Dialuge_Add DFf = new Dialuge_Add();
                            DFf.gunaLinePanel1.LineColor = Color.FromArgb(0, 150, 136);
                            DFf.Title_Label.Text = "اسم الصنف موجود";
                            Transition.ShowSync(DFf);
                           // DFf.Show();
                            return;
                        }
                    }
                    string readitems = "";
                    Random id = new Random();
                    int idd = id.Next(10);
                    Grid.DataGridView2.Rows.Add(TexCAt.Text, idd);
                    if (File.Exists("Add.txt"))
                        File.Delete("Add.txt");
                    for (int x = 0; x < Grid.DataGridView2.Rows.Count; x++)
                    {
                        for (int y = 0; y < Grid.DataGridView2.ColumnCount; y++)
                        {
                            readitems += Grid.DataGridView2.Rows[x].Cells[y].Value.ToString()+";";
                        }
                        StreamWriter sww = new StreamWriter("Add.txt",true);
                        sww.WriteLine(readitems);
                        readitems = "";
                        sww.Close();
                    }
                
                Dialuge_Add DF = new Dialuge_Add();
                    DF.gunaLinePanel1.LineColor = Color.FromArgb(0, 150, 136);
                    DF.Title_Label.Text = "تمت  عملية الاضافه  بنجاح";
                    Transition.ShowSync(DF);
                  //  DF.Show();
                this.Close();
            }
                
                else
                {
                    string read = "";
                    Grid.DataGridView2.CurrentRow.Cells[0].Value = TexCAt.Text;
                    File.Delete("Add.txt");
                    for (int x = 0; x < Grid.DataGridView2.Rows.Count; x++)
                    {

                        for (int y = 0; y < Grid.DataGridView2.ColumnCount; y++)
                        {
                            read += Grid.DataGridView2.Rows[x].Cells[y].Value.ToString() + ";";
                        }
                        StreamWriter sw = new StreamWriter("Add.txt", true);
                        sw.WriteLine(read);
                        read = "";
                        sw.Close();
                    }
                    this.Close();
                    Dialuge_Add DF = new Dialuge_Add();
                    DF.gunaLinePanel1.LineColor = Color.FromArgb(0, 150, 136);
                    DF.Title_Label.Text = "تمت  عملية التعديل  بنجاح";
                    Transition.ShowSync(DF);
                   // DF.Show();
                }

            }
        }
    }
}
