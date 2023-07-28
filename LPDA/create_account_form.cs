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
        LRegDate data = new LRegDate();
      

        public create_account_form()
        {
            

            InitializeComponent( );
            
            Surname_txet_box.Text = data.Surname;
    }
        private void UpdateData(LRegDate updatedData)
        {
            // Update the 'data' instance with the updated data
            data = updatedData;
        }
        private void create_account_form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Surname_txet_box; //<----- FOCUS first text box after FORM LOAD.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //===============================================================

            bool SurnameNameIsCorrect = false;//  <---- This code is check SURNAME IS CORRECT.
            data.Surname = Surname_txet_box.Text;
            
            if (data.Surname == "")
            {
                surname_error_picture.Visible = true;
                label1.Visible = true;
                SurnameNameIsCorrect = false;
                   
            }
            else
            {
                surname_error_picture.Visible = false;
                label1.Visible = false;
                surname_correct_picture.Visible = true;
                first_name_text_box.Focus();
                SurnameNameIsCorrect=true;
                   
                }

            //=================================================================
            bool FirstNameNameIsCorrect = false; //  <---- This code is check FIRST NAME IS CORRECT.
            data.FirstName = first_name_text_box.Text;

                    if (data.FirstName == "")
                    {
                        first_name_error_picture.Visible = true;
                        label2.Visible = true;
                        FirstNameNameIsCorrect = false;
                    }
                    else
                    {
                        first_name_error_picture.Visible = false;
                        label2.Visible = false;
                        first_name_correct_picture.Visible = true;
                        second_name_text_box.Focus();
                        FirstNameNameIsCorrect = true;
                    }

                    //=================================================================

                     bool SecondNameNameIsCorrect = false;//   <---- This code is check SURNAME IS CORRECT.
                    data.SecondName = first_name_text_box.Text;
                   
                    
                    if (data.FirstName == "")
                    {
                        second_name_error_picture.Visible = true;
                        label3.Visible = true;
                        SecondNameNameIsCorrect = false;
               
                    }
                    else
                    {
                        second_name_error_picture.Visible = false;
                        label3.Visible = false;
                        second_name_correct_picture.Visible = true;
                        ID_number_text_box.Focus();
                        SecondNameNameIsCorrect=true;
                   
                    }

                //=================================================================
                bool IDNumberIsCorrect = false;//   <----This code is check ID NUMBER IS CORRECT.
                data.IDNumber = ID_number_text_box.Text;

            

                if (data.IDNumber == "")
                {
                    ID_number_error_picture.Visible = true;
                    label4.Visible = true;
                    label7.Visible = false;
                    IDNumberIsCorrect = false;
                    

                }
                else
                {

                    if (data.IDNumber.Length == 12 && data.IDNumber.All(char.IsDigit))
                    {
                        ID_number_error_picture.Visible = false;
                        label4.Visible = false;
                        label7.Visible = false;
                        id_correct_picture.Visible = true;
                        IDNumberIsCorrect = true;
                        
                    }
                    else
                    {
                        if (data.IDNumber.Length == 10 && data.IDNumber.Contains('v'))
                        {
                            for (int i = 0; i < 9; i++)
                            {
                                if (!char.IsDigit(data.IDNumber[i]))
                                {
                                    ID_number_error_picture.Visible = true;
                                    label7.Visible = true;
                                    label4.Visible = false;
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
                        label4.Visible = false;
                        IDNumberIsCorrect = false;
                        
                    }
                    }

                }
                //=================================================================
           
            //================================================================

            //DateTime DateOfBirth = dateTimePicker1.Value;//  <---- This part is GET the USER INPUTED DATE.
            //MessageBox.Show(DateOfBirth.ToString());
            Boolean DateOfBirthIsCorrect = false;
            DateTime currentDate = DateTime.Now;
            DateTime DateOfBirth = dateTimePicker1.Value;

            // Define the minimum and maximum age ranges
            int minimumAge = 18; // Minimum age in years
            int maximumAge = 100; // Maximum age in years

            // Calculate the minimum and maximum birthdates based on the age range
            DateTime minimumBirthdate = currentDate.AddYears(-maximumAge);
            DateTime maximumBirthdate = currentDate.AddYears(-minimumAge);

            if (DateOfBirth < minimumBirthdate || DateOfBirth > maximumBirthdate)
            {
                birthday_error_picture.Visible = true;
                birthday_correct_picture.Visible = false;
                DateOfBirthIsCorrect = false;
                MessageBox.Show("Invalid birthdate. Please select a valid date within the age range.");
                // You can optionally reset the value to a default date or take other actions.
                // For example:
                // dateTimePicker1.Value = DateTime.Now;
            }
            else
            {
                birthday_error_picture.Visible=false;
                birthday_correct_picture.Visible = true;
                DateOfBirthIsCorrect=true;
                data.DateOfBirth = DateOfBirth;



            }

            //=================================================================

            if (male_radio_button.Checked || female_radio_button.Checked || other_radio_button.Checked)
            {

                if (male_radio_button.Checked)
                {
                    data.Gender = "Male";
                }
                else if (female_radio_button.Checked)
                {
                    data.Gender = "Female";
                }
                else if (other_radio_button.Checked)
                {
                    data.Gender = "Other";
                }

                gender_correct_picture.Visible = true;
                gender_error_picture.Visible = false;
            }
            else
            {
                gender_error_picture.Visible = true;
                gender_correct_picture.Visible = false;
            }
            
            //=================================================================
            if (SurnameNameIsCorrect && FirstNameNameIsCorrect && SecondNameNameIsCorrect && IDNumberIsCorrect && DateOfBirthIsCorrect ) 
            {

                //MessageBox.Show(data.Gender);
                // Create an instance of the create_account_form_02

                // Hide the create_account_form
                this.Hide();
                create_account_form_02 create_account_form_02 = new create_account_form_02(data);
                // Show the create_account_form_02
                create_account_form_02.Show();
            }
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
                data.Surname = Surname_txet_box.Text;
                while (SurnameNameIsCorrect!= true)
                {
                    if(data.Surname == "")
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
                data.FirstName = first_name_text_box.Text;
                while (FirstNameNameIsCorrect != true)
                {
                    if (data.FirstName == "")
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
                data.SecondName = first_name_text_box.Text;
                while (SecondNameNameIsCorrect != true)
                {
                    if (data.FirstName == "")
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
                data.IDNumber =ID_number_text_box.Text;

                while (IDNumberIsCorrect != true)
                {
                   
                    if (data.IDNumber == "")
                    {
                        ID_number_error_picture.Visible = true;
                        label4.Visible = true;
                        ID_number_text_box.Focus();
                        IDNumberIsCorrect = false;
                        break;

                    }
                    else 
                    {

                        if (data.IDNumber.Length == 12 && data.IDNumber.All(char.IsDigit))
                        {
                             ID_number_error_picture.Visible = false;
                             label4.Visible = false;
                             label7.Visible = false;
                             id_correct_picture.Visible = true;
                             IDNumberIsCorrect = true;
                             dateTimePicker1.Focus();
                             break;
                        }
                        else
                        {
                            if (data.IDNumber.Length == 10 && data.IDNumber.Contains('v'))
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    if (!char.IsDigit(data.IDNumber[i]))
                                    {
                                        ID_number_error_picture.Visible = true;
                                        label7.Visible = true;
                                        label4.Visible = false;
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
                                ID_number_text_box.Focus();
                                ID_number_text_box.Clear();
                                IDNumberIsCorrect = false;
                                break;
                            }
                        }

                    }         
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
         
                bool SurnameNameIsCorrect = false;
                data.Surname = Surname_txet_box.Text;
                while (SurnameNameIsCorrect != true)
                {
                    if (data.Surname == "")
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
                        //first_name_text_box.Focus();
                        break;
                    }
                }
            
        }

        private void Surname_txet_box_Click(object sender, EventArgs e)
        {
            /*Surname_txet_box.Text = string.Empty;
            Surname_txet_box.ForeColor = Color.Black;*/
        }

        private void ID_number_text_box_Click(object sender, EventArgs e)
        {
            /*ID_number_text_box.Text = string.Empty;
            ID_number_text_box.ForeColor = Color.Black;*/
        }

        private void first_name_text_box_Click(object sender, EventArgs e)
        {
           /* first_name_text_box.Text = string.Empty;
            first_name_text_box.ForeColor = Color.Black;*/
        }

        private void second_name_text_box_Click(object sender, EventArgs e)
        {
            /*second_name_text_box.Text = string.Empty;
            second_name_text_box.ForeColor = Color.Black;*/
        }
        private void ID_number_text_box_TextChanged_1(object sender, EventArgs e)
        {
            bool IDNumberIsCorrect = false;
            data.IDNumber = ID_number_text_box.Text;

            while (IDNumberIsCorrect != true)
            {

                if (data.IDNumber == "")
                {
                    ID_number_error_picture.Visible = true;
                    label4.Visible = true;
                    IDNumberIsCorrect = false;
                    break;

                }
                else
                {

                    if (data.IDNumber.Length == 12 && data.IDNumber.All(char.IsDigit))
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
                        if (data.IDNumber.Length == 10 && data.IDNumber.Contains('v'))
                        {
                            for (int i = 0; i < 9; i++)
                            {
                                if (!char.IsDigit(data.IDNumber[i]))
                                {
                                    ID_number_error_picture.Visible = true;
                                    label7.Visible = true;
                                    label4.Visible = false;
                                    //ID_number_text_box.Clear();
                                    //ID_number_text_box.Focus();
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
            }
        }

        private void second_name_text_box_TextChanged(object sender, EventArgs e)
        {
            bool SecondNameNameIsCorrect = false;
            data.SecondName = first_name_text_box.Text;
            while (SecondNameNameIsCorrect != true)
            {
                if (data.FirstName == "")
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
                    //ID_number_text_box.Focus();
                    break;
                }
            }
        }

        private void first_name_text_box_TextChanged(object sender, EventArgs e)
        {
            bool FirstNameNameIsCorrect = false;
            data.FirstName = first_name_text_box.Text;
            while (FirstNameNameIsCorrect != true)
            {
                if (data.FirstName == "")
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
                    //second_name_text_box.Focus();
                    break;
                }
            }
        }
    }
}
