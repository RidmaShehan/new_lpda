using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPDA
{
    public partial class create_account_form : Form
    {
        public string Surname ;
        public string FirstName;
        public string SecondName;
        public string IDNumber;
        public string DateOfBirth;
        public string Gender;
        public create_account_form()
        {
            

            InitializeComponent();
    }

        private void create_account_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the create_account_form_02
            create_account_form_02 create_account_form_02 = new create_account_form_02();

            // Hide the create_account_form
            this.Hide();

            // Show the create_account_form_02
            create_account_form_02.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Surname_txet_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool SurnameNameIsCorrect = false;
                Surname = Surname_txet_box.Text;
                while (SurnameNameIsCorrect!= true)
                {
                    if(Surname == "")
                    {
                        surname_error_picture.Visible = true;
                        label1.Visible = true;
                        SurnameNameIsCorrect = false;
                        break;
                    }
                    else
                    {
                        surname_error_picture.Visible = false;
                        label1.Visible = false;
                        surname_correct_picture.Visible = true;
                        first_name_text_box.Focus();
                        break;
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void surname_error_picture_Click(object sender, EventArgs e)
        {

        }

        private void first_name_error_picture_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void second_name_error_picture_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gender_error_picture_Click(object sender, EventArgs e)
        {

        }

        private void birthday_error_picture_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ID_number_error_picture_Click(object sender, EventArgs e)
        {

        }

        private void first_name_text_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool FirstNameNameIsCorrect = false;
                FirstName = first_name_text_box.Text;
                while (FirstNameNameIsCorrect != true)
                {
                    if (FirstName == "")
                    {
                        first_name_error_picture.Visible = true;
                        label2.Visible = true;
                        FirstNameNameIsCorrect = false;
                        break;
                    }
                    else
                    {
                        first_name_error_picture.Visible = false;
                        label2.Visible = false;
                        first_name_correct_picture.Visible = true;
                        second_name_text_box.Focus();
                        break;
                    }
                }
            }
        }

        private void second_name_text_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool SecondNameNameIsCorrect = false;
                SecondName = first_name_text_box.Text;
                while (SecondNameNameIsCorrect != true)
                {
                    if (FirstName == "")
                    {
                        second_name_error_picture.Visible = true;
                        label3.Visible = true;
                        SecondNameNameIsCorrect = false;
                        break;
                    }
                    else
                    {
                        second_name_error_picture.Visible = false;
                        label3.Visible = false;
                        second_name_correct_picture.Visible = true;
                        ID_number_text_box.Focus();
                        break;
                    }
                }
            }
        }

        private void ID_number_text_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool IDNumberIsCorrect = false;
                IDNumber =ID_number_text_box.Text;

                while (IDNumberIsCorrect != true)
                {
                   
                    if (IDNumber == "")
                    {
                        ID_number_error_picture.Visible = true;
                        label4.Visible = true;
                        IDNumberIsCorrect = false;
                        break;

                    }
                    else 
                    {

                        if (IDNumber.Length == 12 && IDNumber.All(char.IsDigit))
                        {
                             ID_number_error_picture.Visible = false;
                                label4.Visible = false;
                                label7.Visible = false;
                                id_correct_picture.Visible = true;
                                IDNumberIsCorrect = true;
                                break;
                        }
                        else
                        {
                            if (IDNumber.Length == 10 && IDNumber.Contains('v'))
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    if (!char.IsDigit(IDNumber[i]))
                                    {
                                        ID_number_error_picture.Visible = true;
                                        label7.Visible = true;
                                        ID_number_text_box.Clear();
                                        ID_number_text_box.Focus();
                                        IDNumberIsCorrect = false;
                                        break;
                                    }
                                    else
                                    {
                                        ID_number_error_picture.Visible = false;
                                        label4.Visible = false;
                                        label7.Visible = false;
                                        id_correct_picture.Visible = true;

                                        IDNumberIsCorrect = true;
                                        break;
                                    }
                                }

                            }
                            else
                            {
                                ID_number_error_picture.Visible = true;
                                label7.Visible = true;
                                IDNumberIsCorrect = false;
                                break;
                            }
                        }

                    }
                        
                                     
                          
                                
                
                      
                        

                       
                            
                           
                       /* ID_number_error_picture.Visible = false;
                        label4.Visible = false;
                        second_name_correct_picture.Visible = true;
                        ID_number_text_box.Focus();*/
                        
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ID_number_text_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Surname_txet_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Surname_txet_box_Click(object sender, EventArgs e)
        {
            Surname_txet_box.Text = string.Empty;
            Surname_txet_box.ForeColor = Color.Black;
        }

        private void ID_number_text_box_Click(object sender, EventArgs e)
        {
            ID_number_text_box.Text = string.Empty;
            ID_number_text_box.ForeColor = Color.Black;
        }

        private void first_name_text_box_Click(object sender, EventArgs e)
        {
            first_name_text_box.Text = string.Empty;
            first_name_text_box.ForeColor = Color.Black;
        }

        private void second_name_text_box_Click(object sender, EventArgs e)
        {
            second_name_text_box.Text = string.Empty;
            second_name_text_box.ForeColor= Color.Black;
        }
    }
}
