
using Microsoft.EntityFrameworkCore;
using ProjetoCrud.Entitie;

namespace ProjetoCrud.Context;
public class ClienteContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-15CIMC2\\localhost; Initial Catalog=Cliente; Integrated Security=true");
    }
}