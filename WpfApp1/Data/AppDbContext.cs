using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using WpfApp1.Data.Models;

namespace WpfApp1.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<Word> Words { get; set; }
    }
}
