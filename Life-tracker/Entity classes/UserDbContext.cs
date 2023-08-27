using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authorization_registration_menu.Entity_classes;

namespace Authorization_registration_menu
{
    internal class UserDbContext : DbContext
    {
        public UserDbContext() : base("UserConnection")
        {
        }

        public DbSet<User> users { get; set; }
    }
}
