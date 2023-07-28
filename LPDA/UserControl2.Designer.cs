namespace LPDA
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.settings_lable = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // settings_lable
            // 
            this.settings_lable.AutoSize = true;
            this.settings_lable.BackColor = System.Drawing.Color.Transparent;
            this.settings_lable.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_lable.Location = new System.Drawing.Point(37, 21);
            this.settings_lable.Name = "settings_lable";
            this.settings_lable.Size = new System.Drawing.Size(333, 80);
            this.settings_lable.TabIndex = 1;
            this.settings_lable.Text = "SETTINGS";
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(1506, 36);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(37, 39);
            this.user_name.TabIndex = 3;
            this.user_name.Text = "0";
            this.user_name.Click += new System.EventHandler(this.user_name_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LPDA.Properties.Resources.Artboard_212;
            this.pictureBox1.Location = new System.Drawing.Point(1653, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.settings_lable);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1777, 113);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label settings_lable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label user_name;
    }
}
