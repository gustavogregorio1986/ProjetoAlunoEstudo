using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoAluno.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAluno.Data.Mapping
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("tb_Aluno");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.NomeAluno)
                .IsRequired()
                .HasColumnType("VARCHAR(50)");

            builder.Property(x => x.Nota1)
                .IsRequired()
                .HasColumnType("DOUBLE(11,2)");

            builder.Property(x => x.Nota2)
                .IsRequired()
                .HasColumnType("DOUBLE(11,2)");

            builder.Property(x => x.TotalNota)
                .IsRequired()
                .HasColumnType("DOUBLE(11,2)");

            builder.Property(x => x.DataInicio)
               .IsRequired()
               .HasColumnType("DATETIME");

            builder.Property(x => x.DataTermino)
               .IsRequired()
               .HasColumnType("DATETIME");

            builder.Property(x => x.Escolareidade)
               .IsRequired()
               .HasColumnType("VARCHAR(70)");
        }
    }
}
