using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using Model;

namespace DataAccessLayer
{
    internal class Context : DbContext
    {
        public Context() : base("DbConnection") { }

        public DbSet<Student> Students { get; set; }
    }
}