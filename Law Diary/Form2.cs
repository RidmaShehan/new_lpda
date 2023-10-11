using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Law_Diary
{
    public partial class Form2 : Form
    {
        private readonly object comboBox1;
        private DateTime startDate;
        private DateTime endDate;

        public Form2()
        {
            InitializeComponent();
        }



        private void label5_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "All Files (*.*)|*.*"; // Customize the file filter if needed

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    // Perform further actions with the selected file, such as saving it or displaying its information
                    // ...
                }
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.ScrollBars = ScrollBars.Vertical;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Perform actions when "active" status is selected
                // ...
            }

        }



        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                // Perform actions when "In Progress" status is selected
                // ...
            }
        }

        private void button2_Click(object sender, EventArgs e)
        
            {


                
                {
                    if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(label1.Text) || !checkBox1.Checked || dateTimePicker1.Value == DateTime.MinValue)
                    {
                        MessageBox.Show("Please fill in all required information.", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exit the event handler
                    }

                    // If all fields are not empty or have valid values, proceed with actions
                    // ...

                    // Display a success message
                    MessageBox.Show("Case details added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Optionally, you can reset the form controls or navigate to another page
                    // ...
                }





            }
        }
    }





