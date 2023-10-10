using gerenciadorTarefas.Data.Map;
using gerenciadorTarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace gerenciadorTarefas.Data
{
    public class TarefasDBContext : DbContext
    {
        public TarefasDBContext(DbContextOptions<TarefasDBContext> options) : base(options) 
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
