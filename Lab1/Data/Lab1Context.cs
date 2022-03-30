#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab1.Models;

namespace Lab1.Data
{
    public class Lab1Context : DbContext
    {
        public Lab1Context (DbContextOptions<Lab1Context> options)
            : base(options)
        {
        }

        public DbSet<Lab1.Models.Client> Client { get; set; }
    }
}
