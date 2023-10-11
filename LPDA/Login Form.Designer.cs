namespace LPDA
{
    partial class Form1
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
            this.user_name_error_massege = new System.Windows.Forms.Label();
            this.password_error_massege = new System.Windows.Forms.Label();
            this.login_butten = new System.Windows.Forms.Button();
            this.user_name_text_box = new System.Windows.Forms.TextBox();
            this.password_txet_box = new System.Windows.Forms.TextBox();
            this.user_name_correct_picture = new System.Windows.Forms.PictureBox();
            this.password_erroe_picture = new System.Windows.Forms.PictureBox();
            this.user_name_error_picture = new System.Windows.Forms.PictureBox();
            this.login_form_background_picture = new System.Windows.Forms.PictureBox();
            this.password_correct_picture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.user_name_correct_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_erroe_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_name_error_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_form_background_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_correct_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // user_name_error_massege
            // 
            this.user_name_error_massege.AutoSize = true;
            this.user_name_error_massege.BackColor = System.Drawing.Color.Transparent;
            this.user_name_error_massege.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name_error_massege.ForeColor = System.Drawing.Color.Red;
            this.user_name_error_massege.Location = new System.Drawing.Point(300, 457);
            this.user_name_error_massege.Name = "user_name_error_massege";
            this.user_name_error_massege.Size = new System.Drawing.Size(187, 18);
            this.user_name_error_massege.TabIndex = 1;
            this.user_name_error_massege.Text = "Enter The Valid User Name";
            this.user_name_error_massege.Visible = false;
            this.user_name_error_massege.Click += new System.EventHandler(this.user_name_error_massege_Click);
            // 
            // password_error_massege
            // 
            this.password_error_massege.AutoSize = true;
            this.password_error_massege.BackColor = System.Drawing.Color.Transparent;
            this.password_error_massege.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_error_massege.ForeColor = System.Drawing.Color.Red;
            this.password_error_massege.Location = new System.Drawing.Point(300, 560);
            this.password_error_massege.Name = "password_error_massege";
            this.password_error_massege.Size = new System.Drawing.Size(214, 18);
            this.password_error_massege.TabIndex = 2;
            this.password_error_massege.Text = "Enter The Valid User Password";
            this.password_error_massege.Visible = false;
            // 
            // login_butten
            // 
            this.login_butten.BackColor = System.Drawing.SystemColors.Highlight;
            this.login_butten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_butten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_butten.ForeColor = System.Drawing.Color.Snow;
            this.login_butten.Location = new System.Drawing.Point(340, 617);
            this.login_butten.Name = "login_butten";
            this.login_butten.Size = new System.Drawing.Size(372, 37);
            this.login_butten.TabIndex = 4;
            this.login_butten.Text = "L O G I N ";
            this.login_butten.UseVisualStyleBackColor = false;
            this.login_butten.Click += new System.EventHandler(this.login_butten_Click);
            this.login_butten.MouseHover += new System.EventHandler(this.login_butten_MouseHover);
            // 
            // user_name_text_box
            // 
            this.user_name_text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name_text_box.Location = new System.Drawing.Point(310, 423);
            this.user_name_text_box.Name = "user_name_text_box";
            this.user_name_text_box.Size = new System.Drawing.Size(423, 27);
            this.user_name_text_box.TabIndex = 5;
            this.user_name_text_box.TextChanged += new System.EventHandler(this.user_name_text_box_TextChanged);
            this.user_name_text_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.user_name_text_box_KeyDown);
            // 
            // password_txet_box
            // 
            this.password_txet_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txet_box.Location = new System.Drawing.Point(310, 522);
            this.password_txet_box.Name = "password_txet_box";
            this.password_txet_box.PasswordChar = '*';
            this.password_txet_box.Size = new System.Drawing.Size(423, 27);
            this.password_txet_box.TabIndex = 5;
            this.password_txet_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_txet_box_KeyDown);
            // 
            // user_name_correct_picture
            // 
            this.user_name_correct_picture.Image = global::LPDA.Properties.Resources.ok;
            this.user_name_correct_picture.Location = new System.Drawing.Point(299, 395);
            this.user_name_correct_picture.Name = "user_name_correct_picture";
            this.user_name_correct_picture.Size = new System.Drawing.Size(5, 59);
            this.user_name_correct_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_name_correct_picture.TabIndex = 6;
            this.user_name_correct_picture.TabStop = false;
            this.user_name_correct_picture.Visible = false;
            // 
            // password_erroe_picture
            // 
            this.password_erroe_picture.Image = global::LPDA.Properties.Resources.error;
            this.password_erroe_picture.Location = new System.Drawing.Point(299, 497);
            this.password_erroe_picture.Name = "password_erroe_picture";
            this.password_erroe_picture.Size = new System.Drawing.Size(5, 59);
            this.password_erroe_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.password_erroe_picture.TabIndex = 3;
            this.password_erroe_picture.TabStop = false;
            this.password_erroe_picture.Visible = false;
            // 
            // user_name_error_picture
            // 
            this.user_name_error_picture.Image = global::LPDA.Properties.Resources.error;
            this.user_name_error_picture.Location = new System.Drawing.Point(299, 395);
            this.user_name_error_picture.Name = "user_name_error_picture";
            this.user_name_error_picture.Size = new System.Drawing.Size(5, 59);
            this.user_name_error_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_name_error_picture.TabIndex = 3;
            this.user_name_error_picture.TabStop = false;
            this.user_name_error_picture.Visible = false;
            // 
            // login_form_background_picture
            // 
            this.login_form_background_picture.Image = global::LPDA.Properties.Resources.law_login_form1;
            this.login_form_background_picture.Location = new System.Drawing.Point(-2, 1);
            this.login_form_background_picture.Name = "login_form_background_picture";
            this.login_form_background_picture.Size = new System.Drawing.Size(1631, 881);
            this.login_form_background_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.login_form_background_picture.TabIndex = 0;
            this.login_form_background_picture.TabStop = false;
            // 
            // password_correct_picture
            // 
            this.password_correct_picture.Image = global::LPDA.Properties.Resources.ok;
            this.password_correct_picture.Location = new System.Drawing.Point(299, 497);
            this.password_correct_picture.Name = "password_correct_picture";
            this.password_correct_picture.Size = new System.Drawing.Size(5, 59);
            this.password_correct_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.password_correct_picture.TabIndex = 7;
            this.password_correct_picture.TabStop = false;
            this.password_correct_picture.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(462, 677);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Create Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LPDA.Properties.Resources.Artboard_25;
            this.pictureBox1.Location = new System.Drawing.Point(1565, 826);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 881);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_correct_picture);
            this.Controls.Add(this.user_name_correct_picture);
            this.Controls.Add(this.password_txet_box);
            this.Controls.Add(this.user_name_text_box);
            this.Controls.Add(this.login_butten);
            this.Controls.Add(this.password_erroe_picture);
            this.Controls.Add(this.user_name_error_picture);
            this.Controls.Add(this.password_error_massege);
            this.Controls.Add(this.user_name_error_massege);
            this.Controls.Add(this.login_form_background_picture);
            this.Location = new System.Drawing.Point(500, 500);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_name_correct_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_erroe_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_name_error_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_form_background_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_correct_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label user_name_error_massege;
        private System.Windows.Forms.Label password_error_massege;
        private System.Windows.Forms.PictureBox user_name_error_picture;
        private System.Windows.Forms.PictureBox password_erroe_picture;
        private System.Windows.Forms.Button login_butten;
        private System.Windows.Forms.PictureBox login_form_background_picture;
        private System.Windows.Forms.TextBox user_name_text_box;
        private System.Windows.Forms.TextBox password_txet_box;
        private System.Windows.Forms.PictureBox user_name_correct_picture;
        private System.Windows.Forms.PictureBox password_correct_picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

