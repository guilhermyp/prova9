using microsoft.EntityFramework.Core;
namespace ProjetoImc.Models;

public class AppDataContext : DbContext
{
    public Dbset<Aluno> Aluno { get; set; }
    public Dbset<Imc> Imc { get; set; } 

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data source = BancoProjetoImc.db");
    }
}