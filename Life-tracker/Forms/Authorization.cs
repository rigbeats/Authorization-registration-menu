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
            using(var context = new UserDbContext())
            {       
                /*
                var Users = context.users.ToList();

                foreach (var user in Users)
                {
                    MessageBox.Show(user.Login);
                }
                */
            }
        }
    }
}
