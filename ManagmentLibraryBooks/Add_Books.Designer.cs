namespace ManagmentLibraryBooks
{
    partial class Add_Books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Books));
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.BunAdd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RatingBooks = new Bunifu.Framework.UI.BunifuRating();
            this.Selectphoto = new Guna.UI.WinForms.GunaButton();
            this.picbook = new Guna.UI.WinForms.GunaPictureBox();
            this.Data = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comitems = new Guna.UI.WinForms.GunaComboBox();
            this.txtprise = new Guna.UI.WinForms.GunaLineTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnamefile = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbookname = new Guna.UI.WinForms.GunaLineTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.gunaLinePanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbook)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLinePanel1.BackColor = System.Drawing.SystemColors.Control;
            this.gunaLinePanel1.Controls.Add(this.gunaControlBox1);
            this.gunaLinePanel1.Controls.Add(this.BunAdd);
            this.gunaLinePanel1.Controls.Add(this.groupBox2);
            this.gunaLinePanel1.Controls.Add(this.groupBox1);
            this.Transition.SetDecoration(this.gunaLinePanel1, BunifuAnimatorNS.DecorationType.None);
            this.gunaLinePanel1.LineBottom = 3;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.gunaLinePanel1.LineLeft = 3;
            this.gunaLinePanel1.LineRight = 3;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 30;
            this.gunaLinePanel1.Location = new System.Drawing.Point(310, 116);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(877, 611);
            this.gunaLinePanel1.TabIndex = 0;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.Transition.SetDecoration(this.gunaControlBox1, BunifuAnimatorNS.DecorationType.None);
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 30);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // BunAdd
            // 
            this.BunAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BunAdd.AnimationHoverSpeed = 0.07F;
            this.BunAdd.AnimationSpeed = 0.03F;
            this.BunAdd.BackColor = System.Drawing.Color.Transparent;
            this.BunAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.BunAdd.BorderColor = System.Drawing.Color.Black;
            this.BunAdd.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BunAdd.CheckedBorderColor = System.Drawing.Color.Black;
            this.BunAdd.CheckedForeColor = System.Drawing.Color.White;
            this.BunAdd.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BunAdd.CheckedImage")));
            this.BunAdd.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Transition.SetDecoration(this.BunAdd, BunifuAnimatorNS.DecorationType.None);
            this.BunAdd.FocusedColor = System.Drawing.Color.Empty;
            this.BunAdd.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BunAdd.ForeColor = System.Drawing.Color.White;
            this.BunAdd.Image = null;
            this.BunAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.BunAdd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BunAdd.Location = new System.Drawing.Point(312, 543);
            this.BunAdd.Name = "BunAdd";
            this.BunAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BunAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BunAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.BunAdd.OnHoverImage = null;
            this.BunAdd.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BunAdd.OnPressedColor = System.Drawing.Color.Black;
            this.BunAdd.Radius = 15;
            this.BunAdd.Size = new System.Drawing.Size(320, 42);
            this.BunAdd.TabIndex = 3;
            this.BunAdd.Text = "اضافة";
            this.BunAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BunAdd.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.RatingBooks);
            this.groupBox2.Controls.Add(this.Selectphoto);
            this.groupBox2.Controls.Add(this.picbook);
            this.groupBox2.Controls.Add(this.Data);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.Transition.SetDecoration(this.groupBox2, BunifuAnimatorNS.DecorationType.None);
            this.groupBox2.Location = new System.Drawing.Point(64, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(350, 450);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المعلومات الثانوية";
            // 
            // RatingBooks
            // 
            this.RatingBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RatingBooks.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.RatingBooks, BunifuAnimatorNS.DecorationType.None);
            this.RatingBooks.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingBooks.ForeColor = System.Drawing.Color.Gold;
            this.RatingBooks.Location = new System.Drawing.Point(32, 186);
            this.RatingBooks.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RatingBooks.Name = "RatingBooks";
            this.RatingBooks.Size = new System.Drawing.Size(296, 50);
            this.RatingBooks.TabIndex = 3;
            this.RatingBooks.Value = 0;
            // 
            // Selectphoto
            // 
            this.Selectphoto.AnimationHoverSpeed = 0.07F;
            this.Selectphoto.AnimationSpeed = 0.03F;
            this.Selectphoto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.Selectphoto.BorderColor = System.Drawing.Color.Black;
            this.Transition.SetDecoration(this.Selectphoto, BunifuAnimatorNS.DecorationType.None);
            this.Selectphoto.FocusedColor = System.Drawing.Color.Empty;
            this.Selectphoto.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selectphoto.ForeColor = System.Drawing.Color.White;
            this.Selectphoto.Image = ((System.Drawing.Image)(resources.GetObject("Selectphoto.Image")));
            this.Selectphoto.ImageSize = new System.Drawing.Size(20, 20);
            this.Selectphoto.Location = new System.Drawing.Point(104, 406);
            this.Selectphoto.Name = "Selectphoto";
            this.Selectphoto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Selectphoto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Selectphoto.OnHoverForeColor = System.Drawing.Color.White;
            this.Selectphoto.OnHoverImage = null;
            this.Selectphoto.OnPressedColor = System.Drawing.Color.Black;
            this.Selectphoto.Size = new System.Drawing.Size(133, 28);
            this.Selectphoto.TabIndex = 5;
            this.Selectphoto.Text = "رفع صوره";
            this.Selectphoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Selectphoto.Click += new System.EventHandler(this.Selectphoto_Click);
            // 
            // picbook
            // 
            this.picbook.BaseColor = System.Drawing.Color.White;
            this.picbook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Transition.SetDecoration(this.picbook, BunifuAnimatorNS.DecorationType.None);
            this.picbook.Location = new System.Drawing.Point(92, 279);
            this.picbook.Name = "picbook";
            this.picbook.Size = new System.Drawing.Size(157, 118);
            this.picbook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbook.TabIndex = 6;
            this.picbook.TabStop = false;
            // 
            // Data
            // 
            this.Data.BaseColor = System.Drawing.Color.White;
            this.Data.BorderColor = System.Drawing.Color.Silver;
            this.Data.CustomFormat = null;
            this.Transition.SetDecoration(this.Data, BunifuAnimatorNS.DecorationType.None);
            this.Data.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Data.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.Data.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Data.ForeColor = System.Drawing.Color.Black;
            this.Data.Location = new System.Drawing.Point(28, 88);
            this.Data.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Data.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Data.Name = "Data";
            this.Data.OnHoverBaseColor = System.Drawing.Color.White;
            this.Data.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.Data.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.Data.OnPressedColor = System.Drawing.Color.Black;
            this.Data.Size = new System.Drawing.Size(298, 30);
            this.Data.TabIndex = 1;
            this.Data.Text = "Saturday, November 9, 2019";
            this.Data.Value = new System.DateTime(2019, 11, 9, 15, 49, 46, 25);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.Transition.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.label9.Location = new System.Drawing.Point(248, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "تاريخ النشر";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.Transition.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Location = new System.Drawing.Point(248, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "تقييم الكتاب";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.Transition.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Location = new System.Drawing.Point(248, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "غلاف الكتاب";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.Transition.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Location = new System.Drawing.Point(248, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "اسم الكتاب";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.comitems);
            this.groupBox1.Controls.Add(this.txtprise);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnamefile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbookname);
            this.groupBox1.Controls.Add(this.label2);
            this.Transition.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(465, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(350, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المعلومات الاساسية";
            // 
            // comitems
            // 
            this.comitems.AutoCompleteCustomSource.AddRange(new string[] {
            "برمجة",
            "هندسة",
            "طب",
            "تقنية"});
            this.comitems.BackColor = System.Drawing.Color.Transparent;
            this.comitems.BaseColor = System.Drawing.Color.White;
            this.comitems.BorderColor = System.Drawing.Color.Silver;
            this.Transition.SetDecoration(this.comitems, BunifuAnimatorNS.DecorationType.None);
            this.comitems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comitems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comitems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comitems.FocusedColor = System.Drawing.Color.Empty;
            this.comitems.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comitems.ForeColor = System.Drawing.Color.Black;
            this.comitems.FormattingEnabled = true;
            this.comitems.Location = new System.Drawing.Point(10, 300);
            this.comitems.Name = "comitems";
            this.comitems.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comitems.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comitems.Size = new System.Drawing.Size(327, 31);
            this.comitems.TabIndex = 7;
            this.comitems.SelectedIndexChanged += new System.EventHandler(this.comitems_SelectedIndexChanged);
            // 
            // txtprise
            // 
            this.txtprise.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtprise.BackColor = System.Drawing.SystemColors.Control;
            this.txtprise.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Transition.SetDecoration(this.txtprise, BunifuAnimatorNS.DecorationType.None);
            this.txtprise.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.txtprise.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprise.LineColor = System.Drawing.Color.Gainsboro;
            this.txtprise.Location = new System.Drawing.Point(10, 406);
            this.txtprise.Name = "txtprise";
            this.txtprise.PasswordChar = '\0';
            this.txtprise.Size = new System.Drawing.Size(329, 37);
            this.txtprise.TabIndex = 1;
            this.txtprise.TextChanged += new System.EventHandler(this.txtprise_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.Transition.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Location = new System.Drawing.Point(246, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "سعر الكتاب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.Transition.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Location = new System.Drawing.Point(246, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "صنف الكتاب";
            // 
            // txtnamefile
            // 
            this.txtnamefile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnamefile.BackColor = System.Drawing.SystemColors.Control;
            this.txtnamefile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Transition.SetDecoration(this.txtnamefile, BunifuAnimatorNS.DecorationType.None);
            this.txtnamefile.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.txtnamefile.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamefile.LineColor = System.Drawing.Color.Gainsboro;
            this.txtnamefile.Location = new System.Drawing.Point(10, 192);
            this.txtnamefile.Name = "txtnamefile";
            this.txtnamefile.PasswordChar = '\0';
            this.txtnamefile.Size = new System.Drawing.Size(329, 37);
            this.txtnamefile.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.Transition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Location = new System.Drawing.Point(259, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "اسم المؤلف";
            // 
            // txtbookname
            // 
            this.txtbookname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbookname.BackColor = System.Drawing.SystemColors.Control;
            this.txtbookname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Transition.SetDecoration(this.txtbookname, BunifuAnimatorNS.DecorationType.None);
            this.txtbookname.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.txtbookname.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookname.LineColor = System.Drawing.Color.Gainsboro;
            this.txtbookname.Location = new System.Drawing.Point(10, 92);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.PasswordChar = '\0';
            this.txtbookname.Size = new System.Drawing.Size(329, 37);
            this.txtbookname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.Transition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Location = new System.Drawing.Point(257, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم الكتاب";
            // 
            // Transition
            // 
            this.Transition.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.Transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Transition.DefaultAnimation = animation1;
            this.Transition.MaxAnimationTime = 700;
            // 
            // Add_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1485, 874);
            this.Controls.Add(this.gunaLinePanel1);
            this.Transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Add_Books";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Add_Books_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        public Guna.UI.WinForms.GunaAdvenceButton BunAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        public Bunifu.Framework.UI.BunifuRating RatingBooks;
        private Guna.UI.WinForms.GunaButton Selectphoto;
        public Guna.UI.WinForms.GunaDateTimePicker Data;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        public Guna.UI.WinForms.GunaComboBox comitems;
        public Guna.UI.WinForms.GunaLineTextBox txtprise;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaLineTextBox txtnamefile;
        private System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaLineTextBox txtbookname;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        public Guna.UI.WinForms.GunaPictureBox picbook;
        private BunifuAnimatorNS.BunifuTransition Transition;
    }
}