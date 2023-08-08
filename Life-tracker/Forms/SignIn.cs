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
using Life_tracker.Forms;
using System.Threading;
using System.Security.Cryptography;

namespace Life_tracker
{
    public partial class SignIn : Form
    {
        bool hidePasword = true;
        Thread thread = null;

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
            string eyeIconPath = "D:\\Life-tracker\\Life-tracker\\Icons\\eye_icon.png";
            string eyeOffIconPath = "D:\\Life-tracker\\Life-tracker\\Icons\\eye_off_icon.png";

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
            string imagePath = "D:\\Life-tracker\\Life-tracker\\Images\\ThinButtonAfterClick.png";
            bSignUp.Image = Image.FromFile(imagePath);

            lSignUp.BackColor = System.Drawing.Color.FromArgb(113, 180, 161);
        }

        private void bSignUp_MouseUp(object sender, MouseEventArgs e)
        {
            string imagePath = "D:\\Life-tracker\\Life-tracker\\Images\\ThinButton.png";
            bSignUp.Image = Image.FromFile(imagePath);

            lSignUp.BackColor = System.Drawing.Color.FromArgb(151, 220, 203);
        }

        private void bSignUp_MouseEnter(object sender, EventArgs e)
        {
            string imagePath = "D:\\Life-tracker\\Life-tracker\\Images\\ThinButtonAfterEnter.png";
            bSignUp.Image = Image.FromFile(imagePath);

            lSignUp.BackColor = System.Drawing.Color.FromArgb(176, 237, 225);
        }

        private void bSignUp_MouseLeave(object sender, EventArgs e)
        {
            string imagePath = "D:\\Life-tracker\\Life-tracker\\Images\\ThinButton.png";
            bSignUp.Image = Image.FromFile(imagePath);

            lSignUp.BackColor = System.Drawing.Color.FromArgb(151, 220, 203);
        }

        private void bSignUp_Click(object sender, EventArgs e)
        {
            OpenNewForm(new SignUp());
        }

        public void OpenNewForm(Form newForm)
        {
            this.Close();
            thread = new Thread(() => NewThread(newForm));

            thread.Start();
        }

        public void NewThread(Form newForm)
        {
            Application.Run(newForm);
        }

        private void bSignIn_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;

            if (login == "Login" || password == "Password")
                MessageBox.Show("Все поля должны быть заполнены");

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
                        MessageBox.Show("Введен неверный логин или пароль");
                }
            }
        }
    }
}
