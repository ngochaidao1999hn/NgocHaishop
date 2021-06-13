using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using NgocHaishop.Data.EF;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NgocHaishop.Data.EF
{
    public class NgocHaiShopDbContextFactory : IDesignTimeDbContextFactory<NgocHaiShopDbContext>
    {
        public NgocHaiShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var optionsBuilder = new DbContextOptionsBuilder<NgocHaiShopDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ngochaishop"));
            return new NgocHaiShopDbContext(optionsBuilder.Options);
        }
    }
}
