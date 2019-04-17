using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreTest.Server
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Shared.Employee> Employees { get; set; }
    }
}
