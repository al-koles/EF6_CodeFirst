using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6_CodeFirst
{
    class UserContest : DbContext
    {
        public UserContest() : base("DBConnection")
        { }

        public DbSet<User> Users { get; set; }
    }
}
