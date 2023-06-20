using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PjTiendaVideojuego.Models;

public partial class PjTiendaVideojuegoContext : DbContext
{
    public PjTiendaVideojuegoContext()
    {
    }

    public PjTiendaVideojuegoContext(DbContextOptions<PjTiendaVideojuegoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:Conexion");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Cliente");

            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.FechaNac)
                .HasColumnType("date")
                .HasColumnName("fechaNac");
            entity.Property(e => e.IdCliente)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Cliente");
            entity.Property(e => e.Nombres)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DetalleFactura>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Detalle_factura");

            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("cantidad");
            entity.Property(e => e.IdCliente)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Cliente");
            entity.Property(e => e.IdDetalleFactura)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_DetalleFactura|");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Producto");
            entity.Property(e => e.PrecioUnit).HasColumnName("precio_unit");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Producto");

            entity.Property(e => e.DescripcionProd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripcion_prod");
            entity.Property(e => e.IdProducto)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Id_Producto");
            entity.Property(e => e.NombreProd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_prod");
            entity.Property(e => e.PrecioProduc).HasColumnName("precio_produc");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
