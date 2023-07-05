using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPDA
{
    public partial class contact_details : Form
    {
        String ContactPersonal;
        String ContactHome;
        String Email;
        String Address;
        String City;
        String ZipCode;



        public contact_details()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close the current form
            this.Close();
            //Hide the current form
            this.Hide();
            //Show the older form
            peronal_detail_form f2 = new peronal_detail_form();
            f2.ShowDialog();

        }

        private void Contact_personal_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            // add keyDown event for press Enter Key.
            if (e.KeyCode == Keys.Enter)
            {
                // make boolean variable as " ContactPersonalIsCorrect" , for controlling the while loop.
                Boolean ContactPersonalIsCorrect = false;

                // The value of "phone_number_text" is assigned to the variable  "ContactPersonal".
                ContactPersonal = Contact_personal_text.Text;


                while (ContactPersonalIsCorrect != true)
                {
                    if (ContactPersonal=="")
                    {
                        // phone_number_text is empty...
                        Contact_personal_label.Visible=true;
                        Contact_personal_text.Focus();
                        ContactPersonalIsCorrect = true;
                        break;
                    }
                    else
                    {
                        // Does the phone number have ten digits?...
                        // And check whether the first digit of the phone number is a zero?,...
                        // and whether all the included characters are numbers....
                        if (ContactPersonal.Length == 10 && ContactPersonal.All(char.IsDigit) && ContactPersonal[0] == '0')
                        {

                            //Correct phone number...
                            Contact_personal_label.Visible = false;
                            Contact_Home_text.Focus();
                            ContactPersonalIsCorrect=true;
                            break;
                        }
                        else
                        {
                            //Incorrect phone number...
                            Contact_personal_label.Visible= true;
                            Contact_personal_text.Focus();
                            Contact_personal_text.Clear();
                            ContactPersonalIsCorrect=false;
                            break;
                        }
                    }
                }
            }
        }

        private void Contact_Home_text_KeyDown(object sender, KeyEventArgs e)
        {
            // add keyDown event for press Enter Key.
            if (e.KeyCode == Keys.Enter)
            {
                // make boolean variable as " ContactHomeIsCorrect" , for controlling the while loop.
                Boolean ContactHomeIsCorrect = false;

                // The value of "phone_number_text" is assigned to the variable  "ContactPersonal".
                ContactHome = Contact_Home_text.Text;


                while (ContactHomeIsCorrect != true)
                {
                    if (ContactHome=="")
                    {
                        // phone_number_text is empty...
                        Contact_Home_label.Visible=true;
                        Contact_Home_text.Focus();
                        ContactHomeIsCorrect  = true;
                        break;
                    }
                    else
                    {
                        if (ContactHome.Length == 10 && ContactHome.All(char.IsDigit) && ContactHome[0] == '0')
                        {

                            //Correct phone number...
                            Contact_Home_label.Visible = false;
                            Email_text.Focus();
                            ContactHomeIsCorrect =true;
                            break;
                        }
                        else
                        {
                            //Incorrect phone number...
                            Contact_Home_label.Visible= true;
                            Contact_Home_text.Focus();
                            Contact_Home_text.Clear();
                            ContactHomeIsCorrect=false;
                            break;
                        }
                    }
                }
            }
        }

        private void Email_text_KeyDown(object sender, KeyEventArgs e)
        {
            // add keyDown event for press Enter Key.
            if (e.KeyCode == Keys.Enter)
            {
                // make boolean variable as " EmailIsCorrect" , for controlling the while loop.
                Boolean EmailIsCorrect = false;

                // The value of "phone_number_text" is assigned to the variable  "Email".
                Email = Email_text.Text;


                while (EmailIsCorrect != true)
                {
                    if (Email=="")
                    {
                        Email_label.Visible=true;
                        Email_text.Focus();
                        EmailIsCorrect = true;
                        break;
                    }
                    else
                    {
                        if (Email.Length>1 && Email.Contains("@"))
                        {
                            Email_label.Visible=false;
                            Address_text.Focus();
                            EmailIsCorrect=true;
                            break;
                        }
                        else
                        {
                            Email_label.Visible=true;
                            Email_text.Focus();
                            Email_text.Clear();
                            EmailIsCorrect=true;
                            break;

                        }
                    }

                }
            }
        }

        private void Address_text_KeyDown(object sender, KeyEventArgs e)
        {

            // add keyDown event for press Enter Key.
            if (e.KeyCode == Keys.Enter)
            {
                // make boolean variable as " AddressIsCorrect" , for controlling the while loop.
                Boolean AddressIsCorrect = false;

                // The value of "Address_text" is assigned to the variable  "Address".
                Address = Address_text.Text;


                while (AddressIsCorrect != true)
                {
                    if (Address=="")
                    {
                        Address_label.Visible=true;
                        Address_text.Focus();
                        AddressIsCorrect = true;
                        break;
                    }
                    else
                    {
                        Address_label.Visible=false;
                        City_text.Focus();
                        AddressIsCorrect=true;
                        break;
                    }
                }
            }
        }

        private void City_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // make boolean variable as " CityIsCorrect" , for controlling the while loop.
                Boolean CityIsCorrect = false;

                // The value of "Address_text" is assigned to the variable  "Address".
                City = City_text.Text;


                while (CityIsCorrect != true)
                {
                    if (City=="")
                    {
                        City_label.Visible=true;
                        City_text.Focus();
                        CityIsCorrect = false;
                        break;
                    }
                    else
                    {
                        if (City.All(char.IsLetter))
                        {
                            City_label.Visible=false;
                            Zip_code_text.Focus();
                            CityIsCorrect=true;
                            break;
                        }
                        else
                        {
                            City_label.Visible=true;
                            City_text.Focus();
                            City_text.Clear();
                            CityIsCorrect=true;
                            break;
                        }
                       
                    }
                }
            }
        }

        private void Zip_code_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zip_code_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // ....make boolean variable as " ZipCodeIsCorrect " , for controlling the while loop.
                Boolean ZipCodeIsCorrect = false;

                // ...The value of "zip_code_text" is assigned to the variable  "ZipCodeIsCorrect".
                ZipCode = Zip_code_text.Text;

                while (ZipCodeIsCorrect!=true)
                {
                    if (ZipCode == "")
                    {
                        Zip_code_label.Visible = false;
                        Zip_code_text.Focus();
                        ZipCodeIsCorrect = false;
                        break;
                    }
                    else 
                    {
                        
                        if (ZipCode.Length == 5 && ZipCode.All(char.IsDigit))
                        {
                            Zip_code_label.Visible= false;
                            ZipCodeIsCorrect = true;
                            break;
                        }
                        else 

                        {
                            Zip_code_label.Visible = true;
                            Zip_code_text.Clear();
                            Zip_code_text.Focus();
                            ZipCodeIsCorrect = false;
                            break;
                        }
                    }
                }
            }
        }
    }
}
