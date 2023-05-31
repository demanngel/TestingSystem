using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TestingSystem
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }

        public ApplicationContext() : base("DefaultConnection") { }

    }
}
