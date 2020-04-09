using Microsoft.EntityFrameworkCore;
using RecipesApp.API.Models;

namespace RecipiesApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}