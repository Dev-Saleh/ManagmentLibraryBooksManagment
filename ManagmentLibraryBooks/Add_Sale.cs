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
    public partial class Add_Sale : Form
    {
        PL.Main_Form Grid;
        public Add_Sale(PL.Main_Form ff)
        {
            InitializeComponent();
            this.Grid = ff;
            if (Grid.DATAGRID.RowCount != 0)
            {
                for (int x = 0; x < Grid.DATAGRID.Rows.Count; x++)
                    Datagridbook.Rows.Add(Grid.DATAGRID.Rows[x].Cells[0].Value);
            }
            if (Grid.DataGridStudent.RowCount != 0)
            {
                for (int x = 0; x < Grid.DataGridStudent.Rows.Count; x++)
                    DatagridName.Rows.Add(Grid.DataGridStudent.Rows[x].Cells[0].Value);
            }
            for (int x = 0; x < Grid.DATAGRID.Rows.Count; x++)
            {
                if (Datagridbook.CurrentRow.Cells[0].Value.ToString() == Grid.DATAGRID.Rows[x].Cells[0].Value.ToString())
                {
                    txtprise.Text = Grid.DATAGRID.Rows[x].Cells[3].Value.ToString();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Sale_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAddtion2_Click(object sender, EventArgs e)
        {
            if (DatagridName.RowCount == 0 || Datagridbook.RowCount == 0)
            {
                Dialuge_Add DF = new Dialuge_Add();
                DF.gunaLinePanel1.LineColor = Color.FromArgb(52, 152, 219);
               DF.Title_Label.Text = "اكمل عملية الادخال اولاً";
                Transition.ShowSync(DF);
              //  DF.Show();
            }

         else 
             {
                if (butok.Text=="اضافة")
                {
                    string Name = DatagridName.CurrentRow.Cells[0].Value.ToString();
                    string book = Datagridbook.CurrentRow.Cells[0].Value.ToString();
                    Grid.DataGridSala.Rows.Add(Name, book, txtprise.Text, txtData.Text);
                    Dialuge_Add DF = new Dialuge_Add();
                    DF.gunaLinePanel1.LineColor = Color.FromArgb(52, 152, 219);
                    DF.Title_Label.Text = "تمت عملية الاضافه بنجاح";
                    Transition.ShowSync(DF);
                    //  DF.Show();
                    this.Close();
                    string read = "";
                    File.Delete("AddSala.txt");
                    for (int x = 0; x < Grid.DataGridSala.Rows.Count; x++)
                    {
                        for (int y = 0; y < Grid.DataGridSala.ColumnCount; y++)
                        {
                            read += Grid.DataGridSala.Rows[x].Cells[y].Value.ToString() + ";";
                        }
                        StreamWriter sw = new StreamWriter("AddSala.txt", true);
                        sw.WriteLine(read);
                        read = "";
                        sw.Close();
                    }
                    
                }
                else
                {
                    Grid.DataGridSala.CurrentRow.Cells[0].Value = DatagridName.CurrentRow.Cells[0].Value.ToString();
                    Grid.DataGridSala.CurrentRow.Cells[1].Value = Datagridbook.CurrentRow.Cells[0].Value.ToString();
                    Grid.DataGridSala.CurrentRow.Cells[2].Value = txtprise.Text;
                    Grid.DataGridSala.CurrentRow.Cells[3].Value = txtData.Value;
                    this.Close();
                    string read = "";
                    File.Delete("AddSala.txt");
                    for (int x = 0; x < Grid.DataGridSala.Rows.Count; x++)
                    {
                        for (int y = 0; y < Grid.DataGridSala.ColumnCount; y++)
                        {
                            read += Grid.DataGridSala.Rows[x].Cells[y].Value.ToString() + ";";
                        }
                        StreamWriter sw = new StreamWriter("AddSala.txt", true);
                        sw.WriteLine(read);
                        read = "";
                        sw.Close();
                    }
                    Dialuge_Add DF = new Dialuge_Add();
                    DF.gunaLinePanel1.LineColor = Color.FromArgb(52, 152, 219);
                    DF.Title_Label.Text = " تمت عملية التعديل بنجاح";
                    Transition.ShowSync(DF);
                    // DF.Show();
                }

           }
   }

        private void Datagridbook_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
      {
            string str = Datagridbook.CurrentRow.Cells[0].Value.ToString();
            for (int x = 0; x < Grid.DATAGRID.Rows.Count; x++)
              {
                 if (Grid.DATAGRID.Rows[x].Cells[0].Value.ToString() == str)
                   {
                       txtprise.Text = Grid.DATAGRID.Rows[x].Cells[3].Value.ToString();
                   }

                 }
       }
    }
 }

