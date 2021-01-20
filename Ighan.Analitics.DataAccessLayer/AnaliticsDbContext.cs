using Ighan.Analitics.StorageModels;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace Ighan.Analitics.DataAccessLayer
{
    public class AnaliticsDbContext : DbContext
    {
        public AnaliticsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Device> Devices { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }
    }
}
