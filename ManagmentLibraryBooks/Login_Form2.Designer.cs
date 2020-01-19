namespace ManagmentLibraryBooks
{
    partial class Login_Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaProgressBar1 = new Guna.UI.WinForms.GunaProgressBar();
            this.TextBox_Pass = new Guna.UI.WinForms.GunaLineTextBox();
            this.TextBox_User = new Guna.UI.WinForms.GunaLineTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.Button1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gunaProgressBar1);
            this.panel1.Controls.Add(this.TextBox_Pass);
            this.panel1.Controls.Add(this.TextBox_User);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Button1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.Transition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(384, 192);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 676);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.Transition.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Aldhabi", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 66);
            this.label4.TabIndex = 14;
            this.label4.Text = "مرحباً بك في برنامج إدارة مكتبة الكتب";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.Transition.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Sakkal Majalla", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(531, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.Transition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "من ملفات المستخدم ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.Transition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "يتم تحميل";
            // 
            // gunaProgressBar1
            // 
            this.gunaProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.gunaProgressBar1.BorderColor = System.Drawing.Color.Black;
            this.gunaProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.Transition.SetDecoration(this.gunaProgressBar1, BunifuAnimatorNS.DecorationType.None);
            this.gunaProgressBar1.IdleColor = System.Drawing.Color.Black;
            this.gunaProgressBar1.Location = new System.Drawing.Point(82, 620);
            this.gunaProgressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gunaProgressBar1.Name = "gunaProgressBar1";
            this.gunaProgressBar1.ProgressMaxColor = System.Drawing.Color.White;
            this.gunaProgressBar1.ProgressMinColor = System.Drawing.Color.Black;
            this.gunaProgressBar1.Radius = 4;
            this.gunaProgressBar1.Size = new System.Drawing.Size(885, 12);
            this.gunaProgressBar1.TabIndex = 12;
            this.gunaProgressBar1.Visible = false;
            // 
            // TextBox_Pass
            // 
            this.TextBox_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_Pass.BackColor = System.Drawing.Color.Black;
            this.TextBox_Pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Transition.SetDecoration(this.TextBox_Pass, BunifuAnimatorNS.DecorationType.None);
            this.TextBox_Pass.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(196)))), ((int)(((byte)(120)))));
            this.TextBox_Pass.Font = new System.Drawing.Font("Sakkal Majalla", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Pass.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBox_Pass.Location = new System.Drawing.Point(335, 383);
            this.TextBox_Pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_Pass.Name = "TextBox_Pass";
            this.TextBox_Pass.PasswordChar = '\0';
            this.TextBox_Pass.Size = new System.Drawing.Size(324, 53);
            this.TextBox_Pass.TabIndex = 1;
            this.TextBox_Pass.Text = "ادخل كلمة المرور";
            this.TextBox_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_Pass.TextChanged += new System.EventHandler(this.TextBox_Pass_TextChanged);
            this.TextBox_Pass.Click += new System.EventHandler(this.gunaLineTextBox2_Click_1);
            // 
            // TextBox_User
            // 
            this.TextBox_User.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_User.BackColor = System.Drawing.Color.Black;
            this.TextBox_User.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Transition.SetDecoration(this.TextBox_User, BunifuAnimatorNS.DecorationType.None);
            this.TextBox_User.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(196)))), ((int)(((byte)(120)))));
            this.TextBox_User.Font = new System.Drawing.Font("Sakkal Majalla", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_User.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBox_User.Location = new System.Drawing.Point(335, 331);
            this.TextBox_User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_User.Name = "TextBox_User";
            this.TextBox_User.PasswordChar = '\0';
            this.TextBox_User.Size = new System.Drawing.Size(324, 53);
            this.TextBox_User.TabIndex = 0;
            this.TextBox_User.Text = "ادخل اسم المستخدم";
            this.TextBox_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_User.Click += new System.EventHandler(this.gunaLineTextBox1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.gunaControlBox1);
            this.Transition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 35);
            this.panel2.TabIndex = 11;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.Transition.SetDecoration(this.gunaControlBox1, BunifuAnimatorNS.DecorationType.None);
            this.gunaControlBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaControlBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(51, 33);
            this.gunaControlBox1.TabIndex = 0;
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button1.AnimationHoverSpeed = 0.07F;
            this.Button1.AnimationSpeed = 0.03F;
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.BaseColor = System.Drawing.Color.Transparent;
            this.Button1.BorderColor = System.Drawing.Color.White;
            this.Button1.BorderSize = 1;
            this.Button1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.Button1.CheckedBorderColor = System.Drawing.Color.White;
            this.Button1.CheckedForeColor = System.Drawing.Color.White;
            this.Button1.CheckedImage = null;
            this.Button1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transition.SetDecoration(this.Button1, BunifuAnimatorNS.DecorationType.None);
            this.Button1.FocusedColor = System.Drawing.Color.Empty;
            this.Button1.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Image = null;
            this.Button1.ImageSize = new System.Drawing.Size(20, 20);
            this.Button1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.Button1.Location = new System.Drawing.Point(337, 484);
            this.Button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button1.Name = "Button1";
            this.Button1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(196)))), ((int)(((byte)(120)))));
            this.Button1.OnHoverForeColor = System.Drawing.Color.White;
            this.Button1.OnHoverImage = null;
            this.Button1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(196)))), ((int)(((byte)(120)))));
            this.Button1.OnPressedColor = System.Drawing.Color.Black;
            this.Button1.Radius = 15;
            this.Button1.Size = new System.Drawing.Size(373, 52);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "تسجيل الدخول";
            this.Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Transition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(668, 389);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 43);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Transition.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(434, 142);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 160);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Transition.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(668, 331);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 43);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Transition.DefaultAnimation = animation1;
            this.Transition.MaxAnimationTime = 700;
            // 
            // Login_Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1818, 1062);
            this.Controls.Add(this.panel1);
            this.Transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login_Form2";
            this.Opacity = 0.8D;
            this.Text = "Login_Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaProgressBar gunaProgressBar1;
        private Guna.UI.WinForms.GunaLineTextBox TextBox_Pass;
        private Guna.UI.WinForms.GunaLineTextBox TextBox_User;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        public Guna.UI.WinForms.GunaAdvenceButton Button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BunifuAnimatorNS.BunifuTransition Transition;
    }
}