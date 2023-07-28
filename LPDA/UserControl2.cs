using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//  <---- use SQL CLIENT.

namespace LPDA
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void user_name_Click(object sender, EventArgs e)
        {
            string query = "SELECT lawer_password FROM lawer_data_table WHERE lawer_user_name ";
            string password = string.Empty;//  <---- Make a variable as PASSWORD for assign password readed in QUERY -->lpda-Database -->lawer_data_table-Data Table -->lawer_password-Data Colum

            using (SqlDataReader reader = SQL.ExecuteReader(query))
            {
                if (reader.Read())
                {
                    password = reader["lawer_password"].ToString();
                }
            }
        }
    }
}
