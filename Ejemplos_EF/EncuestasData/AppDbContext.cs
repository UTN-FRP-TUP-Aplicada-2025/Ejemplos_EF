using EncuestasData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EncuestasData;

public class AppDbContext : DbContext
{
    private const string ConnectionString= "Data Source=DEV;Initial Catalog=Ejemplos_EF_db;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=True;Trust Server Certificate=True;Command Timeout=0";

    public DbSet<Respuesta> Respuestas { get; set; }

    public AppDbContext()
    {
        //la clave del exito!!!
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Respuesta>().ToTable("Respuestas");
    }
}
