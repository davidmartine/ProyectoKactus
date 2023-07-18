using System;
using System.Collections.Generic;
using BCModels.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace BCDatos.DataContext
{
    public partial class KACTUSContext : DbContext
    {
        public KACTUSContext()
        {

        }

        public KACTUSContext(DbContextOptions<KACTUSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CabezaFactura> CabezaFacturas { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CabezaFactura>(entity =>
            {
                entity.HasKey(e => e.IdnumeroFac)
                    .HasName("PK__CABEZA_F__A25D8F596D29CC8A");

                entity.ToTable("CABEZA_FACTURA");

                entity.Property(e => e.IdnumeroFac).HasColumnName("IDNumeroFac");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Idcliente).HasColumnName("IDCliente");

                entity.Property(e => e.Total)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("TOTAL");

                entity.HasOne(d => d.IdclienteNavigation)
                    .WithMany(p => p.CabezaFacturas)
                    .HasForeignKey(d => d.Idcliente)
                    .HasConstraintName("FK_CABEZA_FACTURA_CLIENTES");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Idcliente)
                    .HasName("PK__CLIENTES__9B8553FC7A67928C");

                entity.ToTable("CLIENTES");

                entity.Property(e => e.Idcliente).HasColumnName("IDCliente");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");
            });

            modelBuilder.Entity<DetalleFactura>(entity =>
            {
                entity.HasKey(e => e.IddetalleFactura)
                    .HasName("PK__DETALLE___EF0E5D9AB84CBCB0");

                entity.ToTable("DETALLE_FACTURA");

                entity.Property(e => e.IddetalleFactura).HasColumnName("IDDetalleFactura");

                entity.Property(e => e.IdnumeroFac).HasColumnName("IDNumeroFac");

                entity.Property(e => e.Idproducto).HasColumnName("IDProducto");

                entity.Property(e => e.Valor).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.IdnumeroFacNavigation)
                    .WithMany(p => p.DetalleFacturas)
                    .HasForeignKey(d => d.IdnumeroFac)
                    .HasConstraintName("FK_DETALLE_FACTURA_CABEZA_FACTURA");

                entity.HasOne(d => d.IdproductoNavigation)
                    .WithMany(p => p.DetalleFacturas)
                    .HasForeignKey(d => d.Idproducto)
                    .HasConstraintName("FK_DETALLE_FACTURA_PRODUCTO");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Idproducto)
                    .HasName("PK__PRODUCTO__ABDAF2B40A23A57A");

                entity.ToTable("PRODUCTO");

                entity.Property(e => e.Idproducto).HasColumnName("IDProducto");

                entity.Property(e => e.NombreProducto)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Producto");

                entity.Property(e => e.Valor).HasColumnType("numeric(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
