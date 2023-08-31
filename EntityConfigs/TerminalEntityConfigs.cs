using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusSystemConsole.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusSystemConsole.EntityConfigs
{
    public class TerminalEntityConfigs : IEntityTypeConfiguration<Terminal>
    {
        public void Configure(EntityTypeBuilder<Terminal> builder)
        {   
            builder.ToTable("Terminal");

            builder
                .Property(x => x.Id)
                .HasColumnName("id");

            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Nome)
                .HasColumnName("nome")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder
                .Property(x => x.Vagas)
                .HasColumnName("vagas")
                .HasColumnType("INT")
                .IsRequired();

        }
    }
}