using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_injection_core.Models
{
    public class applicationconnection :DbContext
    {
        public applicationconnection(DbContextOptions<applicationconnection> options):base(options)
        {
                
        }
        public DbSet<Employee> Employees { get; set; }

    }
}
