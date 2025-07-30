using Abby_WebApp.Model;
using Abby_WebApp.Models.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Abby_WebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<FoodType> FoodType { get; set; }

        public DbSet<MenuItem> MenuItem { get; set; }
    }
}
