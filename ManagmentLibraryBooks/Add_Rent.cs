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
    public partial class Add_Rent :Form
    {
        PL.Main_Form Grid;
        public Add_Rent(PL.Main_Form gg)
        {
            InitializeComponent();
            this.Grid = gg;
            if (Grid.DATAGRID.RowCount != 0)
            {
                for (int x = 0; x < Grid.DATAGRID.Rows.Count; x++)
                   DatagridBook.Rows.Add(Grid.DATAGRID.Rows[x].Cells[0].Value);
            }
            if (Grid.DataGridStudent.RowCount != 0)
            {
                for (int x = 0; x < Grid.DataGridStudent.Rows.Count; x++)
                    DatagriadName1.Rows.Add(Grid.DataGridStudent.Rows[x].Cells[0].Value);
            }
        }

        private void Add_Rent_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAddtion2_Click(object sender, EventArgs e)
        {
            if (DatagriadName1.RowCount == 0 || DatagridBook.RowCount == 0)
            {
                Dialuge_Add DF = new Dialuge_Add();
                DF.gunaLinePanel1.LineColor = Color.FromArgb(236, 122, 48);
                DF.Title_Label.Text = "اكمل عمليات الادخال اولاً ";
                Transition.ShowSync(DF);
               // DF.Show();
            }

            else
            {
                if (butAddRent.Text== "اضافه")
                {
                    string Name = DatagriadName1.CurrentRow.Cells[0].Value.ToString();
                    string book = DatagridBook.CurrentRow.Cells[0].Value.ToString();
                    Grid.gunaDataGridView1.Rows.Add(Name, book, Textprise.Text, gunaDateTimePicker1.Value, gunaDateTimePicker2.Value);
                    Dialuge_Add DF = new Dialuge_Add();
                    DF.gunaLinePanel1.LineColor = Color.FromArgb(236, 122, 48);
                    DF.Title_Label.Text = "تمت عملية الاضافه بنجاح";
                    Transition.ShowSync(DF);
                    // DF.Show();
                    this.Close();
                    string read = "";
                    File.Delete("AddRent.txt");
                    for (int x = 0; x < Grid.gunaDataGridView1.Rows.Count; x++)
                    {
                        for (int y = 0; y < Grid.gunaDataGridView1.ColumnCount; y++)
                        {
                            read += Grid.gunaDataGridView1.Rows[x].Cells[y].Value.ToString() + ";";
                        }
                        StreamWriter sw = new StreamWriter("AddRent.txt", true);
                        sw.WriteLine(read);
                        read = "";
                        sw.Close();
                    }
                }
                else
                {
                  
                        Grid.gunaDataGridView1.CurrentRow.Cells[0].Value = DatagriadName1.CurrentRow.Cells[0].Value.ToString();
                        Grid.gunaDataGridView1.CurrentRow.Cells[1].Value = DatagridBook.CurrentRow.Cells[0].Value.ToString();
                        Grid.gunaDataGridView1.CurrentRow.Cells[2].Value = Textprise.Text;
                        Grid.gunaDataGridView1.CurrentRow.Cells[3].Value = gunaDateTimePicker1.Value;
                        Grid.gunaDataGridView1.CurrentRow.Cells[4].Value = gunaDateTimePicker2.Value;
                        this.Close();
                        string read = "";
                       File.Delete("AddRent.txt");
                    for (int x = 0; x < Grid.gunaDataGridView1.Rows.Count; x++)
                    {
                        for (int y = 0; y < Grid.gunaDataGridView1.ColumnCount; y++)
                        {
                            read += Grid.gunaDataGridView1.Rows[x].Cells[y].Value.ToString() + ";";
                        }
                        StreamWriter sw = new StreamWriter("AddRent.txt", true);
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
    }
}
