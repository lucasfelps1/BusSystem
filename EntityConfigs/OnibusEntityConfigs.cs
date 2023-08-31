using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using BusSystemConsole.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusSystemConsole.EntityConfigs
{
    public class OnibusEntityConfigs : IEntityTypeConfiguration<Onibus>
    {
        public void Configure(EntityTypeBuilder<Onibus> builder)
        {
            builder.ToTable("onibus");

            builder
                .Property(x => x.Id)
                .HasColumnName("id");

            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Placa)
                .HasColumnName("placa")
                .HasColumnType("varchar(7)")
                .IsRequired();

            builder
                .Property(x => x.Motorista)
                .HasColumnName("motorista")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(o => o.EntradaTerminal)
                .HasColumnName("entrada")
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.Property(o => o.SaidaTerminal)
                .HasColumnName("saida")
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.HasOne(o => o.Terminal)
            .WithMany(t => t.Onibus)
            .HasForeignKey(o => o.TerminalId)
            .OnDelete(DeleteBehavior.Restrict);

        }
    }
}