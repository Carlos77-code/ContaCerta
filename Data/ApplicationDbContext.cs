using ContaCerta.Models;
using Microsoft.EntityFrameworkCore;

namespace ContaCerta.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<DespesasModel> Despesas { get; set; }
    }
}
