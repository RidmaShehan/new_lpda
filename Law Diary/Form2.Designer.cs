namespace Law_Diary
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            openFileDialog1 = new OpenFileDialog();
            label5 = new Label();
            textBox1 = new TextBox();
            vScrollBar1 = new VScrollBar();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button2 = new Button();
            hScrollBar1 = new HScrollBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 290);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Filing Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 334);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 2;
            label2.Text = "First Hearing Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 379);
            label3.Name = "label3";
            label3.Size = new Size(114, 30);
            label3.TabIndex = 3;
            label3.Text = "Subsequent Hearing\r\nDate\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 422);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 4;
            label4.Text = "Deadline Dates";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(328, 290);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(188, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(328, 373);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(188, 23);
            dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(328, 414);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(188, 23);
            dateTimePicker3.TabIndex = 7;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(328, 328);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(188, 23);
            dateTimePicker4.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(612, 241);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 9;
            label5.Text = "Attach File";
            label5.Click += label5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(612, 316);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 23);
            textBox1.TabIndex = 10;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(895, 316);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(10, 23);
            vScrollBar1.TabIndex = 12;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Artboard_173;
            pictureBox1.Location = new Point(-8, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1146, 637);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(817, 468);
            button1.Name = "button1";
            button1.Size = new Size(75, 43);
            button1.TabIndex = 16;
            button1.Text = "N E X T";
            button1.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(690, 389);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(59, 19);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Active";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(690, 414);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(62, 19);
            checkBox2.TabIndex = 19;
            checkBox2.Text = "Closed";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(794, 402);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(84, 19);
            checkBox3.TabIndex = 20;
            checkBox3.Text = "In Progress";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(655, 468);
            button2.Name = "button2";
            button2.Size = new Size(75, 43);
            button2.TabIndex = 21;
            button2.Text = "ADD CASE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(612, 342);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(280, 11);
            hScrollBar1.TabIndex = 22;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 622);
            Controls.Add(hScrollBar1);
            Controls.Add(button2);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(vScrollBar1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker4);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                // Perform actions when "In Progress" status is selected
                // ...
            }
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private OpenFileDialog openFileDialog1;
        private Label label5;
        private TextBox textBox1;
        private VScrollBar vScrollBar1;
        private PictureBox pictureBox1;
        private Button button1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button2;
        private HScrollBar hScrollBar1;
    }
}