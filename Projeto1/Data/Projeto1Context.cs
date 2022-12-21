using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto1.Models;

namespace Projeto1.Data
{
    public class Projeto1Context : DbContext
    {
        public Projeto1Context (DbContextOptions<Projeto1Context> options)
            : base(options)
        {
        }

        public DbSet<Projeto1.Models.Department> Department { get; set; }
    }
}
