using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreAuthentication.EntityModels
{
    public partial class aspnetWebApplication9576319532204474D8C2D4A11DD127D27 : DbContext
    {
        public aspnetWebApplication9576319532204474D8C2D4A11DD127D27()
        {
        }

        public aspnetWebApplication9576319532204474D8C2D4A11DD127D27(DbContextOptions<aspnetWebApplication9576319532204474D8C2D4A11DD127D27> options)
            : base(options)
        {
        }

        public virtual DbSet<Teacher> Teacher { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=PHANI\\SQLEXPRESS;Database=aspnet-WebApplication9-57631953-2204-474D-8C2D-4A11DD127D27;user Id=vista;Password=star;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });
        }
    }
}
