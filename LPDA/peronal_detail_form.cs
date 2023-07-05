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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LPDA
{
    public partial class peronal_detail_form : Form
    {
        public String Name;
        public String NIC;
        public String Age;

        public peronal_detail_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the contact_details f2
            contact_details f2 = new contact_details();
            //Hide the create form
            this.Hide();
            //Show the create contact_details f2
            f2.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //close the current form
            this.Close();
            this.Hide();
            //go to ealier form
            client_registration_form f3 = new client_registration_form();
            //show the create form
            f3.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NIC_NO_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Full_Name_text_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Full_Name_text_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // make boolean variable as " NameIsCorrect " , for controlling the while loop.
                Boolean NameIsCorrect = false;

                // The value of "Full_Name_text" is assigned to the variable  "Name".
                Name = Full_Name_text.Text;

                // while loop.
                while (NameIsCorrect != true)
                {
                    if (Name == "")
                    {
                        Full_Name_label.Visible = false;
                        Full_Name_label.Visible = true;
                        Full_Name_text.Focus();
                        NameIsCorrect = true;
                        break;
                    }
                    else
                    {
                        if (Name.All(char.IsLetter))
                        {
                            Full_Name_label.Visible=false;
                            NIC_NO_text.Focus();
                            NameIsCorrect=true;
                            break;
                        }
                        else
                        {
                            Full_Name_label.Visible=true;
                            Full_Name_text.Focus();
                            Full_Name_text.Clear();
                            NameIsCorrect=false;
                            break;
                        }
                        
                    }
                }
            }


        }

        private void NIC_NO_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // make boolean variable as " NICIsCorrect " , for controlling the while loop.
                Boolean NICIsCorrect = false;

                // The value of "Full_Name_text" is assigned to the variable  "Name".
                NIC = NIC_NO_text.Text;

                // while loop.
                while (NICIsCorrect != true)
                {
                    if (NIC =="")
                    {
                        NIC_label.Visible = true;
                        NIC_NO_text.Focus();
                        NICIsCorrect = false;
                        break;
                    }
                    else
                    {
                        if (NIC.Length == 12 && NIC.All(char.IsDigit))
                        {
                            NIC_label.Visible = false;
                            dateTimePicker.Focus(); 
                            NICIsCorrect = true;
                            break;
                        }
                        else
                        {
                            if (NIC.Length == 10 && NIC.Contains('v'))
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    if (!char.IsDigit(NIC[i]))
                                    {

                                        NIC_label.Visible = true;
                                        NIC_NO_text.Clear();
                                        NIC_NO_text.Focus();
                                        NICIsCorrect = false;
                                        break;
                                    }
                                    else
                                    {
                                        NIC_label.Visible = false;
                                        dateTimePicker.Focus();
                                        NICIsCorrect = true;
                                        break;
                                    }
                                }

                            }
                            else
                            {
                                NIC_label.Visible = true;
                                dateTimePicker.Focus();
                                NICIsCorrect = false;
                                break;
                            }
                        }

                    }

                }
            }
        }


                private void Age_textBox_KeyDown(object sender, KeyEventArgs e)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        // make boolean variable as " AgeIsCorrect " , for controlling the while loop.
                        Boolean AgeIsCorrect = false;

                        // The value of "Age_text" is assigned to the variable  "Age".
                        Age = Age_text.Text;

                        // while loop.
                        while (AgeIsCorrect != true)
                        {
                            if (Age =="")
                            {
                                Age_label.Visible = true;
                                Age_text.Focus();
                                AgeIsCorrect = false;
                                break;
                            }
                            else
                            {
                                if (Age.All(char.IsDigit))
                                {
                                    Age_label.Visible = false;
                                    Female_radio.Checked = true;
                                    Gender_label.Visible = false;
                                    AgeIsCorrect = true;
                                }
                                else
                                { 
                                    Age_label.Visible = true;
                                    Age_text.Clear();
                                    Age_text.Focus();
                                    AgeIsCorrect = true;
                                }

                            }

                        }
                    }
                }
            }
        }
    



