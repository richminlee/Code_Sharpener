using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CodeSharpener.Models
{
    public partial class CodeSharpenerContext : DbContext
    {
        public CodeSharpenerContext()
        {
        }

        public CodeSharpenerContext(DbContextOptions<CodeSharpenerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Challenge> Challenge { get; set; }
        public virtual DbSet<Content> Content { get; set; }
        public virtual DbSet<Solution> Solution { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-BA11OFN9;Database=CodeSharpener;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Challenge>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(400);

                entity.Property(e => e.Title).HasMaxLength(40);

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.Challenge)
                    .HasForeignKey(d => d.ContentId)
                    .HasConstraintName("FK__Challenge__Conte__4F7CD00D");
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.Property(e => e.ConceptLink).HasMaxLength(120);

                entity.Property(e => e.Description).HasMaxLength(400);

                entity.Property(e => e.Title).HasMaxLength(40);

                entity.Property(e => e.WalkthruLink).HasMaxLength(120);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Content)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Content__UserId__4CA06362");
            });

            modelBuilder.Entity<Solution>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(400);

                entity.Property(e => e.Title).HasMaxLength(40);

                entity.HasOne(d => d.Challenge)
                    .WithMany(p => p.Solution)
                    .HasForeignKey(d => d.ChallengeId)
                    .HasConstraintName("FK__Solution__Challe__5629CD9C");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Solution)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Solution__UserId__571DF1D5");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(80);

                entity.Property(e => e.FirstName).HasMaxLength(40);

                entity.Property(e => e.LastName).HasMaxLength(40);

                entity.Property(e => e.MiddleName).HasMaxLength(40);

                entity.Property(e => e.Password).HasMaxLength(40);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
