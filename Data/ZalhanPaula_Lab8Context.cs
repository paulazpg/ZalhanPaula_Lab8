using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZalhanPaula_Lab8.Models;

namespace ZalhanPaula_Lab8.Data
{
    public class ZalhanPaula_Lab8Context : DbContext
    {
        public ZalhanPaula_Lab8Context (DbContextOptions<ZalhanPaula_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<ZalhanPaula_Lab8.Models.Book> Book { get; set; }

        public DbSet<ZalhanPaula_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<ZalhanPaula_Lab8.Models.Category> Category { get; set; }

        public DbSet<ZalhanPaula_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
