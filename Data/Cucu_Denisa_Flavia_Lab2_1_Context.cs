using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cucu_Denisa_Flavia_Lab2_1_.Models;

namespace Cucu_Denisa_Flavia_Lab2_1_.Data
{
    public class Cucu_Denisa_Flavia_Lab2_1_Context : DbContext
    {
        public Cucu_Denisa_Flavia_Lab2_1_Context(DbContextOptions<Cucu_Denisa_Flavia_Lab2_1_Context> options)
            : base(options)
        {
        }

        public DbSet<Cucu_Denisa_Flavia_Lab2_1_.Models.Book> Book { get; set; } = default!;

        public DbSet<Cucu_Denisa_Flavia_Lab2_1_.Models.Publisher>? Publisher { get; set; }

        public DbSet<Cucu_Denisa_Flavia_Lab2_1_.Models.Author>? Author { get; set; }
    }
}