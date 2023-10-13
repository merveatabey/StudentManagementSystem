using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<User, UserRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-M507MMV;database=StudentManagementSystem;integrated security = true;TrustServerCertificate=True");
        }

        public DbSet<StudentInfo> StudentInfos { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<test> tests { get; set; }
    
    }

    
}
