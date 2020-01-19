namespace ManagmentLibraryBooks.PL
{
    partial class Add_Cat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Cat));
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.TexCAt = new Guna.UI.WinForms.GunaLineTextBox();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLinePanel1.BackColor = System.Drawing.SystemColors.Control;
            this.gunaLinePanel1.Controls.Add(this.gunaControlBox1);
            this.gunaLinePanel1.Controls.Add(this.BTN_ADD);
            this.gunaLinePanel1.Controls.Add(this.TexCAt);
            this.gunaLinePanel1.Controls.Add(this.Title_Label);
            this.Transition.SetDecoration(this.gunaLinePanel1, BunifuAnimatorNS.DecorationType.None);
            this.gunaLinePanel1.LineBottom = 3;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.gunaLinePanel1.LineLeft = 3;
            this.gunaLinePanel1.LineRight = 3;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 30;
            this.gunaLinePanel1.Location = new System.Drawing.Point(397, 52);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(445, 464);
            this.gunaLinePanel1.TabIndex = 1;
            this.gunaLinePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaLinePanel1_Paint);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.gunaControlBox1, BunifuAnimatorNS.DecorationType.None);
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(0, 3);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(32, 23);
            this.gunaControlBox1.TabIndex = 8;
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.BackColor = System.Drawing.Color.Gainsboro;
            this.Transition.SetDecoration(this.BTN_ADD, BunifuAnimatorNS.DecorationType.None);
            this.BTN_ADD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.BTN_ADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.BTN_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ADD.Font = new System.Drawing.Font("Sakkal Majalla", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ADD.ForeColor = System.Drawing.Color.White;
            this.BTN_ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_ADD.Location = new System.Drawing.Point(105, 299);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTN_ADD.Size = new System.Drawing.Size(240, 52);
            this.BTN_ADD.TabIndex = 7;
            this.BTN_ADD.Text = "اضافه";
            this.BTN_ADD.UseVisualStyleBackColor = false;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click_1);
            // 
            // TexCAt
            // 
            this.TexCAt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TexCAt.BackColor = System.Drawing.SystemColors.Control;
            this.TexCAt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Transition.SetDecoration(this.TexCAt, BunifuAnimatorNS.DecorationType.None);
            this.TexCAt.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.TexCAt.Font = new System.Drawing.Font("Sakkal Majalla", 30F, System.Drawing.FontStyle.Bold);
            this.TexCAt.LineColor = System.Drawing.Color.White;
            this.TexCAt.Location = new System.Drawing.Point(70, 197);
            this.TexCAt.Name = "TexCAt";
            this.TexCAt.PasswordChar = '\0';
            this.TexCAt.Size = new System.Drawing.Size(317, 66);
            this.TexCAt.TabIndex = 6;
            // 
            // Title_Label
            // 
            this.Transition.SetDecoration(this.Title_Label, BunifuAnimatorNS.DecorationType.None);
            this.Title_Label.Font = new System.Drawing.Font("Sakkal Majalla", 35F, System.Drawing.FontStyle.Bold);
            this.Title_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Title_Label.Location = new System.Drawing.Point(70, 108);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(304, 65);
            this.Title_Label.TabIndex = 5;
            this.Title_Label.Text = "ادخل صنف الكتاب";
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
            // Add_Cat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1271, 647);
            this.Controls.Add(this.gunaLinePanel1);
            this.Transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Add_Cat";
            this.Opacity = 0.96D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Cat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Add_Cat_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        public System.Windows.Forms.Button BTN_ADD;
        public Guna.UI.WinForms.GunaLineTextBox TexCAt;
        private System.Windows.Forms.Label Title_Label;
        private BunifuAnimatorNS.BunifuTransition Transition;
    }
}