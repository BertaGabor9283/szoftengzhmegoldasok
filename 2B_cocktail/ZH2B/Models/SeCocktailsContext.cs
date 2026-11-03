using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ZH2B.Models;

public partial class SeCocktailsContext : DbContext
{
    public SeCocktailsContext()
    {
    }

    public SeCocktailsContext(DbContextOptions<SeCocktailsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cocktail> Cocktails { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<MaterialType> MaterialTypes { get; set; }

    public virtual DbSet<Recipe> Recipes { get; set; }

    public virtual DbSet<Type> Types { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=bit.uni-corvinus.hu;Initial Catalog=se_cocktails;User ID=hallgato;Password=Password123;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cocktail>(entity =>
        {
            entity.HasKey(e => e.CocktailSk);

            entity.ToTable("Cocktail");

            entity.Property(e => e.CocktailSk).HasColumnName("CocktailSK");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.TypeFk).HasColumnName("TypeFK");

            entity.HasOne(d => d.TypeFkNavigation).WithMany(p => p.Cocktails)
                .HasForeignKey(d => d.TypeFk);
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.MaterialId);

            entity.ToTable("Material");

            entity.Property(e => e.MaterialId).HasColumnName("MaterialID");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.TypeFk).HasColumnName("TypeFK");
            entity.Property(e => e.UnitFk).HasColumnName("UnitFK");

            entity.HasOne(d => d.TypeFkNavigation).WithMany(p => p.Materials)
                .HasForeignKey(d => d.TypeFk);

            entity.HasOne(d => d.UnitFkNavigation).WithMany(p => p.Materials)
                .HasForeignKey(d => d.UnitFk);
        });

        modelBuilder.Entity<MaterialType>(entity =>
        {
            entity.HasKey(e => e.MaterialTypeId);

            entity.ToTable("MaterialType");

            entity.Property(e => e.MaterialTypeId).HasColumnName("MaterialTypeID");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.HasKey(e => e.RecipeSk);

            entity.ToTable("Recipe");

            entity.Property(e => e.RecipeSk).HasColumnName("RecipeSK");
            entity.Property(e => e.CocktailFk).HasColumnName("CocktailFK");
            entity.Property(e => e.MaterialFk).HasColumnName("MaterialFK");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.CocktailFkNavigation).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.CocktailFk);

            entity.HasOne(d => d.MaterialFkNavigation).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.MaterialFk);
        });

        modelBuilder.Entity<Type>(entity =>
        {
            entity.HasKey(e => e.TypeId);

            entity.ToTable("Type");

            entity.Property(e => e.TypeId).HasColumnName("TypeID");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.HasKey(e => e.UnitId);

            entity.ToTable("Unit");

            entity.Property(e => e.UnitId).HasColumnName("UnitID");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
