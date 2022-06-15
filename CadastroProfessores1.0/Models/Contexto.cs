using Microsoft.EntityFrameworkCore;

namespace CadastroProfessores1._0.Models
{
    public class Contexto :DbContext
    {
        public DbSet<Professor>Professores{ get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes): base(opcoes)
        {
            
        }
    }
}
