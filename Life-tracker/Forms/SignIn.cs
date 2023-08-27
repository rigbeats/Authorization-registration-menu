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
using Authorization_registration_menu.Entity_classes;
using Authorization_registration_menu.Forms;
using System.Threading;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;

namespace Authorization_registration_menu
{
    public partial class SignIn : Form
    {
        bool hidePasword = true;
        Thread thread = null;
        string ImagePath = Path.GetFullPath(Path.Combine(Application.StartupPath, "..\\.."));

        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            label1.Select();
        }

        private void tbLogin_Enter(object sender, EventArgs e)
        {
            if (tbLogin.Text == "Login")
            {
                tbLogin.Text = "";
            }
        }

        private void tbLogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLogin.Text))
            {
                tbLogin.Text = "Login";
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
            string eyeIconPath = Path.Combine(ImagePath, "Icons\\eye_icon.png");
            string eyeOffIconPath = Path.Combine(ImagePath, "Icons\\eye_off_icon.png");

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

        private void bSignUp_MouseDown(object sender, MouseEventArgs e)
        {
            string imagePath = Path.Combine(ImagePath, "Images\\ThinButtonAfterClick.png");
            bSignUp.Image = Image.FromFile(imagePath);

            lSignUp.BackColor = System.Drawing.Color.FromArgb(113, 180, 161);
        }

        private void bSignUp_MouseUp(object sender, MouseEventArgs e)
        {
            string imagePath = Path.Combine(ImagePath, "Images\\ThinButton.png");
            bSignUp.Image = Image.FromFile(imagePath);

            lSignUp.BackColor = System.Drawing.Color.FromArgb(151, 220, 203);
        }

        private void bSignUp_MouseEnter(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(ImagePath, "Images\\ThinButtonAfterEnter.png");
            bSignUp.Image = Image.FromFile(imagePath);

            lSignUp.BackColor = System.Drawing.Color.FromArgb(176, 237, 225);
        }

        private void bSignUp_MouseLeave(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(ImagePath, "Images\\ThinButton.png");
            bSignUp.Image = Image.FromFile(imagePath);

            lSignUp.BackColor = System.Drawing.Color.FromArgb(151, 220, 203);
        }

        private void bSignUp_Click(object sender, EventArgs e)
        {
            OpenNewForm(new SignUp());
        }

        private void OpenNewForm(Form newForm)
        {
            this.Close();

            thread = new Thread(() => NewThread(newForm));
            thread.Start();
        }

        private void NewThread(Form newForm)
        {
            Application.Run(newForm);
        }

        private void bSignIn_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;

            if (login == "Login" || password == "Password")
            {
                var attentionForm = new AttentionForm("All fields must be filled in!");
                attentionForm.ShowDialog();
            }

            else
            {
                using (var context = new UserDbContext())
                {
                    bool accountExists = context.users.Any(x => x.Login == login && x.Password == password);

                    if (accountExists)
                    {
                        OpenNewForm(new MainForm());
                    }
                    else
                    {
                        var attentionForm = new AttentionForm("Invalid username or password entered");
                        attentionForm.ShowDialog();
                    }
                }
            }
        }
    }
}
