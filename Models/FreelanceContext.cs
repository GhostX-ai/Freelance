using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FreelanceV2.Models
{
    public partial class FreelanceContext : DbContext
    {
        public FreelanceContext()
        {
        }

        public FreelanceContext(DbContextOptions<FreelanceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<Announcemants> Announcemants { get; set; }
        public virtual DbSet<Binds> Binds { get; set; }
        public virtual DbSet<Genders> Genders { get; set; }
        public virtual DbSet<Rangs> Rangs { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<WagesType> WagesType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Freelance;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accounts>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.RagisterDate).HasColumnType("date");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Accounts_Genders");

                entity.HasOne(d => d.Rang)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Accounts_Accounts");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Accounts_Roles");
            });

            modelBuilder.Entity<Announcemants>(entity =>
            {
                entity.Property(e => e.FullDescription).IsRequired();

                entity.Property(e => e.PublicDate).HasColumnType("date");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Announcemants)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Announcemants_Accounts");

                entity.HasOne(d => d.WageType)
                    .WithMany(p => p.Announcemants)
                    .HasForeignKey(d => d.WageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Announcemants_WagesType");
            });

            modelBuilder.Entity<Binds>(entity =>
            {
                entity.Property(e => e.BindText)
                    .IsRequired()
                    .HasColumnName("bind_text")
                    .HasMaxLength(1000);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Announcemant)
                    .WithMany(p => p.Binds)
                    .HasForeignKey(d => d.AnnouncemantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Binds_Announcemants");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Binds)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Binds_Accounts");
            });

            modelBuilder.Entity<Genders>(entity =>
            {
                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Rangs>(entity =>
            {
                entity.Property(e => e.Rang)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WagesType>(entity =>
            {
                entity.Property(e => e.WageType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
