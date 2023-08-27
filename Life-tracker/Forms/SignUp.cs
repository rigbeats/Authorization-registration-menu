using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Authorization_registration_menu.Entity_classes;

namespace Authorization_registration_menu.Forms
{
    public partial class SignUp : Form
    {
        Thread thread = null;

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            label1.Select();
        }

        private void tbFirsname_Enter(object sender, EventArgs e)
        {
            if (tbFirstname.Text == "Firstname")
            {
                tbFirstname.Text = "";
            }
        }

        private void tbFirsname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFirstname.Text))
            {
                tbFirstname.Text = "Firstname";
            }
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
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                tbPassword.Text = "Password";
            }
        }

        private void bSignIn_MouseDown(object sender, MouseEventArgs e)
        {
            string imagePath = "D:\\Life-tracker\\Life-tracker\\Images\\ThinButtonAfterClick.png";
            bSignIn.Image = Image.FromFile(imagePath);

            lSignIn.BackColor = Color.FromArgb(113, 180, 161);
        }

        private void bSignIn_MouseUp(object sender, MouseEventArgs e)
        {
            string imagePath = "D:\\Life-tracker\\Life-tracker\\Images\\ThinButton.png";
            bSignIn.Image = Image.FromFile(imagePath);

            lSignIn.BackColor = Color.FromArgb(151, 220, 203);
        }

        private void bSignIn_MouseEnter(object sender, EventArgs e)
        {
            string imagePath = "D:\\Life-tracker\\Life-tracker\\Images\\ThinButtonAfterEnter.png";
            bSignIn.Image = Image.FromFile(imagePath);

            lSignIn.BackColor = Color.FromArgb(176, 237, 225);
        }

        private void bSignIn_MouseLeave(object sender, EventArgs e)
        {
            string imagePath = "D:\\Life-tracker\\Life-tracker\\Images\\ThinButton.png";
            bSignIn.Image = Image.FromFile(imagePath);

            lSignIn.BackColor = Color.FromArgb(151, 220, 203);
        }

        private void bSignIn_Click(object sender, EventArgs e)
        {
            OpenNewForm(new SignIn());
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

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string firstname = tbFirstname.Text;
            string login = tbLogin.Text;
            string password = tbPassword.Text;

            if (firstname == "Firstname" ||
                login == "Login" ||
                password == "Password")
            {
                var attentionForm = new AttentionForm("All fields must be filled in");
                attentionForm.ShowDialog();
            }

            else
                using (var context = new UserDbContext())
                {
                    bool accauntExist = context.users.Any(x => x.Login == login);

                    if (!accauntExist)
                    {
                        var user = new User()
                        {
                            Firstname = firstname,
                            Login = login,
                            Password = password,
                        };

                        context.users.Add(user);
                        context.SaveChanges();

                        var sucsessfulForm = new SuccessfulForm("Account successfully created");
                        sucsessfulForm.ShowDialog();
                        
                    }

                    else
                    {
                        var attentionForm = new AttentionForm("The login is already occupied");
                        attentionForm.ShowDialog();
                    }
                }
        }
    }
}
