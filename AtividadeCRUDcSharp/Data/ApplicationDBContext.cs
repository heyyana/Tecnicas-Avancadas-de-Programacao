using Microsoft.EntityFrameworkCore;
using Locadora.Models;

namespace Locadora.Data
{
    public class ApplicationDBContext : DbContext
    {
            public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
            {

            }
            public DbSet<AluguelFilmeModel> Aluguel { get; set; }
        
    }
}
