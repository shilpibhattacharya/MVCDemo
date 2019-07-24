using Microsoft.EntityFrameworkCore;
using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Data
{
    public class EmployeeContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            string conn = @"server=DDC2-D-6RCR9B2\MSSQLSERVER01;database=MVCEmployee;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(conn);
        }

        public DbSet<Department> Departments{ get; set; }
    }
}
