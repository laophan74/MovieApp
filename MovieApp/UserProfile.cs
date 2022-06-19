using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            label_password.Visible = true;
            label_password2.Visible = true;
            guna2TextBox_newpassword.Visible = true;
            guna2TextBox_recentpassword.Visible = true;
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            label_password.Visible = false;
            label_password2.Visible = false;
            guna2TextBox_newpassword.Visible = false;
            guna2TextBox_recentpassword.Visible = false;
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
