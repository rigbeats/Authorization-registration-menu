using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Life_tracker.Entity_classes;

namespace Life_tracker
{
    internal class UserDbContext : DbContext
    {
        public UserDbContext() : base("UserConnection")
        {
        }

        public DbSet<User> users { get; set; }
    }
}
