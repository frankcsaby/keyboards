namespace keyboards
{
    partial class Keyboards
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Keyboards));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            panel3 = new Panel();
            usr_txtbox = new TextBox();
            pwd_txtbox = new TextBox();
            log_in_btn = new Button();
            metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(157, 29);
            label1.Name = "label1";
            label1.Size = new Size(78, 33);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(114, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(142, 199);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 2;
            label2.Text = "Please Sign In.";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(298, 324);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 230, 213);
            panel1.Location = new Point(78, 360);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(298, 324);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(1, 230, 213);
            panel2.Location = new Point(78, 360);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 1);
            panel2.TabIndex = 5;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(298, 278);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(1, 230, 213);
            panel3.Location = new Point(78, 314);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 1);
            panel3.TabIndex = 5;
            // 
            // usr_txtbox
            // 
            usr_txtbox.BackColor = SystemColors.ActiveCaptionText;
            usr_txtbox.BorderStyle = BorderStyle.None;
            usr_txtbox.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            usr_txtbox.ForeColor = Color.White;
            usr_txtbox.Location = new Point(78, 278);
            usr_txtbox.Name = "usr_txtbox";
            usr_txtbox.PlaceholderText = "Username:";
            usr_txtbox.Size = new Size(214, 26);
            usr_txtbox.TabIndex = 6;
            usr_txtbox.TextAlign = HorizontalAlignment.Right;
            // 
            // pwd_txtbox
            // 
            pwd_txtbox.BackColor = SystemColors.ActiveCaptionText;
            pwd_txtbox.BorderStyle = BorderStyle.None;
            pwd_txtbox.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            pwd_txtbox.ForeColor = Color.White;
            pwd_txtbox.Location = new Point(78, 324);
            pwd_txtbox.Name = "pwd_txtbox";
            pwd_txtbox.PasswordChar = '*';
            pwd_txtbox.PlaceholderText = "Password:";
            pwd_txtbox.Size = new Size(214, 26);
            pwd_txtbox.TabIndex = 6;
            pwd_txtbox.TextAlign = HorizontalAlignment.Right;
            // 
            // log_in_btn
            // 
            log_in_btn.BackColor = Color.FromArgb(1, 230, 213);
            log_in_btn.Cursor = Cursors.Hand;
            log_in_btn.FlatStyle = FlatStyle.Flat;
            log_in_btn.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            log_in_btn.ForeColor = Color.Black;
            log_in_btn.Location = new Point(160, 392);
            log_in_btn.Name = "log_in_btn";
            log_in_btn.Size = new Size(75, 29);
            log_in_btn.TabIndex = 7;
            log_in_btn.Text = "Log In";
            log_in_btn.UseVisualStyleBackColor = false;
            log_in_btn.Click += log_in_btn_Click;
            // 
            // metroSetControlBox1
            // 
            metroSetControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroSetControlBox1.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroSetControlBox1.CloseHoverForeColor = Color.White;
            metroSetControlBox1.CloseNormalForeColor = Color.Gray;
            metroSetControlBox1.DisabledForeColor = Color.DimGray;
            metroSetControlBox1.IsDerivedStyle = true;
            metroSetControlBox1.Location = new Point(-64, -1);
            metroSetControlBox1.MaximizeBox = false;
            metroSetControlBox1.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox1.MaximizeHoverForeColor = Color.Gray;
            metroSetControlBox1.MaximizeNormalForeColor = Color.Gray;
            metroSetControlBox1.MinimizeBox = false;
            metroSetControlBox1.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox1.MinimizeHoverForeColor = Color.Gray;
            metroSetControlBox1.MinimizeNormalForeColor = Color.Gray;
            metroSetControlBox1.Name = "metroSetControlBox1";
            metroSetControlBox1.Size = new Size(100, 25);
            metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetControlBox1.StyleManager = null;
            metroSetControlBox1.TabIndex = 8;
            metroSetControlBox1.Text = "metroSetControlBox1";
            metroSetControlBox1.ThemeAuthor = "Narwin";
            metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // Keyboards
            // 
            AllowResize = false;
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaptionText;
            BackgroundColor = Color.Black;
            ClientSize = new Size(416, 450);
            Controls.Add(metroSetControlBox1);
            Controls.Add(log_in_btn);
            Controls.Add(pwd_txtbox);
            Controls.Add(usr_txtbox);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            DropShadowEffect = false;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Keyboards";
            Padding = new Padding(12, 90, 12, 12);
            ShowLeftRect = false;
            ShowTitle = false;
            Style = MetroSet_UI.Enums.Style.Custom;
            Text = "KEYBOARDS";
            Load += Keyboards_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Panel panel2;
        private PictureBox pictureBox5;
        private Panel panel3;
        private TextBox usr_txtbox;
        private TextBox pwd_txtbox;
        private Button log_in_btn;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
    }
}