using AgendamentoConsultas.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace AgendamentoConsultas.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Consulta> Consultas { get; set; }
    }
}
