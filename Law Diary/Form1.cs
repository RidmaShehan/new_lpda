using System.Text.RegularExpressions;

namespace Law_Diary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private bool IsCaseNumberValid(string caseNumber)
        {
            // Define the regular expression pattern for case number validation
            string pattern = @"^\d{5}[A-Za-z]{2}$"; // Example: 5 digits followed by 2 letters

            // Perform the validation using regular expressions
            Regex regex = new Regex(pattern);
            bool isValid = regex.IsMatch(caseNumber);

            return isValid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a case type.", "Case Type Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the event handler
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter the case number.", "Case Number Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the event handler
            }
            if (string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Please choose a legal authority.", "Legal Authority Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the event handler
            }
            if (dataGridView1.Rows.Count <= 1) // Assuming the DataGridView is named dataGridViewParties
            {
                MessageBox.Show("Please fill in the details of the parties involved.", "Parties Involved Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the event handler
            }
            string caseNumber = textBox1.Text; // Assuming textBox1 is the TextBox control for entering the case number

            bool isValid = IsCaseNumberValid(caseNumber);

            if (isValid)
            {
                // Case number is valid, proceed with further actions
                // ...
            }
            else
            {
                MessageBox.Show("Invalid case number. Please enter a valid case number.", "Invalid Case Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            {
                // Create an instance of Form2
                Form2 form2 = new Form2();

                // Show Form2
                form2.Show();

                // Close Form1 (optional)
                this.Close();
            }

        }
    }
}