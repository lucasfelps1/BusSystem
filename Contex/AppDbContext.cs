using BusSystemConsole.EntityConfigs;
using BusSystemConsole.Models;
using Microsoft.EntityFrameworkCore;

namespace BusSystemConsole.Contex;
public class AppDbContext : DbContext
{   
    public DbSet<Onibus> Onibus {get; set;}
    public DbSet<Terminal> Terminal { get; set; }

    const string stringConexaoSql = "Server=localhost; User ID=root; Password=1234; Database=BusStationDB";
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseMySql(stringConexaoSql, ServerVersion.AutoDetect(stringConexaoSql));
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new OnibusEntityConfigs());
        builder.ApplyConfiguration(new TerminalEntityConfigs());
    }
}