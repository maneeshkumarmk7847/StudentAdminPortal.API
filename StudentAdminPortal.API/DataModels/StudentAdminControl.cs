using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.DataModels
{
    public class StudentAdminContext: DbContext
    {
        public StudentAdminContext(DbContextOptions<StudentAdminContext> options) : base(options)
        {
        }
        public DbSet<Student>Student { get; set; }
        public DbSet<Student> Gender { get; set; }
        public DbSet<Student> Address { get; set; }
    }
}
