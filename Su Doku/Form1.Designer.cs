namespace Su_Doku
{
    partial class Form1
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.hintButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(100, 185);
            this.panel1.MaximumSize = new System.Drawing.Size(400, 400);
            this.panel1.MinimumSize = new System.Drawing.Size(400, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 0;
            // 
            // hintButton
            // 
            this.hintButton.BackColor = System.Drawing.Color.Transparent;
            this.hintButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hintButton.BackgroundImage")));
            this.hintButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hintButton.FlatAppearance.BorderSize = 0;
            this.hintButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hintButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hintButton.Location = new System.Drawing.Point(636, 126);
            this.hintButton.Name = "hintButton";
            this.hintButton.Size = new System.Drawing.Size(118, 122);
            this.hintButton.TabIndex = 1;
            this.hintButton.UseVisualStyleBackColor = false;
            this.hintButton.Image = Properties.Resources.Hint;
            this.hintButton.Click += new System.EventHandler(this.hintButton_Click);
            this.hintButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hintButton_MouseDown);
            this.hintButton.MouseLeave += new System.EventHandler(this.hintButton_MouseLeave);
            this.hintButton.MouseHover += new System.EventHandler(this.hintButton_MouseHover);
            this.hintButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hintButton_MouseMove);
            // 
            // clearAllButton
            // 
            this.clearAllButton.BackColor = System.Drawing.Color.Transparent;
            this.clearAllButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearAllButton.BackgroundImage")));
            this.clearAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clearAllButton.FlatAppearance.BorderSize = 0;
            this.clearAllButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clearAllButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAllButton.Location = new System.Drawing.Point(812, 141);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(185, 93);
            this.clearAllButton.TabIndex = 2;
            this.clearAllButton.UseVisualStyleBackColor = false;
            this.clearAllButton.Image = Properties.Resources.clearall;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            this.clearAllButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clearAllButton_MouseDown);
            this.clearAllButton.MouseLeave += new System.EventHandler(this.clearAllButton_MouseLeave);
            this.clearAllButton.MouseHover += new System.EventHandler(this.clearAllButton_MouseHover);
            this.clearAllButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.clearAllButton_MouseMove);
            this.clearAllButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clearAllButton_MouseUp);
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.Transparent;
            this.checkButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkButton.BackgroundImage")));
            this.checkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkButton.FlatAppearance.BorderSize = 0;
            this.checkButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.checkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkButton.Location = new System.Drawing.Point(695, 385);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(203, 97);
            this.checkButton.TabIndex = 3;
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Image = Properties.Resources.check;
            this.checkButton.Click += new System.EventHandler(this.doneButton_Click);
            this.checkButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkButton_MouseDown);
            this.checkButton.MouseLeave += new System.EventHandler(this.checkButton_MouseLeave);
            this.checkButton.MouseHover += new System.EventHandler(this.checkButton_MouseHover);
            this.checkButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.checkButton_MouseMove);
            this.checkButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkButton_MouseUp);
            // 
            // newGameButton
            // 
            this.newGameButton.BackColor = System.Drawing.Color.Transparent;
            this.newGameButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newGameButton.BackgroundImage")));
            this.newGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newGameButton.FlatAppearance.BorderSize = 0;
            this.newGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.newGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.newGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGameButton.Location = new System.Drawing.Point(675, 500);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(259, 98);
            this.newGameButton.TabIndex = 4;
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Image = Properties.Resources.NextGame;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            this.newGameButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newGameButton_MouseDown);
            this.newGameButton.MouseLeave += new System.EventHandler(this.newGameButton_MouseLeave);
            this.newGameButton.MouseHover += new System.EventHandler(this.newGameButton_MouseHover);
            this.newGameButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.newGameButton_MouseMove);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(95, 621);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(40, 40);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(40, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(137, 621);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(40, 40);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(40, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(179, 621);
            this.pictureBox3.MaximumSize = new System.Drawing.Size(40, 40);
            this.pictureBox3.MinimumSize = new System.Drawing.Size(40, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(221, 621);
            this.pictureBox4.MaximumSize = new System.Drawing.Size(40, 40);
            this.pictureBox4.MinimumSize = new System.Drawing.Size(40, 40);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(263, 621);
            this.pictureBox5.MaximumSize = new System.Drawing.Size(40, 40);
            this.pictureBox5.MinimumSize = new System.Drawing.Size(40, 40);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(305, 621);
            this.pictureBox6.MaximumSize = new System.Drawing.Size(40, 40);
            this.pictureBox6.MinimumSize = new System.Drawing.Size(40, 40);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 40);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(389, 621);
            this.pictureBox7.MaximumSize = new System.Drawing.Size(40, 40);
            this.pictureBox7.MinimumSize = new System.Drawing.Size(40, 40);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 40);
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(347, 621);
            this.pictureBox8.MaximumSize = new System.Drawing.Size(40, 40);
            this.pictureBox8.MinimumSize = new System.Drawing.Size(40, 40);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(40, 40);
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(431, 621);
            this.pictureBox9.MaximumSize = new System.Drawing.Size(40, 40);
            this.pictureBox9.MinimumSize = new System.Drawing.Size(40, 40);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(40, 40);
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox10.Location = new System.Drawing.Point(120, 35);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(336, 117);
            this.pictureBox10.TabIndex = 14;
            this.pictureBox10.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(95, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 400);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitButton.Location = new System.Drawing.Point(561, 609);
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(95, 66);
            this.exitButton.TabIndex = 16;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            this.exitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exitButton_MouseDown);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            this.exitButton.MouseHover += new System.EventHandler(this.exitButton_MouseHover);
            this.exitButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.exitButton_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1075, 718);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.hintButton);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Su Doku";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        private void exitButton_MouseMove(object sender, MouseEventArgs e)
        {
            this.exitButton.BackColor = Color.Transparent;
            this.exitButton.Image = Properties.Resources.exit_hover;
        }

        private void exitButton_MouseHover(object sender, EventArgs e)
        {
            this.exitButton.BackColor = Color.Transparent;
            this.exitButton.Image = Properties.Resources.exit_hover;
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            this.exitButton.BackColor = Color.Transparent;
            this.exitButton.Image = Properties.Resources.Exit;
        }

        private void exitButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.exitButton.BackColor = Color.Transparent;
            this.exitButton.Image = Properties.Resources.exit_click;
        }

        //hintButton
        void hintButton_MouseMove(object sender, MouseEventArgs e)
        {
            this.hintButton.BackColor = Color.Transparent;
            this.hintButton.Image = Properties.Resources.hint_hover;
        }

        void hintButton_MouseHover(object sender, EventArgs e)
        {
            hintButton.BackColor = Color.Transparent;
            this.hintButton.Image = Properties.Resources.hint_hover;
        }

        void hintButton_MouseLeave(object sender, EventArgs e)
        {
            hintButton.BackColor= Color.Transparent;
            this.hintButton.Image = Properties.Resources.Hint;
        }

        private void hintButton_MouseDown(object sender, EventArgs e)
        {
            hintButton.BackColor = Color.Transparent;
            this.hintButton.Image = Properties.Resources.hint_clicked;
        }

        //clearAllButton
        private void clearAllButton_MouseMove(object sender, MouseEventArgs e)
        {
            clearAllButton.BackColor = Color.Transparent;
            this.clearAllButton.Image = Properties.Resources.clearall_hover;
        }

        private void clearAllButton_MouseLeave(object sender, EventArgs e)
        {
            clearAllButton.BackColor = Color.Transparent;
            this.clearAllButton.Image = Properties.Resources.clearall;
        }

        private void clearAllButton_MouseHover(object sender, EventArgs e)
        {
            clearAllButton.BackColor = Color.Transparent;
            this.clearAllButton.Image = Properties.Resources.clearall_hover;
        }

        private void clearAllButton_MouseUp(object sender, MouseEventArgs e)
        {
            clearAllButton.BackColor = Color.Transparent;
            this.clearAllButton.Image = Properties.Resources.clearall;
        }

        private void clearAllButton_MouseDown(object sender, MouseEventArgs e)
        {
            clearAllButton.BackColor = Color.Transparent;
            this.clearAllButton.Image = Properties.Resources.clearall_clicked;
        }

        //checkButton
        private void checkButton_MouseMove(object sender, MouseEventArgs e)
        {
            checkButton.BackColor = Color.Transparent;
            this.checkButton.Image = Properties.Resources.check_hover;
        }

        private void checkButton_MouseHover(object sender, EventArgs e)
        {
            checkButton.BackColor = Color.Transparent;
            this.checkButton.Image = Properties.Resources.check_hover;
        }

            private void checkButton_MouseLeave(object sender, System.EventArgs e)
        {

            checkButton.BackColor = Color.Transparent;
            this.checkButton.Image = Properties.Resources.check;
        }

        private void checkButton_MouseDown(object sender, MouseEventArgs e)
        {
            checkButton.BackColor = Color.Transparent;
            this.checkButton.Image = Properties.Resources.check;
        }

        private void checkButton_MouseClick(object sender, MouseEventArgs e)
        {

            checkButton.BackColor = Color.Transparent;
            this.checkButton.Image = Properties.Resources.check_clicked;
        }

        private void checkButton_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            checkButton.BackColor = Color.Transparent;
            this.checkButton.Image = Properties.Resources.check;
        }

        //newGameButton
        void newGameButton_MouseMove(object sender, MouseEventArgs e)
        {
            newGameButton.BackColor = Color.Transparent;
            this.newGameButton.Image = Properties.Resources.nextgame_hover;
        }

            void newGameButton_MouseHover(object sender, EventArgs e)
        {
            newGameButton.BackColor = Color.Transparent;
            this.newGameButton.Image = Properties.Resources.nextgame_hover;
        }

        void newGameButton_MouseLeave(object sender, EventArgs e)
        {
            newGameButton.BackColor = Color.Transparent;
            this.newGameButton.Image = Properties.Resources.NextGame;
        }

        private void newGameButton_MouseDown(object sender, MouseEventArgs e)
        {
            newGameButton.BackColor = Color.Transparent;
            this.newGameButton.Image = Properties.Resources.nextgame_clicked;
        }



        #endregion

        private Panel panel1;
        private Button hintButton;
        private Button clearAllButton;
        private Button checkButton;
       
        private Button newGameButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private Panel panel2;
        private Button exitButton;
    }
}