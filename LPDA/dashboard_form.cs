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
            SidebarTimer.Start();
            HomeTimer.Start();
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
            SidebarTimer.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }
    }
}
