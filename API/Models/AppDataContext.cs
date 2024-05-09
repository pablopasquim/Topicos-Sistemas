using Microsoft.EntityFrameworkCore;

namespace API.Models;

public class AppDbContext : DbContext
{
    public DbSet<Treino> Treino { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=nomeDoSeuBanco.db");
    }
}