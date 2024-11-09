using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System;




namespace DAL
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {

        private readonly static string connectionString = ConfigurationManager.ConnectionStrings["DBSql"].ConnectionString;

        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new AppDbContext(optionsBuilder.Options);
        }

    }
}
