using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPDA
{
    public partial class dashboard_form : Form
    {
        bool SideBarExpand;
        bool HomeCollapsed;
        

        public dashboard_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(sidebar.Width == sidebar.MinimumSize.Width)) {
                HomeTimer.Start();
                SidebarTimer.Start();
            }

            if (sidebar.Width == sidebar.MinimumSize.Width){
                HomeTimer.Start();
                SidebarTimer.Start();
            }



        }

        private void dashboard_form_Load(object sender, EventArgs e)
        {

        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            // if  sidebar is expand, minimze 
            if (SideBarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    SideBarExpand = false;
                    SidebarTimer.Stop();
                }

            }
            else
            {
                //
                sidebar.Width += 10;
                if(sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    SideBarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }

        private void munu_tag_icon_picture_Click(object sender, EventArgs e)
        {
            // ...menu butten is start "sidebarTimer" timer...
            SidebarTimer.Start();

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            if (HomeCollapsed)
            {
                home_contener.Height += 10;
                if (home_contener.Height >= home_contener.MaximumSize.Height)
                {
                    HomeCollapsed = false;
                    HomeTimer.Stop();
                }
            }
            else
            {
                home_contener.Height -= 10;
                if (home_contener.Height <= home_contener.MinimumSize.Height)
                {
                    HomeCollapsed = true;
                    HomeTimer.Stop();
                }
            }
        }

        private void setings_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
            HomeTimer.Start();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
            HomeTimer.Start();
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
            HomeTimer.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
            HomeTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
            
        }

        private void event_button_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QA_panel.Hide();
            About_panel.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            About_panel.Hide();
            QA_panel.Show();
        }

        private void developer_team_Click(object sender, EventArgs e)
        {
            developer_Team_Panel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            developer_Team_Panel.Hide();
        }

        private void About_panel_MouseClick(object sender, MouseEventArgs e)
        {
            developer_Team_Panel.Hide();
        }

        private void QA_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SidebarTimerEx_Tick(object sender, EventArgs e)
        {
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String mailAddr = mailAddrTextBox.Text;
            string body = bodyTextBox.Text;

            sendEmail(mailAddr , body);
        }
  
        public void sendEmail(string recipientAddress, string mailBody)
        {
          

                try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                // Your Gmail credentials
                string senderEmail = "ridmashehan22@gmail.com";
                string senderPassword = "rdtk cyhs urie kdta"; // Replace with your actual password

                mail.From = new MailAddress(senderEmail);
                mail.To.Add(senderEmail);
                mail.Subject = "Lawyers Q&A";
                mail.Body = (mailBody + "\n\n\n" +"From\t:"+ recipientAddress + "Name Of Lawer :\t");

                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential(senderEmail, senderPassword);
                smtp.EnableSsl = true;
                smtp.Send(mail);

                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
