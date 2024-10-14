using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Damean_Andrei_Stefan_Lab2.Models;

namespace Damean_Andrei_Stefan_Lab2.Data
{
    public class Damean_Andrei_Stefan_Lab2Context : DbContext
    {
        public Damean_Andrei_Stefan_Lab2Context (DbContextOptions<Damean_Andrei_Stefan_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Damean_Andrei_Stefan_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Damean_Andrei_Stefan_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Damean_Andrei_Stefan_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
