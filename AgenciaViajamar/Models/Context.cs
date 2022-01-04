using Microsoft.EntityFrameworkCore;

namespace AgenciaViajamar.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) {
        }

        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Atendimento> atendimento { get; set; }
        public DbSet<Compras> compras { get; set; }
        public DbSet<Destinos> destinos { get; set; }
    }
}
