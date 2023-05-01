using BlogProject.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogProject.Server.DBModels

{
    public class DataBaseContext : DbContext
    {
        public DbSet<BlogPost> Posts { get; set; }
        public DbSet<Benutzers> Nutzer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)/MSSQLLocalDB;Database=BlogDB;Trusted_Connection=True");
        }
    }
}
