using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WpfApp1.Data;

namespace WpfApp1.Service
{
    public static class DbContextFactory
    {
        private static readonly string _dbConnectionString =
           "Host=localhost;Port=5432;Database=learn_foreign;Username=postgres;Password=postgres";

        public static AppDbContext GetContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseNpgsql(_dbConnectionString)
                .Options;

            return new AppDbContext(options);
        }
    }
}
