using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExamenFinal.Models;

namespace ExamenFinal.Data
{
    public class ExamenFinalContext : DbContext
    {
        public ExamenFinalContext (DbContextOptions<ExamenFinalContext> options)
            : base(options)
        {
        }

        public DbSet<ExamenFinal.Models.Funcionario> Funcionarios { get; set; } = default!;
    }
}
