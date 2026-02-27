using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escola.domain.Entities;


namespace Escola.Infra.Data.EntitiesConfiguration
{
    public class MatriculaConfiguration : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(EntityTypeBuilder<Matricula> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.UsuarioId)
                .IsRequired();
            builder.Property(m => m.TurmaId)
                .IsRequired();
            builder.HasOne(x => x.Usuario).
                .WithMany(x => x.Matriculas)
                .HasForeignKey(x => x.UsuarioId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Turma)
                .withMany(x => x.Matriculas)
                .HasForeignKey(x => x.TurmaId)
                .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
