using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization_registration_menu.Entity_classes
{
    internal class User
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }
    }
}
