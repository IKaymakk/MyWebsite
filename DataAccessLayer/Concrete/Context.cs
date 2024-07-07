using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class Context : DbContext
    {
        public DbSet<MySkills> Skills { get; set; }
        public DbSet<MyService> Services { get; set; }
        public DbSet<MyProjects> Projects { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
