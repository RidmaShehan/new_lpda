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

namespace LPDA
{
    public partial class Form1 : Form
    {
        // ....Create an instance of the new form....
        dashboard_form dashboard_form = new dashboard_form();


        // ....Create an instance of the new form....
        create_account_form create_account_form = new create_account_form();

        

        public string user_name_login;
        public string password_login;
        public Form1()
        {
            InitializeComponent();
        }

        private void user_name_text_box_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void user_name_text_box_KeyDown(object sender, KeyEventArgs e)
        {
            user_name_login = user_name_text_box.Text;
            password_txet_box.Focus();
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
            password_login = password_txet_box.Text;
            login_butten.Focus();
            
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

        private void label1_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            create_account_form create_account_form = new create_account_form();

            // Hide the current form
            this.Hide();

            // Show the new form
            create_account_form.Show();
        }

        private void login_butten_Click(object sender, EventArgs e)
        {

            Boolean UserNameAndPasswordIsCorrect = false;   
            while(UserNameAndPasswordIsCorrect=!true)
            {
                if(user_name_login == "ridma" && password_login == "admin")
                {
                    password_erroe_picture.Visible = false;
                    user_name_error_picture.Visible = false;
                    password_correct_picture.Visible = true;
                    user_name_correct_picture.Visible = true;
                    UserNameAndPasswordIsCorrect =true;
                    this.Hide();
                    dashboard_form.Show();
                    break;
                }
            }
        }

        private void login_butten_MouseHover(object sender, EventArgs e)
        {
            hover_login_botten.Visible = true;
        }
    }
}
