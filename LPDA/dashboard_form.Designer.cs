namespace LPDA
{
    partial class dashboard_form
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
            this.CR = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu_tag = new System.Windows.Forms.Label();
            this.munu_tag_icon_picture = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.home_contener = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.SidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel11 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.HomeTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.munu_tag_icon_picture)).BeginInit();
            this.home_contener.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // CR
            // 
            this.CR.Location = new System.Drawing.Point(655, 46);
            this.CR.Name = "CR";
            this.CR.Size = new System.Drawing.Size(253, 102);
            this.CR.TabIndex = 1;
            this.CR.Text = "c_R";
            this.CR.UseVisualStyleBackColor = true;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.home_contener);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(310, 1033);
            this.sidebar.MinimumSize = new System.Drawing.Size(130, 1033);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(310, 1033);
            this.sidebar.TabIndex = 2;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menu_tag);
            this.panel1.Controls.Add(this.munu_tag_icon_picture);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 113);
            this.panel1.TabIndex = 3;
            // 
            // menu_tag
            // 
            this.menu_tag.AutoSize = true;
            this.menu_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_tag.ForeColor = System.Drawing.Color.White;
            this.menu_tag.Location = new System.Drawing.Point(126, 43);
            this.menu_tag.Name = "menu_tag";
            this.menu_tag.Size = new System.Drawing.Size(62, 20);
            this.menu_tag.TabIndex = 4;
            this.menu_tag.Text = "MENU";
            // 
            // munu_tag_icon_picture
            // 
            this.munu_tag_icon_picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.munu_tag_icon_picture.Image = global::LPDA.Properties.Resources.Artboard_23;
            this.munu_tag_icon_picture.Location = new System.Drawing.Point(29, 34);
            this.munu_tag_icon_picture.Name = "munu_tag_icon_picture";
            this.munu_tag_icon_picture.Size = new System.Drawing.Size(67, 41);
            this.munu_tag_icon_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.munu_tag_icon_picture.TabIndex = 4;
            this.munu_tag_icon_picture.TabStop = false;
            this.munu_tag_icon_picture.Click += new System.EventHandler(this.munu_tag_icon_picture_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.panel7.Location = new System.Drawing.Point(313, -3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1592, 116);
            this.panel7.TabIndex = 3;
            // 
            // home_contener
            // 
            this.home_contener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.home_contener.Controls.Add(this.panel13);
            this.home_contener.Controls.Add(this.panel12);
            this.home_contener.Controls.Add(this.panel9);
            this.home_contener.Controls.Add(this.panel2);
            this.home_contener.Controls.Add(this.panel10);
            this.home_contener.Location = new System.Drawing.Point(3, 122);
            this.home_contener.MaximumSize = new System.Drawing.Size(357, 350);
            this.home_contener.MinimumSize = new System.Drawing.Size(357, 98);
            this.home_contener.Name = "home_contener";
            this.home_contener.Size = new System.Drawing.Size(357, 98);
            this.home_contener.TabIndex = 4;
            this.home_contener.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel13.Controls.Add(this.button10);
            this.panel13.Location = new System.Drawing.Point(0, 277);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(357, 49);
            this.panel13.TabIndex = 4;
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = global::LPDA.Properties.Resources.Artboard_34;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(-18, -7);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(385, 67);
            this.button10.TabIndex = 3;
            this.button10.Text = "           ALL CLIENT";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel12.Controls.Add(this.button9);
            this.panel12.Location = new System.Drawing.Point(3, 222);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(357, 49);
            this.panel12.TabIndex = 4;
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = global::LPDA.Properties.Resources.Artboard_34;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(-20, -7);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(385, 67);
            this.button9.TabIndex = 3;
            this.button9.Text = "           DAILY UPDATES";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel9.Controls.Add(this.button5);
            this.panel9.Location = new System.Drawing.Point(3, 112);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(357, 49);
            this.panel9.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::LPDA.Properties.Resources.Artboard_34;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-17, -11);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(385, 67);
            this.button5.TabIndex = 3;
            this.button5.Text = "           ADD CLIENT";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 103);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::LPDA.Properties.Resources.Artboard_251;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-17, -12);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(385, 124);
            this.button1.TabIndex = 3;
            this.button1.Text = "                 HOME";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel10.Controls.Add(this.button7);
            this.panel10.Location = new System.Drawing.Point(3, 167);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(357, 49);
            this.panel10.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::LPDA.Properties.Resources.Artboard_34_copy1;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(-17, -9);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(385, 67);
            this.button7.TabIndex = 3;
            this.button7.Text = "           TASK";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(3, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 103);
            this.panel3.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::LPDA.Properties.Resources.Artboard_25_copy;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-17, -14);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(385, 128);
            this.button2.TabIndex = 3;
            this.button2.Text = "                 SETTING";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(3, 335);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 103);
            this.panel4.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::LPDA.Properties.Resources.Artboard_25_copy_2;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-17, -21);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(385, 133);
            this.button3.TabIndex = 3;
            this.button3.Text = "                 EVENTS";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button4);
            this.panel5.Location = new System.Drawing.Point(3, 444);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(357, 103);
            this.panel5.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::LPDA.Properties.Resources.Artboard_25_copy_3;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-17, -5);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(385, 120);
            this.button4.TabIndex = 3;
            this.button4.Text = "                 ABOUT ";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button6);
            this.panel6.Location = new System.Drawing.Point(3, 553);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(357, 103);
            this.panel6.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::LPDA.Properties.Resources.Artboard_25_copy_31;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-17, -5);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(385, 118);
            this.button6.TabIndex = 3;
            this.button6.Text = "                 HELP ";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // SidebarTimer
            // 
            this.SidebarTimer.Interval = 10;
            this.SidebarTimer.Tick += new System.EventHandler(this.SidebarTimer_Tick);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel11.Controls.Add(this.button8);
            this.panel11.Location = new System.Drawing.Point(943, 878);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(357, 103);
            this.panel11.TabIndex = 4;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::LPDA.Properties.Resources.Artboard_251;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(-17, -12);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(385, 124);
            this.button8.TabIndex = 3;
            this.button8.Text = "                 HOME";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomeTimer
            // 
            this.HomeTimer.Interval = 10;
            this.HomeTimer.Tick += new System.EventHandler(this.HomeTimer_Tick);
            // 
            // dashboard_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.CR);
            this.Name = "dashboard_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard_form";
            this.Load += new System.EventHandler(this.dashboard_form_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.munu_tag_icon_picture)).EndInit();
            this.home_contener.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CR;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox munu_tag_icon_picture;
        private System.Windows.Forms.Label menu_tag;
        private System.Windows.Forms.Timer SidebarTimer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel home_contener;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Timer HomeTimer;
    }
}