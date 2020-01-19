namespace ManagmentLibraryBooks
{
    partial class Cloosing_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cloosing_Form));
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.YES = new Bunifu.Framework.UI.BunifuThinButton2();
            this.NO = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.Title_Label = new System.Windows.Forms.Label();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLinePanel1.Controls.Add(this.YES);
            this.gunaLinePanel1.Controls.Add(this.NO);
            this.gunaLinePanel1.Controls.Add(this.gunaControlBox1);
            this.gunaLinePanel1.Controls.Add(this.Title_Label);
            this.gunaLinePanel1.LineBottom = 3;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Red;
            this.gunaLinePanel1.LineLeft = 3;
            this.gunaLinePanel1.LineRight = 3;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 35;
            this.gunaLinePanel1.Location = new System.Drawing.Point(472, 201);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(597, 200);
            this.gunaLinePanel1.TabIndex = 1;
            // 
            // YES
            // 
            this.YES.ActiveBorderThickness = 1;
            this.YES.ActiveCornerRadius = 20;
            this.YES.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.YES.ActiveForecolor = System.Drawing.Color.White;
            this.YES.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.YES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.YES.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("YES.BackgroundImage")));
            this.YES.ButtonText = "نعم";
            this.YES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YES.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YES.ForeColor = System.Drawing.Color.Red;
            this.YES.IdleBorderThickness = 1;
            this.YES.IdleCornerRadius = 20;
            this.YES.IdleFillColor = System.Drawing.Color.White;
            this.YES.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.YES.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.YES.Location = new System.Drawing.Point(375, 120);
            this.YES.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.YES.Name = "YES";
            this.YES.Size = new System.Drawing.Size(145, 51);
            this.YES.TabIndex = 5;
            this.YES.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.YES.Click += new System.EventHandler(this.YES_Click);
            // 
            // NO
            // 
            this.NO.ActiveBorderThickness = 1;
            this.NO.ActiveCornerRadius = 20;
            this.NO.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.NO.ActiveForecolor = System.Drawing.Color.White;
            this.NO.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.NO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.NO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NO.BackgroundImage")));
            this.NO.ButtonText = "لا";
            this.NO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NO.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NO.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.NO.IdleBorderThickness = 1;
            this.NO.IdleCornerRadius = 20;
            this.NO.IdleFillColor = System.Drawing.Color.White;
            this.NO.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.NO.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.NO.Location = new System.Drawing.Point(85, 120);
            this.NO.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(145, 51);
            this.NO.TabIndex = 5;
            this.NO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NO.Click += new System.EventHandler(this.NO_Click);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(35, 35);
            this.gunaControlBox1.TabIndex = 4;
            // 
            // Title_Label
            // 
            this.Title_Label.BackColor = System.Drawing.Color.Transparent;
            this.Title_Label.Font = new System.Drawing.Font("Sakkal Majalla", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Label.ForeColor = System.Drawing.Color.White;
            this.Title_Label.Location = new System.Drawing.Point(13, 57);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(570, 48);
            this.Title_Label.TabIndex = 3;
            this.Title_Label.Text = "هل تريد الخروج من جد ؟";
            this.Title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cloosing_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1540, 602);
            this.Controls.Add(this.gunaLinePanel1);
            this.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Cloosing_Form";
            this.Opacity = 0.93D;
            this.Text = "Cloosing_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cloosing_Form_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        public System.Windows.Forms.Label Title_Label;
        private Bunifu.Framework.UI.BunifuThinButton2 NO;
        private Bunifu.Framework.UI.BunifuThinButton2 YES;
    }
}