using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//  <---- use SQL CLIENT.

namespace LPDA
{
    public partial class Form1 : Form
    {
        
        dashboard_form dashboard_form = new dashboard_form();//  <----Create an instance of the new form....


        // ....Create an instance of the new form....
        create_account_form create_account_form = new create_account_form();

        
        //....Create an public variable....
           
        public string user_name_login;//  <----variable for Login User Name...
        public string password_login;//  <----variable for Login Password...
        public Form1()
        {
            InitializeComponent();
        }

        private void user_name_text_box_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void user_name_text_box_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)    //  <---- Make a KeyDown Key Event for press ENTER Key.
            {
                user_name_login = user_name_text_box.Text;// <----If User enter the USER NAME, it will assign to the "user_name_login".
                password_txet_box.Focus();//  <----Then FOCUS the "password_text_box"-Txetboc for ENTER PASSWORD.
            }
            /*if (e.KeyCode == Keys.Enter)
            {
                
                bool UserNameIsCorrect = false;
                string user_name_login = user_name_text_box.Text;

                while (UserNameIsCorrect!= true)
                {
                    user_name_login = user_name_text_box.Text;

                    if (user_name_login != "ridma")
                    {
                       

                        user_name_error_massege.Visible = true;
                        user_name_error_picture.Visible = true;
                        user_name_correct_picture.Visible = false;

                        // Optionally, you can clear the username and password fields
                        user_name_text_box.Clear();

                        // Set focus back to the username field
                        user_name_text_box.Focus();

                        //---------------------------------

                        UserNameIsCorrect = true;
                        break;
                    }
                    else{
                        user_name_error_massege.Visible = false;
                        user_name_error_picture.Visible = false;

                        // user name is correct 
                        
                        user_name_correct_picture.Visible = true;
                        password_txet_box.Focus();
                        UserNameIsCorrect = false;
                        break;
                    }
                }
            }*/
        }

        private void user_name_error_massege_Click(object sender, EventArgs e)
        {

        }

        private void password_txet_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //  <---- Make a KeyDown Key Event for press ENTER Key.
            {
                password_login = password_txet_box.Text;//  <----If User enter the PASSWORD, it will assign to the "password_login".
                login_butten.Focus();//  <---- Then focus the LOGIN BUTTEN for login.
            }
            /* if (e.KeyCode == Keys.Enter)
             {
                 string password_login = password_txet_box.Text;
                 bool PasswordIsCorrect = false;
                 while (PasswordIsCorrect != true)
                 {
                     password_login = password_txet_box.Text;
                     if (password_login == "admin")
                     {
                         password_error_massege.Visible = false;
                         password_erroe_picture.Visible = false;
                         password_correct_picture.Visible=true;
                         PasswordIsCorrect = true;
                         login_butten.Focus();
                         break;
                     }
                     else
                     {
                         password_error_massege.Visible = true;
                         password_erroe_picture.Visible = true;
                         // Optionally, you can clear the username and password fields
                         password_txet_box.Clear();
                         password_txet_box.Focus();
                         break;
                     }
                 }

             }*/
        }

        private void label1_Click(object sender, EventArgs e)//  <---- Make a Click Event for lable named as CREATE ACCOUNT,  for register the new customer.
        {
            

            // Create an instance of the new form
            create_account_form create_account_form = new create_account_form(); //  <----Call the CREAT ACCOUNT FORM for this form like Objeect.

            // Hide the current form
            this.Hide();//  <---- HIDE current form.

            // Show the new form
            create_account_form.Show();//  <---- Show the CREAT ACCOUNT FORM.
        }

        private void login_butten_Click(object sender, EventArgs e)
        {
            string query = "SELECT lawer_password FROM lawer_data_table WHERE lawer_user_name = '" +user_name_text_box.Text + "';";
            string password = string.Empty;//  <---- Make a variable as PASSWORD for assign password readed in QUERY -->lpda-Database -->lawer_data_table-Data Table -->lawer_password-Data Colum

            using (SqlDataReader reader = SQL.ExecuteReader(query))
            {
                if (reader.Read())
                {
                    password = reader["lawer_password"].ToString();
                }
            }
            
            Boolean UserNameAndPasswordIsCorrect = false;
            
            if (password_txet_box.Text == password)//  <---- Check if USER Entered password is correct.
            {
                password_erroe_picture.Visible = false; 
                user_name_error_picture.Visible = false;
                password_correct_picture.Visible = true;  
                user_name_correct_picture.Visible = true; 
                UserNameAndPasswordIsCorrect = true;
                this.Hide();    //  <---- If USER NAME & PASSWORD are correct then hide this form.
                dashboard_form.Show();//  <---- Then show DASHBORD FORM.
            }
            else//  <----if USER Entered password is incorrect.
            {
                password_erroe_picture.Visible = true;//  <---- PASSWORD error
                user_name_error_picture.Visible=true;//  <---- USER NAME error
                password_correct_picture.Visible = false;
                password_correct_picture.Visible = false;
                MessageBox.Show("Incorrect User Name Or Password!");
                user_name_text_box.Clear();//  <---- Clear the user_name_text_box
                password_txet_box.Clear();//  <---- Clear the password_text_box
                user_name_text_box.Focus();//  <---- Focus the user_name_text_box for enter the new password.
                
            }
        }

        private void login_butten_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
