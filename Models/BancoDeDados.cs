using Microsoft.EntityFrameworkCore;

namespace CRUD_CSharp.Models
{

    public class BancoDeDados : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=CRUD_CSharp;Integrated Security=True");
        }
    }
 
}
