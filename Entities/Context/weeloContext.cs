using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Entities.Context
{
    public partial class weeloContext : DbContext
    {
        public weeloContext()
        {
        }

        public weeloContext(DbContextOptions<weeloContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        public IConfiguration _configuration;

        public virtual DbSet<Owner> Owner { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<PropertyImage> PropertyImage { get; set; }
        public virtual DbSet<PropertyTrace> PropertyTrace { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            { 
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DataMasters"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>(entity =>
            {
                entity.HasKey(e => e.IdOwner)
                    .HasName("PK__owner__D3261816FBBD24EA");

                entity.ToTable("owner");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.HasKey(e => e.IdProperty)
                    .HasName("PK__property__842B6AA7451717C0");

                entity.ToTable("property");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodeInternal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdOwnerNavigation)
                    .WithMany(p => p.Property)
                    .HasForeignKey(d => d.IdOwner)
                    .HasConstraintName("FK__property__IdOwne__4BAC3F29");
            });

            modelBuilder.Entity<PropertyImage>(entity =>
            {
                entity.HasKey(e => e.IdPropertyImage)
                    .HasName("PK__property__018BACD530739184");

                entity.ToTable("propertyImage");

                entity.Property(e => e.File)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPropertyNavigation)
                    .WithMany(p => p.PropertyImage)
                    .HasForeignKey(d => d.IdProperty)
                    .HasConstraintName("FK__propertyI__IdPro__5441852A");
            });

            modelBuilder.Entity<PropertyTrace>(entity =>
            {
                entity.HasKey(e => e.IdPropertyTrace)
                    .HasName("PK__Property__373407C9BACC7367");

                entity.Property(e => e.DateSale)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPropertyNavigation)
                    .WithMany(p => p.PropertyTrace)
                    .HasForeignKey(d => d.IdProperty)
                    .HasConstraintName("FK__PropertyT__IdPro__5165187F");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
