using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MtecDevs.Models;

namespace MtecDevs.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions opcoes) : base(opcoes)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<TipoDev> TipoDevs { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        AppDbSeed appDbSeed = new(builder);

        // FluentAPI
    }
}
