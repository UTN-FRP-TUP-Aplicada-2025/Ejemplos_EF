using EncuestasData.Models;
using Microsoft.EntityFrameworkCore;


namespace EncuestasData;
public class AppDbContext : DbContext
{
    public DbSet<Respuesta> Respuestas { get; set; }
    //public DbSet<Otro> Otros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    { 
      // options.UseSqlServer("Server=.;Database=Ejemplos_EF_db;Trusted_Connection=True;Trust Server Certificate=True;");
       string connectionString = "Data Source=DEV;Initial Catalog=Ejemplos_EF_db;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=True;Trust Server Certificate=True;Command Timeout=0";
        options.UseSqlServer(connectionString);
    }
}
