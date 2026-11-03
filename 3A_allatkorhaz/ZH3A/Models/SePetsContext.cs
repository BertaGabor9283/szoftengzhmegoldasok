using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ZH3A.Models;

public partial class SePetsContext : DbContext
{
    public SePetsContext()
    {
    }

    public SePetsContext(DbContextOptions<SePetsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Animal> Animals { get; set; }

    public virtual DbSet<Locality> Localities { get; set; }

    public virtual DbSet<Owner> Owners { get; set; }

    public virtual DbSet<Procedure> Procedures { get; set; }

    public virtual DbSet<ProcedureDone> ProcedureDones { get; set; }

    public virtual DbSet<Species> Species { get; set; }

    public virtual DbSet<Treatment> Treatments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=bit.uni-corvinus.hu;Initial Catalog=se_pets;User ID=hallgato;Password=Password123;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Animal>(entity =>
        {
            entity.HasKey(e => e.AnimalSk);

            entity.ToTable("Animal");

            entity.Property(e => e.AnimalSk).HasColumnName("AnimalSK");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.OwnerFk).HasColumnName("OwnerFK");
            entity.Property(e => e.SpeciesFk).HasColumnName("SpeciesFK");

            entity.HasOne(d => d.OwnerFkNavigation).WithMany(p => p.Animals)
                .HasForeignKey(d => d.OwnerFk);

            entity.HasOne(d => d.SpeciesFkNavigation).WithMany(p => p.Animals)
                .HasForeignKey(d => d.SpeciesFk);
        });

        modelBuilder.Entity<Locality>(entity =>
        {
            entity.HasKey(e => e.LocalitySk);

            entity.ToTable("Locality");

            entity.Property(e => e.LocalitySk).HasColumnName("LocalitySK");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.HasKey(e => e.OwnerSk);

            entity.ToTable("Owner");

            entity.Property(e => e.OwnerSk).HasColumnName("OwnerSK");
            entity.Property(e => e.LocalityFk).HasColumnName("LocalityFK");
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.LocalityFkNavigation).WithMany(p => p.Owners)
                .HasForeignKey(d => d.LocalityFk);
        });

        modelBuilder.Entity<Procedure>(entity =>
        {
            entity.HasKey(e => e.ProcedureSk);

            entity.ToTable("Procedure");

            entity.Property(e => e.ProcedureSk).HasColumnName("ProcedureSK");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.Unit).HasMaxLength(50);
        });

        modelBuilder.Entity<ProcedureDone>(entity =>
        {
            entity.HasKey(e => e.ProcedureDoneSk);

            entity.ToTable("ProcedureDone");

            entity.Property(e => e.ProcedureDoneSk).HasColumnName("ProcedureDoneSK");
            entity.Property(e => e.ProcedureFk).HasColumnName("ProcedureFK");
            entity.Property(e => e.TreatmentFk).HasColumnName("TreatmentFK");

            entity.HasOne(d => d.ProcedureFkNavigation).WithMany(p => p.ProcedureDones)
                .HasForeignKey(d => d.ProcedureFk);

            entity.HasOne(d => d.TreatmentFkNavigation).WithMany(p => p.ProcedureDones)
                .HasForeignKey(d => d.TreatmentFk);
        });

        modelBuilder.Entity<Species>(entity =>
        {
            entity.HasKey(e => e.SpeciesSk);

            entity.ToTable("Species");

            entity.Property(e => e.SpeciesSk).HasColumnName("SpeciesSK");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Treatment>(entity =>
        {
            entity.HasKey(e => e.TreatmentSk);

            entity.ToTable("Treatment");

            entity.Property(e => e.TreatmentSk).HasColumnName("TreatmentSK");
            entity.Property(e => e.AnimalFk).HasColumnName("AnimalFK");

            entity.HasOne(d => d.AnimalFkNavigation).WithMany(p => p.Treatments)
                .HasForeignKey(d => d.AnimalFk);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
