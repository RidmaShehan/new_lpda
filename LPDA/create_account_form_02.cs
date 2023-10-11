using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LPDA
{
    public partial class create_account_form_02 : Form
    {
        private LRegDate data;
        // Create an instance of the login_form
        Form1 login_form = new Form1();

        // Create an instance of the create_account_form_02
        create_account_form create_account_form = new create_account_form();

        teamsAndCondition_form teamsAndCondition_Form = new teamsAndCondition_form();
        public create_account_form_02(LRegDate data)
        {
            InitializeComponent();
            this.ActiveControl = email_text; //<----- FOCUS first text box after FORM LOAD.
            this.data = data;
        }
      
        private void next_butten_form_02_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "reg(*.txt)|*.txt";
            saveFileDialog.Title = "save Registration Data";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write the registration data to the file
                    
                    writer.WriteLine($"Surname: {data.Surname}");
                    writer.WriteLine($"First Name: {data.FirstName}");
                    writer.WriteLine($"Second Name: {data.SecondName}");
                    writer.WriteLine($"ID Number: {data.IDNumber}");
                    writer.WriteLine($"Date Of Birth : {data.DateOfBirth}");
                    writer.WriteLine($"Gender : {data.Gender}");

                    //this form 
                    writer.WriteLine($"Email: {data.Email}");
                    writer.WriteLine($"Phone Number: {data.PhoneNumber}");
                    writer.WriteLine($"ZipCode: {data.ZipCode}");
                    writer.WriteLine($"UserName: {data.UserName}");
                    writer.WriteLine($"Password: {data.Password}");

                    writer.WriteLine();
                }

                string insertQuery = "INSERT INTO lawer_data_table (lawer_surname, lawer_first_name, lawer_second_name,lawer_id_number,lawer_gender,lawer_date_of_birth,lawer_phone_number,lawer_zipcode,lawer_email,lawer_user_name,lawer_password) VALUES ('"+ data.Surname + "','"+ data.FirstName + "','"+ data.SecondName + "','"+ data.IDNumber + "','"+ data.Gender + "','"+ data.DateOfBirth + "','"+ data.PhoneNumber + "','"+ data.ZipCode + "','"+ data.Email + "','"+ data.UserName + "','"+ data.Password + "')";
                SQL.ExecuteQuery(insertQuery);
                // Display a success message
                string message = "Registration data saved successfully.";
                DialogResult result = MessageBox.Show(message, "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result== DialogResult.OK)
                {
                    // Hide the create_account_form
                    this.Hide();

                    // Show the create_account_form_02
                    login_form.Show();
                }

            }
        }

        private void email_text_KeyDown(object sender, KeyEventArgs e)
        {
            // add keyDown event for press Enter Key.
            if (e.KeyCode == Keys.Enter)
            {
                // make boolean variable as "EmailIsCorrect" , for controlling the while loop.
                Boolean EmailIsCorrect = false;

                // The value of "email_text" is assigned to the variable  "Email".
                data.Email = email_text.Text;
                
                while (EmailIsCorrect!=true)
                {
                    if (data.Email == "")
                    {
                        email_error_picture.Visible = true;
                        enter_the_correct_email.Visible = false;
                        enter_the_email.Visible = true;
                    }
                    else 
                    {
                        if (data.Email.Contains("@"))
                        {
                            //If text content has '@'. It is correct.
                            //Focusing on phone_number_tex.
                            email_error_picture.Visible = false;
                            email_correct_picture.Visible = true;
                            enter_the_email.Visible = false;
                            phone_number_text.Focus();
                            EmailIsCorrect = true;
                            break;
                        }
                        else
                        {
                            //If text content hasn't '@'. It is incorrect.
                            EmailIsCorrect = false;
                            //To receive user input again, the focus is placed on that cell and the contents of the cell are cleared.
                            email_error_picture.Visible = true;
                            email_correct_picture.Visible = false;
                            enter_the_email.Visible=false;
                            enter_the_correct_email.Visible = true;
                            email_text.Clear();
                            email_text.Focus();
                            break;
                        }

                    }
                   
                        
                    
                }
                
            }
        }

        private void phone_number_text_KeyDown(object sender, KeyEventArgs e)
        {

            // add keyDown event for press Enter Key.
            if (e.KeyCode == Keys.Enter)
            {
                // make boolean variable as " PhoneNumberIsCorrect" , for controlling the while loop.
                Boolean PhoneNumberIsCorrect = false;

                // The value of "phone_number_text" is assigned to the variable  "PhoneNumber".
                    data.PhoneNumber = phone_number_text.Text;


                    while (PhoneNumberIsCorrect != true)
                    {
                        if (data.PhoneNumber=="")
                        {
                            // phone_number_text is empty....

                            phone_number_error_picture.Visible = true;
                            phone_number_correct_picture.Visible = false; 
                            enter_the_correct_phone_number.Visible = false;
                            enter_the_phone_number.Visible=true;
                            phone_number_text.Focus();
                            PhoneNumberIsCorrect = true;
                            break;
                        }
                        else
                        {
                            // Does the phone number have ten digits?...
                            // And check whether the first digit of the phone number is a zero?,...
                            // and whether all the included characters are numbers....
                            if (data.PhoneNumber.Length == 10 && data.PhoneNumber.All(char.IsDigit) && data.PhoneNumber[0] == '0')
                            {

                                //Correct phone number...
                                phone_number_error_picture.Visible = false; 
                                phone_number_correct_picture.Visible = true;
                                enter_the_correct_phone_number.Visible=false;
                                enter_the_phone_number.Visible = false;
                                user_name_text.Focus();
                                PhoneNumberIsCorrect=true;
                                break;
                            }
                            else
                            {
                                //Incorrect phone number...
                                phone_number_correct_picture.Visible = false;
                                phone_number_error_picture.Visible = true; 
                                enter_the_correct_phone_number.Visible = true;
                                enter_the_phone_number.Visible = false;
                                phone_number_text.Focus();
                                phone_number_text.Clear();

                                PhoneNumberIsCorrect=false;
                                break;
                            }
                        }

                    }
                
                
            }
        }



        private void user_name_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // make boolean variable as " UserNameIsCorrect " , for controlling the while loop.
                Boolean UserNameIsCorrect = false;

                // The value of "user_name_text" is assigned to the variable  "UserName".
                data.UserName = user_name_text.Text;

                // while loop.
                while (UserNameIsCorrect != true)
                {
                    if (data.UserName == "")
                    {
                        //
                        user_name_error_picture.Visible = true;
                        user_name_correct_picture.Visible = false;
                        enter_the_user_name.Visible = true;
                        user_name_text.Focus();
                        UserNameIsCorrect = false; 
                        break;
                    }
                    else
                    {
                        user_name_error_picture.Visible = false;
                        user_name_correct_picture.Visible=true;
                        enter_the_user_name.Visible=false;
                        zip_code_text.Focus();
                        UserNameIsCorrect=false;
                        break;
                    }
                }
            }
                
        }

        private void zip_code_text_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void password_text_TextChanged(object sender, EventArgs e)
        {
            data.Password = password_text.Text;
        }

        private void confirm_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirm_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // make boolean variable as " UserNameIsCorrect " , for controlling the while loop.
                Boolean TempPasswordIsCorrect = false;

                // The value of "user_name_text" is assigned to the variable  "UserName".
               data.TempPassword = confirm_password_text.Text;

                // while loop.
                while (TempPasswordIsCorrect != true)
                {
                    if (data.TempPassword == "") 
                    { 
                        confirm_password_error_picture.Visible = true;
                        confirm_password_correct_picture.Visible = false;
                        TempPasswordIsCorrect = false;
                        break;
                    }
                    else
                    {
                        if (data.TempPassword == data.Password)
                        {
                            confirm_password_error_picture.Visible = false;
                            confirm_password_correct_picture.Visible = true;
                            next_butten_form_02.Focus();
                            TempPasswordIsCorrect = true;
                            break;
                        }
                        else
                        {
                            confirm_password_correct_picture.Visible = false;
                            confirm_password_error_picture.Visible = true;
                            confirm_password_text.Clear();
                            confirm_password_text.Focus();
                            TempPasswordIsCorrect = false;
                            break;
                        }
                    }

                }
            }
            

        }

        private void email_text_TextChanged(object sender, EventArgs e)
        {
           
                // make boolean variable as "EmailIsCorrect" , for controlling the while loop.
                Boolean EmailIsCorrect = false;

                // The value of "email_text" is assigned to the variable  "Email".
                data.Email = email_text.Text;

                
                    if (data.Email == "")
                    {
                        email_error_picture.Visible = true;
                        enter_the_correct_email.Visible = false;
                        enter_the_email.Visible = true;
                    }
                    else
                    {
                        if (data.Email.Contains("@"))
                        {
                            //If text content has '@'. It is correct.
                            //Focusing on phone_number_tex.
                            email_error_picture.Visible = false;
                            email_correct_picture.Visible = true;
                            enter_the_email.Visible = false;
                            //phone_number_text.Focus();
                            EmailIsCorrect = true;
                            
                        }
                        else
                        {
                            //If text content hasn't '@'. It is incorrect.
                            EmailIsCorrect = false;
                            //To receive user input again, the focus is placed on that cell and the contents of the cell are cleared.
                            email_error_picture.Visible = true;
                            email_correct_picture.Visible = false;
                            enter_the_email.Visible = false;
                            enter_the_correct_email.Visible = true;
                            //
                            //email_text.Clear();
                            email_text.Focus();
                            
                        }

                    }



                

            
        }

        private void zip_code_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // ....make boolean variable as " ZipCodeIsCorrect " , for controlling the while loop.
                Boolean ZipCodeIsCorrect = false;

                // ...The value of "zip_code_text" is assigned to the variable  "ZipCodeIsCorrect".
                data.ZipCode = zip_code_text.Text;

                while (ZipCodeIsCorrect!=true)
                {
                    if(data.ZipCode == "")
                    {
                        // ..."zip_code_text" text box is empty...
                        zipcode_error_picture.Visible = true;
                        zipcode_correct_picture.Visible = false;
                        enter_the_zipcode.Visible = true;
                        enter_the_correct_zipcode.Visible = false;  
                        zip_code_text.Focus();
                        ZipCodeIsCorrect = false;
                        break;
                    }
                    else // ....IF "zip_code_text" text box have some value....
                    {
                        // ....This checks if the maximum is 5 and if all of them are numbers.
                        if (data.ZipCode.Length == 5 && data.ZipCode.All(char.IsDigit))
                        {
                            zipcode_error_picture.Visible = false;
                            zipcode_correct_picture.Visible = true;
                            enter_the_correct_zipcode.Visible = false;
                            enter_the_zipcode.Visible= false;
                            password_text.Focus();
                            ZipCodeIsCorrect = true;
                            break;
                        }
                        else // ....If not, clear the text box and focus on it....
                        {
                            zipcode_error_picture.Visible = true;
                            zipcode_correct_picture.Visible= false;
                            enter_the_zipcode.Visible = false;
                            enter_the_correct_zipcode.Visible = true;
                            zip_code_text.Clear();
                            zip_code_text.Focus();
                            ZipCodeIsCorrect = false;
                            break;
                        }
                    }
                }
            }
        }

        private void password_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // ....make boolean variable as " ZipCodeIsCorrect " , for controlling the while loop.
                Boolean PasswordIsCorrect = false;

                // ...The value of "zip_code_text" is assigned to the variable  "ZipCodeIsCorrect".
                data.Password = password_text.Text;

                string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";

                while (PasswordIsCorrect != true)
                {
                    if ( data.Password == "" )
                    {
                        password_error_picture.Visible = true;
                        enter_the_password.Visible = true;
                        password_text.Focus();
                        PasswordIsCorrect = false;
                        break;
                    }
                    else
                    {
                        // Use Regex.IsMatch to check if the password matches the pattern
                        if (data.Password.Length >= 8 && Regex.IsMatch(data.Password, pattern))
                        {
                            password_error_picture.Visible = false;
                            password_correct_picture.Visible = true;
                            enter_the_password.Visible = false;
                            confirm_password_text.Focus();
                            PasswordIsCorrect = true;
                            break;
                        }
                        else
                        {
                            password_correct_picture.Visible = false;
                            password_error_picture.Visible = true;
                            enter_the_password.Visible=false;
                            password_text.Clear();
                            password_text.Focus();
                        }
                    }
                }
            }
        }

        private void back_butten_form_02_Click(object sender, EventArgs e)
        {


            // Hide the create_account_form
            this.Hide();

            // Show the create_account_form_02
            create_account_form.Show();
        }

        private void email_text_Click(object sender, EventArgs e)
        {
            email_text.Text=string.Empty;
            email_text.ForeColor = Color.Black;
        }

        private void phone_number_text_Click(object sender, EventArgs e)
        {
            phone_number_text.Text=string.Empty;
            phone_number_text.ForeColor = Color.Black;
        }

        private void user_name_text_Click(object sender, EventArgs e)
        {
            user_name_text.Text=string.Empty;
            user_name_text.ForeColor=Color.Black;
        }

        private void zip_code_text_Click(object sender, EventArgs e)
        {
            zip_code_text.Text=string.Empty;   
            zip_code_text.ForeColor=Color.Black;
        }

        private void password_text_Click(object sender, EventArgs e)
        {
            password_text.Text = string.Empty;
            password_text.ForeColor = Color.Black;
        }

        private void confirm_password_text_Click(object sender, EventArgs e)
        {
            confirm_password_text.Text = string.Empty;
            confirm_password_text.ForeColor =Color.Black;
        }

        private void phone_number_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void create_account_form_02_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                next_butten_form_02.Enabled = true;
            }
            else
            {
                next_butten_form_02.Enabled=false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            teamsAndCondition_Form.Show(); 
        }
    }
}
