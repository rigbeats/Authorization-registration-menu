using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Life_tracker.Entity_classes;

namespace Life_tracker
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            tbUsername.Text = "User";
            tbPassword.Text = "Password";

            using (var context = new UserDbContext())
            {       
                var Users = context.users.ToList();

                
            }
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text == "User")
            {
                tbUsername.Text = "";
            }
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                tbUsername.Text = "User";
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                tbPassword.Text = "Password";
            }
        }
    }
}
