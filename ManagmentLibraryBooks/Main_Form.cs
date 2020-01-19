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
namespace ManagmentLibraryBooks.PL
{
    public partial class Main_Form : Form
    {
        bool hidden = true;
        bool hide = true;
        string state;



        public Main_Form()
        {
            InitializeComponent();

        }

        private void MainBar_Panel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Main_Form_Load(object sender, EventArgs e)
        {   
            
            if (Label_User.Text == "مدير")

                pictureBox1.Image = Properties.Resources.Manager;
            else
                pictureBox1.Image = Properties.Resources.User;

            ////////////////////////////////


            StreamReader read = new StreamReader("book.txt");
            string line = "";
            PictureBox pic1 = new PictureBox();
            do
            {
                line = read.ReadLine();
                if (line != null)
                {
                    string[] str = line.Split(';');
                    pic1.Image = Image.FromFile("photo Books\\" + str[0] + ".png");
                    DATAGRID.Rows.Add(str[0], str[1], str[2], str[3], str[4], str[5], pic1.Image);
                }
            } while (line != null);
            read.Close();
            StreamReader readstudent = new StreamReader("student.txt");
            string linestudent = "";
            PictureBox pic2 = new PictureBox();
            do
            {
                linestudent = readstudent.ReadLine();
                if (linestudent != null)
                {
                    string[] strstudent = linestudent.Split(';');
                    pic2.Image = Image.FromFile("photo Books\\" + strstudent[0] + ".png");
                    DataGridStudent.Rows.Add(strstudent[0], strstudent[1], strstudent[2], strstudent[3], strstudent[4], pic2.Image);
                }
            } while (linestudent != null);
            readstudent.Close();
            StreamReader readitems = new StreamReader("Add.txt");
            string lineitems = "";
            do
            {
                lineitems = readitems.ReadLine();
                if (lineitems != null)
                {
                    string[] strr = lineitems.Split(';');
                    DataGridView2.Rows.Add(strr[0], strr[1]);
                }
            } while (lineitems != null);
            readitems.Close();
            StreamReader readSala = new StreamReader("AddSala.txt");
            string lineSala = "";
            do
            {
                lineSala = readSala.ReadLine();
                if (lineSala != null)
                {
                    string[] strSala = lineSala.Split(';');
                    DataGridSala.Rows.Add(strSala[0], strSala[1], strSala[2], strSala[3]);
                }
            } while (lineSala != null);
            readSala.Close();
            StreamReader readRent = new StreamReader("AddRent.txt");
            string lineRent = "";
            do
            {
                lineRent = readRent.ReadLine();
                if (lineRent != null)
                {
                    string[] strRent = lineRent.Split(';');
                    gunaDataGridView1.Rows.Add(strRent);
                }
            } while (lineRent != null);
            readRent.Close();
            StreamReader swuser = new StreamReader("user.txt");
            PictureBox pic = new PictureBox();
            string lineuser = "";
            do
            {
                lineuser = swuser.ReadLine();
                if (lineuser != null)
                {
                    string[] struser = lineuser.Split(';');
                    if(struser[3]=="مدير")
                        pic.Image = Properties.Resources.Manager;
                    else
                        pic.Image = Properties.Resources.User;
                    gunaDataGridView2.Rows.Add(struser[0], struser[1], struser[2], struser[3], pic.Image);
                }
            } while (lineuser != null);

            swuser.Close();
            panel8.Visible = false;
            Home_Panel.Visible = true;
            Type_Panel.Visible = false;
            Title_Label.Text = "الرئيسيه";

        }

      


        private void Types_Section_Click(object sender, EventArgs e)
        {
            Types_Section.BackColor = Color.FromArgb(0, 150, 136);

            Books_Panel.Visible = false;
            Student_Panel.Visible = false;
            panel8.Visible = true;
            Type_Panel.Visible = true;
            Home_Panel.Visible = false;
            Sale_Panel.Visible = false;
            Rent_Panel.Visible = false;
            state = "TYPE";
            Title_Label.Text = "الاصناف";
            Details_button.Enabled = false;
            User_Panel.Visible = false;
            Search_Panel.Visible = true;
            TitleBar_Panel.BackColor = Color.FromArgb(0, 150, 136);

        }

        private void Home_Section_Click(object sender, EventArgs e)
        {
            Theme_Button.Visible = true;
            switch_user.Visible = true;
            Home_Section.BackColor = Color.FromArgb(188, 191, 5);
            TitleBar_Panel.BackColor = Color.FromArgb(51, 153, 217);
            Print_REportclc.Visible = true;
            panel8.Visible = false;
            Books_Panel.Visible = false;
            Home_Panel.Visible = true;
            Type_Panel.Visible = false;
            Student_Panel.Visible = false;
            Sale_Panel.Visible = false;
            Rent_Panel.Visible = false;
            User_Panel.Visible = false;
            Search_Panel.Visible = false;
            state = "HOME";
            Title_Label.Text = "الرئيسية";
            panel8.Visible = false;

        }
        private void Books_Section_Click(object sender, EventArgs e)
        {

            Books_Section.BackColor = Color.FromArgb(232, 30, 99);
            Home_Panel.Visible = false;
            Details_button.Enabled = true;
            Title_Label.Text = "الكـتـب";
            panel8.Visible = true;
            Books_Panel.Visible = true;
            Type_Panel.Visible = false;
            Student_Panel.Visible = false;
            Sale_Panel.Visible = false;
            Rent_Panel.Visible = false;
            User_Panel.Visible = false;
            Search_Panel.Visible = true;
            state = "Book";
            TitleBar_Panel.BackColor = Color.FromArgb(232, 30, 99);


        }
        private void Student_Section_Click(object sender, EventArgs e)
        {
            if (Label_User.Text == "مستخدم")
            {
                Deletion_button.Enabled = false;
                Edition_button.Enabled = false;

                Student_Section.BackColor = Color.FromArgb(100, 88, 255);
                Details_button.Enabled = true;
                panel8.Visible = true;
                Home_Panel.Visible = false;
                Books_Panel.Visible = false;
                Type_Panel.Visible = false;
                Student_Panel.Visible = true;
                Sale_Panel.Visible = false;
                Rent_Panel.Visible = false;
                User_Panel.Visible = false;
                Search_Panel.Visible = true;
                state = "Student";
                Title_Label.Text = "الطلاب";
                TitleBar_Panel.BackColor = Color.FromArgb(100, 88, 255);
            }
            else
            {
                Student_Section.BackColor = Color.FromArgb(100, 88, 255);
                Details_button.Enabled = true;
                panel8.Visible = true;
                Home_Panel.Visible = false;
                Books_Panel.Visible = false;
                Type_Panel.Visible = false;
                Student_Panel.Visible = true;
                Sale_Panel.Visible = false;
                Rent_Panel.Visible = false;
                User_Panel.Visible = false;
                Search_Panel.Visible = true;
                state = "Student";
                Title_Label.Text = "الطلاب";
                TitleBar_Panel.BackColor = Color.FromArgb(100, 88, 255);
            }

        }

        private void Saled_Section_Click(object sender, EventArgs e)
        {
            if (Label_User.Text == "مستخدم ")
            {
                Deletion_button.Enabled = false;
                Edition_button.Enabled = false;

                Saled_Section.BackColor = Color.FromArgb(52, 152, 219);
                Details_button.Enabled = false;
                panel8.Visible = true;
                Home_Panel.Visible = false;
                Books_Panel.Visible = false;
                Type_Panel.Visible = false;
                Student_Panel.Visible = false;
                Sale_Panel.Visible = true;
                Rent_Panel.Visible = false;
                User_Panel.Visible = false;
                Search_Panel.Visible = true;
                state = "Sale";
                Title_Label.Text = "المبيعات";
                TitleBar_Panel.BackColor = Color.FromArgb(52, 152, 219);
            }
            else
            {
                Saled_Section.BackColor = Color.FromArgb(52, 152, 219);
                Details_button.Enabled = false;
                panel8.Visible = true;
                Home_Panel.Visible = false;
                Books_Panel.Visible = false;
                Type_Panel.Visible = false;
                Student_Panel.Visible = false;
                Sale_Panel.Visible = true;
                Rent_Panel.Visible = false;
                User_Panel.Visible = false;
                Search_Panel.Visible = true;
                state = "Sale";
                Title_Label.Text = "المبيعات";
                TitleBar_Panel.BackColor = Color.FromArgb(52, 152, 219);
            }

        }

        private void Rent_Section_Click(object sender, EventArgs e)
        {
            if (Label_User.Text == "مستخدم ")
            {
                Deletion_button.Enabled = false;
                Edition_button.Enabled = false;

                Rent_Section.BackColor = Color.FromArgb(243, 156, 18);
                Details_button.Enabled = false;
                panel8.Visible = true;
                Home_Panel.Visible = false;
                Books_Panel.Visible = false;
                Type_Panel.Visible = false;
                Student_Panel.Visible = false;
                Sale_Panel.Visible = false;
                Rent_Panel.Visible = true;
                User_Panel.Visible = false;
                Search_Panel.Visible = true;
                state = "Rent";
                Title_Label.Text = "الاستعاره";
                TitleBar_Panel.BackColor = Color.FromArgb(243, 156, 18);
            }
            else
            {
                Rent_Section.BackColor = Color.FromArgb(243, 156, 18);
                Details_button.Enabled = false;
                panel8.Visible = true;
                Home_Panel.Visible = false;
                Books_Panel.Visible = false;
                Type_Panel.Visible = false;
                Student_Panel.Visible = false;
                Sale_Panel.Visible = false;
                Rent_Panel.Visible = true;
                User_Panel.Visible = false;
                Search_Panel.Visible = true;
                state = "Rent";
                Title_Label.Text = "الاستعاره";
                TitleBar_Panel.BackColor = Color.FromArgb(243, 156, 18);
            }

        }
        private void User_Section_Click(object sender, EventArgs e)
        {
            if (Label_User.Text == "مستخدم")
            {

                Dialuge_Add DA = new Dialuge_Add();
                DA.gunaLinePanel1.LineColor = Color.FromArgb(243, 67, 54);
                DA.Title_Label.Text = "عذراً يجب ان تكون مدير ";
                DA.Show();
            }
            else
            {

                User_Section.BackColor = Color.FromArgb(243, 67, 54);
                Details_button.Enabled = false;
                panel8.Visible = true;
                Home_Panel.Visible = false;
                Books_Panel.Visible = false;
                Type_Panel.Visible = false;
                Student_Panel.Visible = false;
                Sale_Panel.Visible = false;
                Rent_Panel.Visible = false;
                User_Panel.Visible = true;
                Search_Panel.Visible = true;
                state = "User";
                Title_Label.Text = "المستخدمين";
                TitleBar_Panel.BackColor = Color.FromArgb(243, 67, 54);
            }


        }
        private void Addition_button_Click(object sender, EventArgs e)
        {
            if (state == "TYPE")
            {
                Add_Cat ad = new Add_Cat(this);
                Transition.ShowSync(ad);
                //ad.Show();
            }
            else if (state == "Book")
            {
                Add_Books ab = new Add_Books(this);
                Transition.ShowSync(ab);
               // ab.Show();
            }
            else if (state == "Student")
            {
                Add_Student Ad = new Add_Student(this);
                Transition.ShowSync(Ad);
               // Ad.Show();
            }
            else if (state == "Sale")
            {
                Add_Sale AD = new Add_Sale(this);
                Transition.ShowSync(AD);
               // AD.Show();
            }
            else if (state == "Rent")
            {
                Add_Rent AR = new Add_Rent(this);
                Transition.ShowSync(AR);
                //AR.Show();
            }
            else if (state == "User")
            {
                Add_User AU = new Add_User(this);
                Transition.ShowSync(AU);
               // AU.Show();
            }

        }

        private void Deletion_button_Click(object sender, EventArgs e)
        {
            if (state == "TYPE")
            {
                if (DataGridView2.RowCount == 0)
                {
                    Dialuge_Add DF = new Dialuge_Add();
                    DF.gunaLinePanel1.LineColor = Color.FromArgb(0, 150, 136);
                    DF.Title_Label.Text = "لا يوجد بيانات في الجدول";
                    Transition.ShowSync(DF);
                    // DF.Show();
                }
                else
                {
                    int rowindex = DataGridView2.CurrentCell.RowIndex;
                    DataGridView2.Rows.RemoveAt(rowindex);
                    string read = "";
                    File.Delete("Add.txt");
                    for (int x = 0; x < DataGridView2.Rows.Count; x++)
                    {

                        for (int y = 0; y < DataGridView2.ColumnCount; y++)
                        {
                            read += DataGridView2.Rows[x].Cells[y].Value.ToString() + ";";
                        }
                        StreamWriter sw = new StreamWriter("Add.txt", true);
                        sw.WriteLine(read);
                        read = "";
                        sw.Close();
                    }
                    Dialuge_Add DA = new Dialuge_Add();
                    DA.gunaLinePanel1.LineColor = Color.FromArgb(0, 150, 136);
                    DA.Title_Label.Text = "تمت عملية الحذف بنجاح";
                    Transition.ShowSync(DA);
                   // DA.Show();
                }
            }
            else if (state == "User")
            {
                if (gunaDataGridView2.RowCount == 0)
                {
                    Dialuge_Add DF = new Dialuge_Add();
                    DF.Title_Label.Text = "لا يوجد بيانات في الجدول";
                    Transition.ShowSync(DF);
                   // DF.Show();
                }
                else
                {
                    int rowindex = gunaDataGridView2.CurrentCell.RowIndex;
                    gunaDataGridView2.Rows.RemoveAt(rowindex);
                    string read = "";
                    File.Delete("user.txt");
                    for (int x = 0; x < gunaDataGridView2.Rows.Count; x++)
                    {

                        for (int y = 0; y < gunaDataGridView2.ColumnCount; y++)
                        {
                            read += gunaDataGridView2.Rows[x].Cells[y].Value.ToString() + ";";
                        }
                        StreamWriter sw = new StreamWriter("user.txt", true);
                        sw.WriteLine(read);
                        read = "";
                        sw.Close();
                    }
                    Dialuge_Add DA = new Dialuge_Add();
                    DA.Title_Label.Text = "تمت عملية الحذف بنجاح";
                    Transition.ShowSync(DA);
                   // DA.Show();
                }
            }
            else if (state == "Book")
            {
                if (DATAGRID.RowCount == 0)
                {
                    Dialuge_Add D = new Dialuge_Add();
                    D.gunaLinePanel1.LineColor = Color.FromArgb(232, 30, 99);
                    D.Title_Label.Text = "لا يوجد بيانات في الجدول";
                    Transition.ShowSync(D);
                   // D.Show();
                }
                else
                {
                    int rowindex = DATAGRID.CurrentCell.RowIndex;
                    DATAGRID.Rows.RemoveAt(rowindex);
                    string read = "";
                    if (File.Exists("book.txt"))
                        File.Delete("book.txt");
                    for (int x = 0; x < DATAGRID.Rows.Count; x++)
                    {
                        for (int y = 0; y < DATAGRID.ColumnCount - 1; y++)
                        {
                            read += DATAGRID.Rows[x].Cells[y].Value.ToString() + ";";
                        }
                        StreamWriter sw = new StreamWriter("book.txt", true);
                        sw.WriteLine(read);
                        read = "";
                        sw.Close();
                    }
                    Dialuge_Add DF = new Dialuge_Add();
                    DF.gunaLinePanel1.LineColor = Color.FromArgb(232, 30, 99);
                    DF.Title_Label.Text = "تمت  عملية الحذف  بنجاح";
                    Transition.ShowSync(DF);
                   // DF.Show();
                }
            }
            else if (state == "Student")
            {

                if (DataGridStudent.RowCount == 0)
                {
                    Dialuge_Add D = new Dialuge_Add();
                    D.Title_Label.Text = "لا يوجد بيانات في الجدول";
                    Transition.ShowSync(D);
                    //D.Show();
                }
                else
                {
                    int rowindex = DataGridStudent.CurrentCell.RowIndex;
                    DataGridStudent.Rows.RemoveAt(rowindex);
                    string read = "";
                    if (File.Exists("student.txt"))
                        File.Delete("student.txt");
                    for (int x = 0; x < DataGridStudent.Rows.Count; x++)
                    {
                        for (int y = 0; y < DataGridStudent.ColumnCount - 1; y++)
                        {
                            read += DataGridStudent.Rows[x].Cells[y].Value.ToString() + ";";
                        }
                        StreamWriter sw = new StreamWriter("student.txt", true);
                        sw.WriteLine(read);
                        read = "";
                        sw.Close();
                    }

                    Dialuge_Add DF = new Dialuge_Add();
                    DF.Title_Label.Text = "تمت  عملية الحذف  بنجاح";
                    Transition.ShowSync(DF);
                    //DF.Show();
                }

            }
            else if (state == "Rent")
            {

                if (gunaDataGridView1.RowCount == 0)
                {
                    Dialuge_Add D = new Dialuge_Add();
                    D.gunaLinePanel1.LineColor = Color.FromArgb(236, 122, 48);
                    D.Title_Label.Text = "لا يوجد بيانات في الجدول";
                    Transition.ShowSync(D);
                   // D.Show();
                }
                else
                {
                    int rowindex = gunaDataGridView1.CurrentCell.RowIndex;
                    gunaDataGridView1.Rows.RemoveAt(rowindex);
                    string read = "";
                    if (File.Exists("AddRent.txt"))
                        File.Delete("AddRent.txt");
                    for (int x = 0; x < gunaDataGridView1.Rows.Count; x++)
                    {
                        for (int y = 0; y < gunaDataGridView1.ColumnCount; y++)
                        {
                            read += gunaDataGridView1.Rows[x].Cells[y].Value.ToString() + ";";
                        }
                        StreamWriter sw = new StreamWriter("Rent.txt", true);
                        sw.WriteLine(read);
                        read = "";
                        sw.Close();
                    }

                    Dialuge_Add DF = new Dialuge_Add();
                    DF.gunaLinePanel1.LineColor = Color.FromArgb(236, 122, 48);
                    DF.Title_Label.Text = "تمت  عملية الحذف  بنجاح";
                    Transition.ShowSync(DF);
                   // DF.Show();
                }

            }
            else if (state == "Sale")
            {

                if (DataGridSala.RowCount == 0)
                {
                    Dialuge_Add D = new Dialuge_Add();
                    D.gunaLinePanel1.LineColor = Color.FromArgb(52, 152, 219);
                    D.Title_Label.Text = "لا يوجد بيانات في الجدول";
                    Transition.ShowSync(D);
                   // D.Show();
                }
                else
                {
                    int rowindex = DataGridSala.CurrentCell.RowIndex;
                    DataGridSala.Rows.RemoveAt(rowindex);
                    string read = "";
                    if (File.Exists("AddSala.txt"))
                        File.Delete("AddSala.txt");
                    for (int x = 0; x < DataGridSala.Rows.Count; x++)
                    {
                        for (int y = 0; y < DataGridSala.ColumnCount; y++)
                        {
                            read += DataGridSala.Rows[x].Cells[y].Value.ToString() + ";";
                        }
                        StreamWriter sw = new StreamWriter("AddSala.txt", true);
                        sw.WriteLine(read);
                        read = "";
                        sw.Close();
                    }

                    Dialuge_Add DF = new Dialuge_Add();
                    DF.gunaLinePanel1.LineColor = Color.FromArgb(52, 152, 219);
                    DF.Title_Label.Text = "تمت  عملية الحذف  بنجاح";
                    Transition.ShowSync(DF);
                  //  DF.Show();
                }

            }
        }

        private void Edition_button_Click(object sender, EventArgs e)
        {
            if (state == "TYPE")
            {
                if (DataGridView2.RowCount == 0)
                {
                    Dialuge_Add DF = new Dialuge_Add();
                    DF.gunaLinePanel1.LineColor = Color.FromArgb(0, 150, 136);
                    DF.Title_Label.Text = "لا يوجد بيانات في الجدول";
                    Transition.ShowSync(DF);
                    //DF.Show();
                }
                else
                {
                    string rowindex = DataGridView2.CurrentCell.Value.ToString();
                    Add_Cat da = new Add_Cat(this);
                    da.BTN_ADD.Text = "تعديل";
                    da.TexCAt.Text = Convert.ToString(DataGridView2.CurrentRow.Cells[0].Value);
                    Transition.ShowSync(da);
                    //da.Show();
                }

            }
            else if (state == "Book")
            {
                if (DATAGRID.RowCount == 0)
                {
                    Dialuge_Add DF = new Dialuge_Add();
                    DF.gunaLinePanel1.LineColor = Color.FromArgb(232, 30, 99);
                    DF.Title_Label.Text = "لا يوجد بيانات في الجدول";
                    Transition.ShowSync(DF);
                    //DF.Show();
                }
                else
                {
                    string rowindex = DATAGRID.CurrentCell.Value.ToString();
                    Add_Books da = new Add_Books(this);
                    da.BunAdd.Text = "تـعـديـل";
                    da.txtbookname.Text = Convert.ToString(DATAGRID.CurrentRow.Cells[0].Value);
                    da.txtnamefile.Text = Convert.ToString(DATAGRID.CurrentRow.Cells[1].Value);
                    da.comitems.Text = Convert.ToString(DATAGRID.CurrentRow.Cells[2].Value);
                    da.txtprise.Text = Convert.ToString(DATAGRID.CurrentRow.Cells[3].Value);
                    da.Data.Text = Convert.ToString(DATAGRID.CurrentRow.Cells[4].Value);
                    da.RatingBooks.Value = Convert.ToInt32(DATAGRID.CurrentRow.Cells[5].Value);
                    da.picbook.Image = Image.FromFile("photo Books\\" + da.txtbookname.Text + ".png");
                    Transition.ShowSync(da);
                    //da.Show();
                }


            }
            else if (state == "Student")
            {


                if (DataGridStudent.RowCount == 0)
                {
                    Dialuge_Add DF = new Dialuge_Add();
                    DF.gunaLinePanel1.LineColor = Color.FromArgb(66, 58, 170);
                    DF.Title_Label.Text = "لا يوجد بيانات في الجدول";
                    Transition.ShowSync(DF);
                    //DF.Show();
                }
                else
                {
                    string rowindex = DataGridStudent.CurrentCell.Value.ToString();
                    Add_Student da = new Add_Student(this);
                    da.ButtonAddtion2.Text = "تـعـديـل";
                    da.TextBoxName.Text = Convert.ToString(DataGridStudent.CurrentRow.Cells[0].Value);
                    da.TextBoxHome.Text = Convert.ToString(DataGridStudent.CurrentRow.Cells[1].Value);
                    da.TextBoxPhone.Text = Convert.ToString(DataGridStudent.CurrentRow.Cells[2].Value);
                    da.TextBoxCollage.Text = Convert.ToString(DataGridStudent.CurrentRow.Cells[3].Value);
                    da.TextBoxSection.Text = Convert.ToString(DataGridStudent.CurrentRow.Cells[4].Value);
                    da.PictureBoxStudent.Image = Image.FromFile("Photo Books\\" + da.TextBoxName.Text + ".png");
                    Transition.ShowSync(da);
                    //da.Show();

                }
            }
            else if (state == "Sale")
            {
                if (DataGridSala.RowCount == 0)
                {
                    Dialuge_Add DF = new Dialuge_Add();
                    DF.gunaLinePanel1.LineColor = Color.FromArgb(232, 30, 99);
                    DF.Title_Label.Text = "لا يوجد بيانات في الجدول";
                    Transition.ShowSync(DF);
                    DF.Show();
                }
                else
                {
                    string rowindex = DataGridSala.CurrentCell.Value.ToString();
                    Add_Sale da = new Add_Sale(this);
                    da.butok.Text = "تـعـديـل";
                    Transition.ShowSync(da);
                 // da.Show();
                }
                /////////////////////////////////////////////////////////////////////////////////////////////////////////

            }
            else if(state=="Rent")
            {
                if (gunaDataGridView1.RowCount == 0)
                {
                    Dialuge_Add DF = new Dialuge_Add();
                    DF.gunaLinePanel1.LineColor = Color.FromArgb(232, 30, 99);
                    DF.Title_Label.Text = "لا يوجد بيانات في الجدول";
                    Transition.ShowSync(DF);
                    DF.Show();
                }
                else
                {
                    string rowindex =gunaDataGridView1.CurrentCell.Value.ToString();
                    Add_Rent da = new Add_Rent(this);
                    da.butAddRent.Text = "تـعـديـل";
                    Transition.ShowSync(da);
                   // da.Show();
                }
            }
            else if(state=="User")
            {

                if (gunaDataGridView2.RowCount == 0)
                {
                    Dialuge_Add DF = new Dialuge_Add();
                    DF.gunaLinePanel1.LineColor = Color.FromArgb(66, 58, 170);
                    DF.Title_Label.Text = "لا يوجد بيانات في الجدول";
                    Transition.ShowSync(DF);
                    //DF.Show();
                }
                else
                {
                    string rowindex = gunaDataGridView2.CurrentCell.Value.ToString();
                    Add_User da = new Add_User(this);
                    da.ButtonAddtion2.Text = "تـعـديـل";
                    da.txtpassword.Text = Convert.ToString(gunaDataGridView2.CurrentRow.Cells[0].Value);
                    da.nameuser.Text = Convert.ToString(gunaDataGridView2.CurrentRow.Cells[1].Value);
                    da.txtnamestudent.Text = Convert.ToString(gunaDataGridView2.CurrentRow.Cells[2].Value);
                    da.gunaComboBox1.Text = Convert.ToString(gunaDataGridView2.CurrentRow.Cells[3].Value);
                    if (da.gunaComboBox1.SelectedItem.ToString() == "مدير")
                        da.PictureBox.Image = Properties.Resources.Manager;
                    else
                        da.PictureBox.Image = Properties.Resources.User;
                    Transition.ShowSync(da);

                    //da.Show();

                }
            }
        }



        private void Details_button_Click(object sender, EventArgs e)
        {
            if (state == "Book")
            {
                if (DATAGRID.RowCount == 0)
                {
                    Dialuge_Add DF = new Dialuge_Add();
                    DF.gunaLinePanel1.LineColor = Color.FromArgb(232, 30, 99);
                    DF.Title_Label.Text = "لا يوجد بيانات في الجدول";
                    Transition.ShowSync(DF);
                    //DF.Show();
                }
                else
                {
                    string rowindex = DATAGRID.CurrentCell.Value.ToString();
                    Details da = new Details();
                    da.label111.Text = Convert.ToString(DATAGRID.CurrentRow.Cells[0].Value);
                    da.label222.Text = Convert.ToString(DATAGRID.CurrentRow.Cells[1].Value);
                    da.label333.Text = Convert.ToString(DATAGRID.CurrentRow.Cells[2].Value);
                    da.label444.Text = Convert.ToString(DATAGRID.CurrentRow.Cells[3].Value);
                    da.gunaDateTimePicker1.Text = Convert.ToString(DATAGRID.CurrentRow.Cells[4].Value);
                    da.Rating1.Value = Convert.ToInt32(DATAGRID.CurrentRow.Cells[5].Value);
                    da.gunaPictureBox1.Image = Image.FromFile("photo Books//" + da.label111.Text + ".png");
                    Transition.ShowSync(da);
                   // da.Show();
                }

            }
            else if (state == "Student")
            {
                if (DataGridStudent.RowCount == 0)
                {
                    Dialuge_Add DF = new Dialuge_Add();
                    DF.gunaLinePanel1.LineColor = Color.FromArgb(66, 58, 170);
                    DF.Title_Label.Text = "لا يوجد بيانات في الجدول";
                    Transition.ShowSync(DF);
                    DF.Show();
                }
                else
                {
                    string rowindex = DataGridStudent.CurrentCell.Value.ToString();
                    Details_Student da = new Details_Student();

                    da.TextBoxName.Text = Convert.ToString(DataGridStudent.CurrentRow.Cells[0].Value);
                    da.TextBoxHome.Text = Convert.ToString(DataGridStudent.CurrentRow.Cells[1].Value);
                    da.TextBoxPhone.Text = Convert.ToString(DataGridStudent.CurrentRow.Cells[2].Value);
                    da.TextBoxCollage.Text = Convert.ToString(DataGridStudent.CurrentRow.Cells[3].Value);
                    da.TextBoxSection.Text = Convert.ToString(DataGridStudent.CurrentRow.Cells[4].Value);
                    da.PictureBoxStudent.Image = Image.FromFile("photo Books//" + da.TextBoxName.Text + ".png");
                    Transition.ShowSync(da);
                    //da.Show();

                }
            }
        }



        private void CircleButton5_Click(object sender, EventArgs e)
        {
            Add_Cat ad = new Add_Cat(this);
            Transition.ShowSync(ad);
            //ad.Show();
        }

        private void CircleButton1_Click(object sender, EventArgs e)
        {
            Add_Books ab = new Add_Books(this);
            Transition.ShowSync(ab);
           // ab.Show();
        }


        private void CircleButton2_Click(object sender, EventArgs e)
        {
            Add_Student AD = new Add_Student(this);
            Transition.ShowSync(AD);
           // AD.Show();
        }

        private void CircleButton3_Click(object sender, EventArgs e)
        {
            Add_Sale AS = new Add_Sale(this);
            Transition.ShowSync(AS);
            //AS.Show();
        }

        private void CircleButton4_Click(object sender, EventArgs e)
        {
            Add_Rent AR = new Add_Rent(this);
            Transition.ShowSync(AR);
           // AR.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
           
            if (hidden == true)////(Hide)
            {
                

                Point loc = new Point(5, 175);
                Home_Section.Location = loc;
                loc.X = 5;
                loc.Y = 230;
                Types_Section.Location = loc;
                loc.X = 5;
                loc.Y = 281;
                Books_Section.Location = loc;
                loc.X = 5;
                loc.Y = 336;
                Student_Section.Location = loc;
                loc.X = 5;
                loc.Y = 391;
                Saled_Section.Location = loc;
                loc.X = 5;
                loc.Y = 446;
                Rent_Section.Location = loc;
                loc.X = 5;
                loc.Y = 501;
                User_Section.Location = loc;

                timer1.Start();
                //////////////////////////////////////////////////
                Home_Section.RightToLeft = RightToLeft.Yes;
                Home_Section.RightToLeft = RightToLeft.Yes;
                Types_Section.RightToLeft = RightToLeft.Yes;
                Books_Section.RightToLeft = RightToLeft.Yes;
                Student_Section.RightToLeft = RightToLeft.Yes;
                Saled_Section.RightToLeft = RightToLeft.Yes;
                Rent_Section.RightToLeft = RightToLeft.Yes;
                User_Section.RightToLeft = RightToLeft.Yes;

                Label_User.Visible = true;

            }
            else if(hidden==false)////(Show)
            {

                Point loc = new Point(0, 175);
                Home_Section.Location = loc;
                loc.X = 0;
                loc.Y = 230;
                Types_Section.Location = loc;
                loc.X = 0;
                loc.Y = 281;
                Books_Section.Location = loc;
                loc.X = 0;
                loc.Y = 336;
                Student_Section.Location = loc;
                loc.X = 0;
                loc.Y = 391;
                Saled_Section.Location = loc;
                loc.X = 0;
                loc.Y = 446;
                Rent_Section.Location = loc;
                loc.X = 0;
                loc.Y = 501;
                User_Section.Location = loc;

                timer1.Start();
                ////////////////////////////////////////////////
                Home_Section.RightToLeft = RightToLeft.No;
                Types_Section.RightToLeft = RightToLeft.No;
                Books_Section.RightToLeft = RightToLeft.No;
                Student_Section.RightToLeft = RightToLeft.No;
                Saled_Section.RightToLeft = RightToLeft.No;
                Rent_Section.RightToLeft = RightToLeft.No;
                User_Section.RightToLeft = RightToLeft.No;
                Label_User.Visible = false;
            }

            if (hide==false)
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hidden == false)
            {
                MainBar_Panel.Width -= 5;                              
              
                if (MainBar_Panel.Width == 40)
                {

                    timer1.Stop();
                    hidden = true;
                    this.Refresh();
                }
            

            }
            else if (hidden == true)
            {
                MainBar_Panel.Width += 5;
              
                if(MainBar_Panel.Width==200)
                {
                    Point loc = new Point(0, 175);
                    Home_Section.Location = loc;
                    loc.X = 0;
                    loc.Y = 230;
                    Types_Section.Location = loc;
                    loc.X = 0;
                    loc.Y = 281;
                    Books_Section.Location = loc;
                    loc.X = 0;
                    loc.Y = 336;
                    Student_Section.Location = loc;
                    loc.X = 0;
                    loc.Y = 391;
                    Saled_Section.Location = loc;
                    loc.X = 0;
                    loc.Y = 446;
                    Rent_Section.Location = loc;
                    loc.X = 0;
                    loc.Y = 501;
                    User_Section.Location = loc;

                    /////////////////////////////////////

                    timer1.Stop();
                    hidden = false;
                    this.Refresh();
                }
             
            }
        }

        private void close_app_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Print_REportclc_Click(object sender, EventArgs e)
        {
            Print_Report PR = new Print_Report();

            PR.FullName.Text = Private.Text;
            PR.Valid.Text = Label_User.Text;
            PR.Date.Text = DateTime.Now.ToLongTimeString();
            PR.label_Book.Text = Count_Books.Text;
            PR.label_Rent.Text = Count_Rents.Text;
            PR.label_Sale.Text = Count_Sales.Text;
            PR.label_Student.Text = Count_Student.Text;
            PR.label_Type.Text = Count_Typs.Text;
            PR.label_user.Text = Count_Users.Text;
            PR.Show();
        }

        private void TextBoxCollage_TextChanged(object sender, EventArgs e)
        {
            PictureBox p1 = new PictureBox();
            if (state == "Book")
            {
                if (TextBoxCollage.Text.Trim() != "ابحث هنا" && TextBoxCollage.Text.Trim() != "")
                {
                    for (int x = 0; x < DATAGRID.Rows.Count; x++)
                    {
                        if (DATAGRID.Rows[x].Cells[0].Value.ToString() == TextBoxCollage.Text)
                        {
                            string[] str = { DATAGRID.Rows[x].Cells[0].Value.ToString(), DATAGRID.Rows[x].Cells[1].Value.ToString(), DATAGRID.Rows[x].Cells[2].Value.ToString(), DATAGRID.Rows[x].Cells[3].Value.ToString(), DATAGRID.Rows[x].Cells[4].Value.ToString(), DATAGRID.Rows[x].Cells[5].Value.ToString() };
                            DATAGRID.Rows.Clear();
                            p1.Image = Image.FromFile("photo Books\\" + TextBoxCollage.Text + ".png");
                            DATAGRID.Rows.Add(str[0], str[1], str[2], str[3], str[4], str[5], p1.Image);
                        }
                    }
                }
                else
                {
                    DATAGRID.Rows.Clear();
                    if (File.Exists("book.txt"))
                    {
                        StreamReader read = new StreamReader("book.txt");
                        string line = "";
                        PictureBox pic1 = new PictureBox();
                        do
                        {
                            line = read.ReadLine();
                            if (line != null)
                            {
                                string[] str = line.Split(';');
                                pic1.Image = Image.FromFile("photo Books\\" + str[0] + ".png");
                                DATAGRID.Rows.Add(str[0], str[1], str[2], str[3], str[4], str[5], pic1.Image);
                            }
                        } while (line != null);
                        read.Close();

                    }
                }
            }
            if (state == "Student")
            {
                if (TextBoxCollage.Text.Trim() != "ابحث هنا" && TextBoxCollage.Text.Trim() != "")
                {
                    for (int x = 0; x < DataGridStudent.Rows.Count; x++)
                    {
                        if (DataGridStudent.Rows[x].Cells[0].Value.ToString() == TextBoxCollage.Text)
                        {
                            string[] str = { DataGridStudent.Rows[x].Cells[0].Value.ToString(), DataGridStudent.Rows[x].Cells[1].Value.ToString(), DataGridStudent.Rows[x].Cells[2].Value.ToString(), DataGridStudent.Rows[x].Cells[3].Value.ToString(), DataGridStudent.Rows[x].Cells[4].Value.ToString() };
                            DataGridStudent.Rows.Clear();
                            p1.Image = Image.FromFile("photo Books\\" + TextBoxCollage.Text + ".png");
                            DataGridStudent.Rows.Add(str[0], str[1], str[2], str[3], str[4], p1.Image);
                        }
                    }
                }
                else
                {
                    DataGridStudent.Rows.Clear();
                    StreamReader read = new StreamReader("student.txt");
                    string line = "";
                    PictureBox pic1 = new PictureBox();
                    do
                    {
                        line = read.ReadLine();
                        if (line != null)
                        {
                            string[] str = line.Split(';');
                            pic1.Image = Image.FromFile("photo Books\\" + str[0] + ".png");
                            DataGridStudent.Rows.Add(str[0], str[1], str[2], str[3], str[4], pic1.Image);
                        }
                    } while (line != null);
                    read.Close();
                }

            }
            if (state == "TYPE")
            {

                if (TextBoxCollage.Text.Trim() != "ابحث هنا" && TextBoxCollage.Text.Trim() != "")
                {
                    for (int x = 0; x < DataGridView2.Rows.Count; x++)
                    {
                        if (DataGridView2.Rows[x].Cells[0].Value.ToString() == TextBoxCollage.Text)
                        {
                            string[] str = { DataGridView2.Rows[x].Cells[0].Value.ToString(), DataGridView2.Rows[x].Cells[1].Value.ToString() };
                            DataGridView2.Rows.Clear();
                            DataGridView2.Rows.Add(str[0], str[1]);
                        }
                    }
                }

                else
                {
                    DataGridView2.Rows.Clear();
                    StreamReader read = new StreamReader("Add.txt");
                    string line = "";
                    do
                    {
                        line = read.ReadLine();
                        if (line != null)
                        {
                            string[] str = line.Split(';');
                            DataGridView2.Rows.Add(str[0], str[1]);
                        }
                    } while (line != null);
                    read.Close();
                }
            }
            if (state == "Sale")
            {

                if (TextBoxCollage.Text.Trim() != "ابحث هنا" && TextBoxCollage.Text.Trim() != "")
                {
                    for (int x = 0; x < DataGridSala.Rows.Count; x++)
                    {
                        if (DataGridSala.Rows[x].Cells[0].Value.ToString() == TextBoxCollage.Text)
                        {
                            string[] strSala = { DataGridSala.Rows[x].Cells[0].Value.ToString(), DataGridSala.Rows[x].Cells[1].Value.ToString(), DataGridSala.Rows[x].Cells[2].Value.ToString(), DataGridSala.Rows[x].Cells[3].Value.ToString() };
                            DataGridSala.Rows.Clear();
                            DataGridSala.Rows.Add(strSala);
                        }
                    }
                }

                else
                {
                    DataGridSala.Rows.Clear();
                    StreamReader read = new StreamReader("AddSala.txt");
                    string line = "";
                    do
                    {
                        line = read.ReadLine();
                        if (line != null)
                        {
                            string[] str = line.Split(';');
                            DataGridSala.Rows.Add(str);
                        }
                    } while (line != null);
                    read.Close();
                }
            }
            if (state == "Rent")
            {
                if (TextBoxCollage.Text.Trim() != "ابحث هنا" && TextBoxCollage.Text.Trim() != "")
                {
                    for (int x = 0; x < gunaDataGridView1.Rows.Count; x++)
                    {
                        if (gunaDataGridView1.Rows[x].Cells[0].Value.ToString() == TextBoxCollage.Text)
                        {
                            string[] strSala = { gunaDataGridView1.Rows[x].Cells[0].Value.ToString(), gunaDataGridView1.Rows[x].Cells[1].Value.ToString(), gunaDataGridView1.Rows[x].Cells[2].Value.ToString(), gunaDataGridView1.Rows[x].Cells[3].Value.ToString() };
                            gunaDataGridView1.Rows.Clear();
                            gunaDataGridView1.Rows.Add(strSala);
                        }
                    }
                }

                else
                {
                    gunaDataGridView1.Rows.Clear();
                    StreamReader read = new StreamReader("AddRent.txt");
                    string line = "";
                    do
                    {
                        line = read.ReadLine();
                        if (line != null)
                        {
                            string[] str = line.Split(';');
                            DataGridSala.Rows.Add(str);
                        }
                    } while (line != null);
                    read.Close();
                }
            }
            if (state == "User")
            {
                if (TextBoxCollage.Text.Trim() != "ابحث هنا" && TextBoxCollage.Text.Trim() != "")
                {
                    for (int x = 0; x < gunaDataGridView2.Rows.Count; x++)
                    {
                        string search = TextBoxCollage.Text;
                        if (gunaDataGridView2.Rows[x].Cells[1].Value.ToString() == search)
                        {
                            string[] str = { gunaDataGridView2.Rows[x].Cells[0].Value.ToString(), gunaDataGridView2.Rows[x].Cells[1].Value.ToString(), gunaDataGridView2.Rows[x].Cells[2].Value.ToString(), gunaDataGridView2.Rows[x].Cells[3].Value.ToString() };
                            gunaDataGridView2.Rows.Clear();
                            if (str[3] == "مدير")
                                p1.Image = Properties.Resources.Manager;
                            else
                                p1.Image = Properties.Resources.User;
                            
                            gunaDataGridView2.Rows.Add(str[0], str[1], str[2], str[3], p1.Image);
                        }
                    }
                }
                else
                {
                    gunaDataGridView2.Rows.Clear();
                    if (File.Exists("user.txt"))
                    {
                        StreamReader read = new StreamReader("user.txt");
                        string line = "";
                        PictureBox pic1 = new PictureBox();
                        do
                        {
                            line = read.ReadLine();
                            if (line != null)
                            {
                                string[] str = line.Split(';');
                                if (str[3] == "مدير")
                                    pic1.Image = Properties.Resources.Manager;
                                else
                                    pic1.Image = Properties.Resources.User;

                                gunaDataGridView2.Rows.Add(str[0], str[1], str[2], str[3], pic1.Image);
                            }
                        } while (line != null);
                        read.Close();

                    }
                }
            }

        }

        private void TitleBar_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Form_Activated(object sender, EventArgs e)
        {
            Count_Typs.Text = DataGridView2.RowCount.ToString();
            Count_Books.Text = DATAGRID.RowCount.ToString();
            Count_Student.Text = DataGridStudent.RowCount.ToString();
            Count_Sales.Text = DataGridSala.RowCount.ToString();
            Count_Rents.Text = gunaDataGridView1.RowCount.ToString();
            Count_Users.Text = gunaDataGridView2.RowCount.ToString();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_Form2 LF = new Login_Form2();
            LF.Show();
        }

        private void switch_user_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Home_Section_Leave(object sender, EventArgs e)
        {
            Home_Section.BackColor = MainBar_Panel.BackColor;
            switch_user.Visible = false;
            Print_REportclc.Visible = false;
        }

        private void Types_Section_Leave(object sender, EventArgs e)
        {
            Types_Section.BackColor = MainBar_Panel.BackColor;
        }

        private void Books_Section_Leave(object sender, EventArgs e)
        {
            Books_Section.BackColor = MainBar_Panel.BackColor;
        }

        private void Student_Section_Leave(object sender, EventArgs e)
        {
            Student_Section.BackColor = MainBar_Panel.BackColor;
        }

        private void Saled_Section_Leave(object sender, EventArgs e)
        {
            Saled_Section.BackColor = MainBar_Panel.BackColor;
        }

        private void Rent_Section_Leave(object sender, EventArgs e)
        {
            Rent_Section.BackColor = MainBar_Panel.BackColor;
        }

        private void User_Section_Leave(object sender, EventArgs e)
        {
            User_Section.BackColor = MainBar_Panel.BackColor;
        }

        private void CircleButton5_MouseHover(object sender, EventArgs e)
        {
            CircleButton1.OnHoverBaseColor = MainBar_Panel.BackColor;
            CircleButton2.OnHoverBaseColor = MainBar_Panel.BackColor;
            CircleButton3.OnHoverBaseColor = MainBar_Panel.BackColor;
            CircleButton4.OnHoverBaseColor = MainBar_Panel.BackColor;
            CircleButton5.OnHoverBaseColor = MainBar_Panel.BackColor;
        }

        private void Theme_Button_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (hide == true)
            {
                panel_theme.Height += 5;
                if (panel_theme.Height == 30)
                {
                    timer2.Stop();
                    hide = false;
                    this.Refresh();
                }

            }
            else if (hide == false)
            {
                panel_theme.Height -= 5;
                if (panel_theme.Height == 0)
                {
                    timer2.Stop();
                    hide = true;
                    this.Refresh();
                }
            }

        }

        private void ComboBox_themes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_themes.SelectedItem.ToString()== "الافتراضي")
            {
                MainBar_Panel.BackColor = Color.FromArgb(45, 62, 80);
                MainBar_Panel.Refresh();
                Home_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Types_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Books_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Student_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Saled_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Rent_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                User_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
            }
            else if (ComboBox_themes.SelectedItem.ToString() == "اسود")
            {
               
                MainBar_Panel.BackColor = Color.FromArgb(31, 31, 31);
                MainBar_Panel.Refresh();
                Home_Section.BackColor= MainBar_Panel.BackColor; timer2.Start();
                Types_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Books_Section.BackColor= MainBar_Panel.BackColor; timer2.Start();
                Student_Section.BackColor= MainBar_Panel.BackColor; timer2.Start();
                Saled_Section.BackColor= MainBar_Panel.BackColor; timer2.Start();
                Rent_Section.BackColor= MainBar_Panel.BackColor; timer2.Start();
                User_Section.BackColor= MainBar_Panel.BackColor; timer2.Start();
            }
            else if (ComboBox_themes.SelectedItem.ToString() == "ازرق")
             {
                MainBar_Panel.BackColor = Color.FromArgb(51, 153, 217);
                MainBar_Panel.Refresh();
                Home_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Types_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Books_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Student_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Saled_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Rent_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                User_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
            }
            else if (ComboBox_themes.SelectedItem.ToString() == "بنفسجي")
            {
                MainBar_Panel.BackColor = Color.FromArgb(68, 98, 186);
               
                MainBar_Panel.Refresh();
                Home_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Types_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Books_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Student_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Saled_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Rent_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                User_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
            }
            else if (ComboBox_themes.SelectedItem.ToString() == "اخضر")
            {
                MainBar_Panel.BackColor = Color.FromArgb(71, 186, 164);
                MainBar_Panel.Refresh();
                Home_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Types_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Books_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Student_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Saled_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Rent_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                User_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();

            }
            else if (ComboBox_themes.SelectedItem.ToString() == "سماوي")
            {
                MainBar_Panel.BackColor = Color.FromArgb(71, 164, 186);
                MainBar_Panel.Refresh();
                Home_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Types_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Books_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Student_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Saled_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                Rent_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
                User_Section.BackColor = MainBar_Panel.BackColor; timer2.Start();
            }


        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cloosing_Form CF = new Cloosing_Form();
            CF.ShowDialog();

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
 }
    
    

