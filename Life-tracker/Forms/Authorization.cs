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
        bool hidePasword = true;
        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

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
                tbPassword.Text = "";

            if (hidePasword)
                tbPassword.PasswordChar = '●';
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text) || tbPassword.Text == "Password")
            {
                tbPassword.PasswordChar = '\0';
                tbPassword.Text = "Password";
            }
        }

        private void eye_Click(object sender, EventArgs e)
        {
            string eyeIconPath = "D:\\Life-tracker\\Life-tracker\\Images\\eye_icon.png";
            string eyeOffIconPath = "D:\\Life-tracker\\Life-tracker\\Images\\eye_off_icon.png";

            if (hidePasword)
            {
                eye.Image = Image.FromFile(eyeIconPath);
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                eye.Image = Image.FromFile(eyeOffIconPath);
                if (tbPassword.Text != "Password")
                    tbPassword.PasswordChar = '●';
            }

            hidePasword = !hidePasword;
        }
    }
}
