using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ZH4B.Models;

public partial class SeSzallashelyContext : DbContext
{
    public SeSzallashelyContext()
    {
    }

    public SeSzallashelyContext(DbContextOptions<SeSzallashelyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Foglalas> Foglalas { get; set; }

    public virtual DbSet<Szallashely> Szallashely { get; set; }

    public virtual DbSet<Szoba> Szoba { get; set; }

    public virtual DbSet<Vendeg> Vendeg { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=bit.uni-corvinus.hu;Initial Catalog=se_szallashely;User ID=hallgato;Password=Password123;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Foglalas>(entity =>
        {
            entity.HasKey(e => e.FoglalasPk);

            entity.ToTable("Foglalas");

            entity.Property(e => e.FoglalasPk).HasColumnName("FOGLALAS_PK");
            entity.Property(e => e.FelnottSzam).HasColumnName("FELNOTT_SZAM");
            entity.Property(e => e.GyermekSzam).HasColumnName("GYERMEK_SZAM");
            entity.Property(e => e.Meddig).HasColumnName("MEDDIG");
            entity.Property(e => e.Mettol).HasColumnName("METTOL");
            entity.Property(e => e.SzobaFk).HasColumnName("SZOBA_FK");
            entity.Property(e => e.UgyfelFk)
                .HasMaxLength(100)
                .HasColumnName("UGYFEL_FK");

            entity.HasOne(d => d.SzobaFkNavigation).WithMany(p => p.Foglalas)
                .HasForeignKey(d => d.SzobaFk);

            entity.HasOne(d => d.UgyfelFkNavigation).WithMany(p => p.Foglalas)
                .HasForeignKey(d => d.UgyfelFk);
        });

        modelBuilder.Entity<Szallashely>(entity =>
        {
            entity.HasKey(e => e.SzallasId);

            entity.ToTable("Szallashely");

            entity.Property(e => e.SzallasId).HasColumnName("SZALLAS_ID");
            entity.Property(e => e.Cim)
                .HasMaxLength(100)
                .HasColumnName("CIM");
            entity.Property(e => e.CsillagokSzama).HasColumnName("CSILLAGOK_SZAMA");
            entity.Property(e => e.Hely)
                .HasMaxLength(100)
                .HasColumnName("HELY");
            entity.Property(e => e.RogzIdo)
                .HasColumnType("datetime")
                .HasColumnName("ROGZ_IDO");
            entity.Property(e => e.Rogzitette)
                .HasMaxLength(100)
                .HasColumnName("ROGZITETTE");
            entity.Property(e => e.SzallasNev)
                .HasMaxLength(100)
                .HasColumnName("SZALLAS_NEV");
            entity.Property(e => e.Tipus)
                .HasMaxLength(100)
                .HasColumnName("TIPUS");
        });

        modelBuilder.Entity<Szoba>(entity =>
        {
            entity.HasKey(e => e.SzobaId);

            entity.ToTable("Szoba");

            entity.Property(e => e.SzobaId).HasColumnName("SZOBA_ID");
            entity.Property(e => e.Ferohely).HasColumnName("FEROHELY");
            entity.Property(e => e.Klimas)
                .HasMaxLength(10)
                .HasColumnName("KLIMAS");
            entity.Property(e => e.Potagy).HasColumnName("POTAGY");
            entity.Property(e => e.SzallasFk).HasColumnName("SZALLAS_FK");
            entity.Property(e => e.SzobaSzama)
                .HasMaxLength(10)
                .HasColumnName("SZOBA_SZAMA");

            entity.HasOne(d => d.SzallasFkNavigation).WithMany(p => p.Szoba)
                .HasForeignKey(d => d.SzallasFk);
        });

        modelBuilder.Entity<Vendeg>(entity =>
        {
            entity.HasKey(e => e.Usernev);

            entity.ToTable("Vendeg");

            entity.Property(e => e.Usernev)
                .HasMaxLength(100)
                .HasColumnName("USERNEV");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Nev)
                .HasMaxLength(100)
                .HasColumnName("NEV");
            entity.Property(e => e.SzamlCim)
                .HasMaxLength(100)
                .HasColumnName("SZAML_CIM");
            entity.Property(e => e.SzulDat).HasColumnName("SZUL_DAT");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
