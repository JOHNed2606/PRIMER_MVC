using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PRIMER_MVC.Models;

public partial class EnsayoContext : DbContext
{
    public EnsayoContext()
    {
    }

    public EnsayoContext(DbContextOptions<EnsayoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Restaurante> Restaurantes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Restaurante>(entity =>
        {
            entity.HasKey(e => e.IdRestaurante).HasName("PK__Restaura__29CE64FA8BC082AF");

            entity.ToTable("Restaurante");

            entity.Property(e => e.Ciudad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TipoCocina)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
