using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NewbiezApp.Classes
{
    public partial class databaseContext : DbContext
    {
        public databaseContext()
        {
        }

        public databaseContext(DbContextOptions<databaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alue> Alues { get; set; } = null!;
        public virtual DbSet<Asiakas> Asiakaat { get; set; } = null!;
        public virtual DbSet<Lasku> Laskus { get; set; } = null!;
        public virtual DbSet<Mokki> Mokkis { get; set; } = null!;
        public virtual DbSet<Palvelu> Palvelus { get; set; } = null!;
        public virtual DbSet<Posti> Postis { get; set; } = null!;
        public virtual DbSet<Varaus> Varaus { get; set; } = null!;
        public virtual DbSet<VarauksenPalvelut> VarauksenPalveluts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("DataSource=database.db ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alue>(entity =>
            {
                entity.ToTable("alue");

                entity.HasIndex(e => e.Nimi, "alue_nimi_index");

                entity.Property(e => e.AlueId).HasColumnName("alue_id");

                entity.Property(e => e.Nimi)
                    .HasColumnType("VARCHAR(40)")
                    .HasColumnName("nimi");
            });

            modelBuilder.Entity<Asiakas>(entity =>
            {
                entity.HasKey(e => e.AsiakasId);

                entity.ToTable("asiakas");

                entity.HasIndex(e => e.Etunimi, "asiakas_enimi_idx");

                entity.HasIndex(e => e.Sukunimi, "asiakas_snimi_idx");

                entity.HasIndex(e => e.Postinro, "fk_as_posti1_idx");

                entity.Property(e => e.AsiakasId).HasColumnName("asiakas_id");

                entity.Property(e => e.Email)
                    .HasColumnType("VARCHAR(50)")
                    .HasColumnName("email");

                entity.Property(e => e.Etunimi)
                    .HasColumnType("VARCHAR(20)")
                    .HasColumnName("etunimi");

                entity.Property(e => e.Lahiosoite)
                    .HasColumnType("VARCHAR(40)")
                    .HasColumnName("lahiosoite");

                entity.Property(e => e.Postinro)
                    .HasColumnType("CHAR(5)")
                    .HasColumnName("postinro");

                entity.Property(e => e.Puhelinnro)
                    .HasColumnType("VARCHAR(15)")
                    .HasColumnName("puhelinnro");

                entity.Property(e => e.Sukunimi)
                    .HasColumnType("VARCHAR(40)")
                    .HasColumnName("sukunimi");

                entity.HasOne(d => d.PostinroNavigation)
                    .WithMany(p => p.Asiakas)
                    .HasForeignKey(d => d.Postinro)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Lasku>(entity =>
            {
                entity.HasKey(e => e.LaskuId);

                entity.ToTable("lasku");

                entity.Property(e => e.LaskuId).HasColumnName("lasku_id");
                    //.HasColumnType("INT (11)")
                    //.ValueGeneratedNever()
                    //.HasColumnName("lasku_id");

                entity.Property(e => e.Alv)
                    .HasColumnType("DOUBLE (8, 2)")
                    .HasColumnName("alv");

                entity.Property(e => e.Summa)
                    .HasColumnType("DOUBLE (8, 2)")
                    .HasColumnName("summa");

                entity.Property(e => e.Tila)
                .HasColumnType("VARCHAR(20)")
                .HasColumnName("tila");

                entity.Property(e => e.VarausId)
                    .HasColumnType("INT")
                    .HasColumnName("varaus_id");

                entity.HasOne(d => d.Varaus)
                    .WithMany(p => p.Laskus)
                    .HasForeignKey(d => d.VarausId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Mokki>(entity =>
            {
                entity.ToTable("mokki");

                entity.HasIndex(e => e.AlueId, "fk_mokki_alue_idx");

                entity.HasIndex(e => e.Postinro, "fk_mokki_posti_idx");

                entity.Property(e => e.MokkiId).HasColumnName("mokki_id");

                entity.Property(e => e.AlueId)
                    .HasColumnType("INT(11)")
                    .HasColumnName("alue_id");

                entity.Property(e => e.Henkilomaara)
                    .HasColumnType("INT")
                    .HasColumnName("henkilomaara");

                entity.Property(e => e.Hinta)
                    .HasColumnType("DOUBLE(8, 2)")
                    .HasColumnName("hinta");

                entity.Property(e => e.Katuosoite)
                    .HasColumnType("VARCHAR(45)")
                    .HasColumnName("katuosoite");

                entity.Property(e => e.Kuvaus)
                    .HasColumnType("VARCHAR(150)")
                    .HasColumnName("kuvaus");

                entity.Property(e => e.Mokkinimi)
                    .HasColumnType("VARCHAR(45)")
                    .HasColumnName("mokkinimi");

                entity.Property(e => e.Postinro)
                    .HasColumnType("CHAR(5)")
                    .HasColumnName("postinro");

                entity.Property(e => e.Varustelu)
                    .HasColumnType("VARCHAR(100)")
                    .HasColumnName("varustelu");

                entity.HasOne(d => d.Alue)
                    .WithMany(p => p.Mokkis)
                    .HasForeignKey(d => d.AlueId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PostinroNavigation)
                    .WithMany(p => p.Mokkis)
                    .HasForeignKey(d => d.Postinro)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Palvelu>(entity =>
            {
                entity.HasKey(e => e.PalveluId);

                entity.ToTable("palvelu");

                entity.HasIndex(e => e.Nimi, "Palvelu_nimi_index");

                entity.HasIndex(e => e.AlueId, "palv_toimip_id_ind");

                entity.Property(e => e.PalveluId).HasColumnName("palvelu_id");
                    //.HasColumnType("INT (11)")
                    //.ValueGeneratedNever()
                    //.HasColumnName("palvelu_id");

                entity.Property(e => e.AlueId)
                    .HasColumnType("INT (11)")
                    .HasColumnName("alue_id");

                entity.Property(e => e.Alv)
                    .HasColumnType("DOUBLE (8, 2)")
                    .HasColumnName("alv");

                entity.Property(e => e.Hinta)
                    .HasColumnType("DOUBLE (8, 2)")
                    .HasColumnName("hinta");

                entity.Property(e => e.Kuvaus)
                    .HasColumnType("VARCHAR (255)")
                    .HasColumnName("kuvaus");

                entity.Property(e => e.Nimi)
                    .HasColumnType("VARCHAR (40)")
                    .HasColumnName("nimi");

                entity.Property(e => e.Tyyppi)
                    .HasColumnType("INT (11)")
                    .HasColumnName("tyyppi");

                entity.HasOne(d => d.Alue)
                    .WithMany(p => p.Palvelus)
                    .HasForeignKey(d => d.AlueId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Posti>(entity =>
            {
                entity.HasKey(e => e.Postinro);

                entity.ToTable("posti");

                entity.Property(e => e.Postinro)
                    .HasColumnType("CHAR (5)")
                    .HasColumnName("postinro");

                entity.Property(e => e.Toimipaikka)
                    .HasColumnType("VARCHAR (45)")
                    .HasColumnName("toimipaikka");
            });

            modelBuilder.Entity<Varaus>(entity =>
            {
                entity.HasKey(e => e.VarausId);

                entity.ToTable("varaus");

                entity.HasIndex(e => e.MokkiMokkiId, "fk_var_mok_idx");

                entity.HasIndex(e => e.AsiakasId, "varaus_as_id_index");

                entity.Property(e => e.VarausId).HasColumnName("varaus_id");
                    //.HasColumnType("INT (11)")
                    //.ValueGeneratedNever();
                    //.HasColumnName("varaus_id");

                entity.Property(e => e.AsiakasId)
                    .HasColumnType("INT (11)")
                    .HasColumnName("asiakas_id");

                entity.Property(e => e.MokkiMokkiId)
                    .HasColumnType("INT")
                    .HasColumnName("mokki_mokki_id");

                entity.Property(e => e.VahvistusPvm)
                    .HasColumnType("DATETIME")
                    .HasColumnName("vahvistus_pvm");

                entity.Property(e => e.VarattuAlkupvm)
                    .HasColumnType("DATETIME")
                    .HasColumnName("varattu_alkupvm");

                entity.Property(e => e.VarattuLoppupvm)
                    .HasColumnType("DATETIME")
                    .HasColumnName("varattu_loppupvm");

                entity.Property(e => e.VarattuPvm)
                    .HasColumnType("DATETIME")
                    .HasColumnName("varattu_pvm");

                entity.HasOne(d => d.Asiakas)
                    .WithMany(p => p.Varaus)
                    .HasForeignKey(d => d.AsiakasId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.MokkiMokki)
                    .WithMany(p => p.Varaus)
                    .HasForeignKey(d => d.MokkiMokkiId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<VarauksenPalvelut>(entity =>
            {
                entity.HasKey(e => new { e.PalveluId, e.VarausId });

                entity.ToTable("varauksen_palvelut");

                entity.HasIndex(e => e.PalveluId, "vp_palvelu_id_index");

                entity.HasIndex(e => e.VarausId, "vp_varaus_id_index");

                entity.Property(e => e.PalveluId)
                    .HasColumnType("INT (11)")
                    .HasColumnName("palvelu_id");

                entity.Property(e => e.VarausId)
                    .HasColumnType("INT (11)")
                    .HasColumnName("varaus_id");

                entity.Property(e => e.Lkm)
                    .HasColumnType("INT (11)")
                    .HasColumnName("lkm");

                entity.HasOne(d => d.Palvelu)
                    .WithMany(p => p.VarauksenPalveluts)
                    .HasForeignKey(d => d.PalveluId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Varaus)
                    .WithMany(p => p.VarauksenPalveluts)
                    .HasForeignKey(d => d.VarausId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
