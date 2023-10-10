using gerenciadorTarefas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gerenciadorTarefas.Data.Map
{
    public class TarefaMap : IEntityTypeConfiguration<TarefaModel>
    {
        public void Configure(EntityTypeBuilder<TarefaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Titulo).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(2000);
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.UsuarioID);

            builder.HasOne(x => x.Usuario);
        }
    }
}
