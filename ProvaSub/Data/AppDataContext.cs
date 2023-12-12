using Microsoft.EntityFrameworkCore;
using ProvaSub.Model;


namespace ProvaSub.Data;

public class AppDataContext : DbContext {
    public AppDataContext (DbContextOptions<AppDataContext> options) : base (options)
    {
        
    }
    public DbSet<Aluno> Aluno { get; set; }
    public DbSet<Imc> Imc { get; set; }

}