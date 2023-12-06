using System;
using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project.data
{
    public class MVCDemoDb : DbContext
    {
        public MVCDemoDb(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}

