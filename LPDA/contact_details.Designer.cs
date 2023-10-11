namespace LPDA
{
    partial class contact_details
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
            this.Contact_personal_text = new System.Windows.Forms.TextBox();
            this.Contact_Home_text = new System.Windows.Forms.TextBox();
            this.Email_text = new System.Windows.Forms.TextBox();
            this.Address_text = new System.Windows.Forms.TextBox();
            this.Contact_personal_label = new System.Windows.Forms.Label();
            this.Contact_Home_label = new System.Windows.Forms.Label();
            this.Enter_Email_label = new System.Windows.Forms.Label();
            this.Address_label = new System.Windows.Forms.Label();
            this.Back_button = new System.Windows.Forms.Button();
            this.Next__button = new System.Windows.Forms.Button();
            this.City_text = new System.Windows.Forms.TextBox();
            this.Zip_code_text = new System.Windows.Forms.TextBox();
            this.City_label = new System.Windows.Forms.Label();
            this.Zip_code_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Correct_personal_contact_lable = new System.Windows.Forms.Label();
            this.correct_home_contact_lable = new System.Windows.Forms.Label();
            this.correct_Email_label = new System.Windows.Forms.Label();
            this.correct_Zip_Code_lable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Contact_personal_text
            // 
            this.Contact_personal_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_personal_text.Location = new System.Drawing.Point(295, 356);
            this.Contact_personal_text.MaxLength = 10;
            this.Contact_personal_text.Name = "Contact_personal_text";
            this.Contact_personal_text.Size = new System.Drawing.Size(433, 24);
            this.Contact_personal_text.TabIndex = 1;
            this.Contact_personal_text.TextChanged += new System.EventHandler(this.Contact_personal_text_TextChanged);
            this.Contact_personal_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Contact_personal_textBox_KeyDown);
            // 
            // Contact_Home_text
            // 
            this.Contact_Home_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_Home_text.Location = new System.Drawing.Point(295, 456);
            this.Contact_Home_text.Name = "Contact_Home_text";
            this.Contact_Home_text.Size = new System.Drawing.Size(433, 24);
            this.Contact_Home_text.TabIndex = 2;
            this.Contact_Home_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Contact_Home_text_KeyDown);
            // 
            // Email_text
            // 
            this.Email_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_text.Location = new System.Drawing.Point(295, 558);
            this.Email_text.Name = "Email_text";
            this.Email_text.Size = new System.Drawing.Size(433, 24);
            this.Email_text.TabIndex = 3;
            this.Email_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Email_text_KeyDown);
            // 
            // Address_text
            // 
            this.Address_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_text.Location = new System.Drawing.Point(855, 356);
            this.Address_text.Name = "Address_text";
            this.Address_text.Size = new System.Drawing.Size(433, 24);
            this.Address_text.TabIndex = 4;
            this.Address_text.TextChanged += new System.EventHandler(this.Address_text_TextChanged);
            this.Address_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Address_text_KeyDown);
            // 
            // Contact_personal_label
            // 
            this.Contact_personal_label.AutoSize = true;
            this.Contact_personal_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_personal_label.ForeColor = System.Drawing.Color.Red;
            this.Contact_personal_label.Location = new System.Drawing.Point(292, 384);
            this.Contact_personal_label.Name = "Contact_personal_label";
            this.Contact_personal_label.Size = new System.Drawing.Size(268, 18);
            this.Contact_personal_label.TabIndex = 5;
            this.Contact_personal_label.Text = "Please Enter the Contact NO(Personal)";
            this.Contact_personal_label.Visible = false;
            // 
            // Contact_Home_label
            // 
            this.Contact_Home_label.AutoSize = true;
            this.Contact_Home_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_Home_label.ForeColor = System.Drawing.Color.Red;
            this.Contact_Home_label.Location = new System.Drawing.Point(292, 481);
            this.Contact_Home_label.Name = "Contact_Home_label";
            this.Contact_Home_label.Size = new System.Drawing.Size(250, 18);
            this.Contact_Home_label.TabIndex = 6;
            this.Contact_Home_label.Text = "Please Enter the Contact NO(Home)";
            this.Contact_Home_label.Visible = false;
            // 
            // Enter_Email_label
            // 
            this.Enter_Email_label.AutoSize = true;
            this.Enter_Email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_Email_label.ForeColor = System.Drawing.Color.Red;
            this.Enter_Email_label.Location = new System.Drawing.Point(292, 583);
            this.Enter_Email_label.Name = "Enter_Email_label";
            this.Enter_Email_label.Size = new System.Drawing.Size(162, 18);
            this.Enter_Email_label.TabIndex = 7;
            this.Enter_Email_label.Text = "Please Enter the E-mail";
            this.Enter_Email_label.Visible = false;
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_label.ForeColor = System.Drawing.Color.Red;
            this.Address_label.Location = new System.Drawing.Point(858, 384);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(174, 18);
            this.Address_label.TabIndex = 8;
            this.Address_label.Text = "Please Enter the Address";
            this.Address_label.Visible = false;
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Back_button.ForeColor = System.Drawing.SystemColors.Window;
            this.Back_button.Location = new System.Drawing.Point(299, 673);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(94, 40);
            this.Back_button.TabIndex = 9;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Next__button
            // 
            this.Next__button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Next__button.ForeColor = System.Drawing.SystemColors.Window;
            this.Next__button.Location = new System.Drawing.Point(1214, 673);
            this.Next__button.Name = "Next__button";
            this.Next__button.Size = new System.Drawing.Size(94, 40);
            this.Next__button.TabIndex = 10;
            this.Next__button.Text = "Next";
            this.Next__button.UseVisualStyleBackColor = false;
            this.Next__button.Click += new System.EventHandler(this.button2_Click);
            // 
            // City_text
            // 
            this.City_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_text.Location = new System.Drawing.Point(855, 456);
            this.City_text.Name = "City_text";
            this.City_text.Size = new System.Drawing.Size(433, 24);
            this.City_text.TabIndex = 11;
            this.City_text.TextChanged += new System.EventHandler(this.City_text_TextChanged);
            this.City_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.City_text_KeyDown);
            // 
            // Zip_code_text
            // 
            this.Zip_code_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zip_code_text.Location = new System.Drawing.Point(855, 558);
            this.Zip_code_text.MaxLength = 5;
            this.Zip_code_text.Name = "Zip_code_text";
            this.Zip_code_text.Size = new System.Drawing.Size(433, 24);
            this.Zip_code_text.TabIndex = 12;
            this.Zip_code_text.TextChanged += new System.EventHandler(this.Zip_code_text_TextChanged);
            this.Zip_code_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Zip_code_text_KeyDown);
            // 
            // City_label
            // 
            this.City_label.AutoSize = true;
            this.City_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_label.ForeColor = System.Drawing.Color.Red;
            this.City_label.Location = new System.Drawing.Point(852, 481);
            this.City_label.Name = "City_label";
            this.City_label.Size = new System.Drawing.Size(145, 18);
            this.City_label.TabIndex = 13;
            this.City_label.Text = "Please Enter the City";
            this.City_label.Visible = false;
            // 
            // Zip_code_label
            // 
            this.Zip_code_label.AutoSize = true;
            this.Zip_code_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zip_code_label.ForeColor = System.Drawing.Color.Red;
            this.Zip_code_label.Location = new System.Drawing.Point(852, 583);
            this.Zip_code_label.Name = "Zip_code_label";
            this.Zip_code_label.Size = new System.Drawing.Size(180, 18);
            this.Zip_code_label.TabIndex = 14;
            this.Zip_code_label.Text = "Please Enter the Zip Code";
            this.Zip_code_label.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LPDA.Properties.Resources.pic_6;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1611, 832);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Correct_personal_contact_lable
            // 
            this.Correct_personal_contact_lable.AutoSize = true;
            this.Correct_personal_contact_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correct_personal_contact_lable.ForeColor = System.Drawing.Color.Red;
            this.Correct_personal_contact_lable.Location = new System.Drawing.Point(292, 384);
            this.Correct_personal_contact_lable.Name = "Correct_personal_contact_lable";
            this.Correct_personal_contact_lable.Size = new System.Drawing.Size(270, 18);
            this.Correct_personal_contact_lable.TabIndex = 15;
            this.Correct_personal_contact_lable.Text = "Enter the correct Contact NO(Personal)";
            this.Correct_personal_contact_lable.Visible = false;
            // 
            // correct_home_contact_lable
            // 
            this.correct_home_contact_lable.AutoSize = true;
            this.correct_home_contact_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correct_home_contact_lable.ForeColor = System.Drawing.Color.Red;
            this.correct_home_contact_lable.Location = new System.Drawing.Point(296, 481);
            this.correct_home_contact_lable.Name = "correct_home_contact_lable";
            this.correct_home_contact_lable.Size = new System.Drawing.Size(252, 18);
            this.correct_home_contact_lable.TabIndex = 16;
            this.correct_home_contact_lable.Text = "Enter the correct Contact NO(Home)";
            this.correct_home_contact_lable.Visible = false;
            this.correct_home_contact_lable.Click += new System.EventHandler(this.correct_home_contact_lable_Click);
            // 
            // correct_Email_label
            // 
            this.correct_Email_label.AutoSize = true;
            this.correct_Email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correct_Email_label.ForeColor = System.Drawing.Color.Red;
            this.correct_Email_label.Location = new System.Drawing.Point(296, 583);
            this.correct_Email_label.Name = "correct_Email_label";
            this.correct_Email_label.Size = new System.Drawing.Size(168, 18);
            this.correct_Email_label.TabIndex = 17;
            this.correct_Email_label.Text = "Enter the correct E- mail";
            this.correct_Email_label.Visible = false;
            // 
            // correct_Zip_Code_lable
            // 
            this.correct_Zip_Code_lable.AutoSize = true;
            this.correct_Zip_Code_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correct_Zip_Code_lable.ForeColor = System.Drawing.Color.Red;
            this.correct_Zip_Code_lable.Location = new System.Drawing.Point(852, 585);
            this.correct_Zip_Code_lable.Name = "correct_Zip_Code_lable";
            this.correct_Zip_Code_lable.Size = new System.Drawing.Size(187, 18);
            this.correct_Zip_Code_lable.TabIndex = 20;
            this.correct_Zip_Code_lable.Text = "Enter the corrrect Zip Code";
            this.correct_Zip_Code_lable.Visible = false;
            // 
            // contact_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 826);
            this.Controls.Add(this.correct_Zip_Code_lable);
            this.Controls.Add(this.correct_Email_label);
            this.Controls.Add(this.correct_home_contact_lable);
            this.Controls.Add(this.Correct_personal_contact_lable);
            this.Controls.Add(this.Zip_code_label);
            this.Controls.Add(this.City_label);
            this.Controls.Add(this.Zip_code_text);
            this.Controls.Add(this.City_text);
            this.Controls.Add(this.Next__button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.Enter_Email_label);
            this.Controls.Add(this.Contact_Home_label);
            this.Controls.Add(this.Contact_personal_label);
            this.Controls.Add(this.Address_text);
            this.Controls.Add(this.Email_text);
            this.Controls.Add(this.Contact_Home_text);
            this.Controls.Add(this.Contact_personal_text);
            this.Controls.Add(this.pictureBox1);
            this.Name = "contact_details";
            this.Text = "contact_details";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Contact_personal_text;
        private System.Windows.Forms.TextBox Contact_Home_text;
        private System.Windows.Forms.TextBox Email_text;
        private System.Windows.Forms.TextBox Address_text;
        private System.Windows.Forms.Label Contact_personal_label;
        private System.Windows.Forms.Label Contact_Home_label;
        private System.Windows.Forms.Label Enter_Email_label;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Next__button;
        private System.Windows.Forms.TextBox City_text;
        private System.Windows.Forms.TextBox Zip_code_text;
        private System.Windows.Forms.Label City_label;
        private System.Windows.Forms.Label Zip_code_label;
        private System.Windows.Forms.Label Correct_personal_contact_lable;
        private System.Windows.Forms.Label correct_home_contact_lable;
        private System.Windows.Forms.Label correct_Email_label;
        private System.Windows.Forms.Label correct_Zip_Code_lable;
    }
}