using BA.PlakDukkani.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.PlakDukkani.DAL.Context
{
    public class PlakDbContext:DbContext
    {
        public DbSet<Yonetici>  Yoneticiler { get; set; }
        public DbSet<Album>  Albumler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=OZAN\SQLEXPRESS;Initial Catalog=PlakDukkaniDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //-----------------------YoneticiOzNitelikleri------------------------------------
           
            
            modelBuilder.Entity<Yonetici>()
                .HasKey(y => y.Id);
            
            modelBuilder.Entity<Yonetici>()
                .HasIndex(y => y.KullaniciAdi)
                .IsUnique();

            modelBuilder.Entity<Yonetici>()
                .HasMany(y => y.Albumler)
                .WithOne(y => y.Yonetici)
                .HasForeignKey(y => y.YoneticiId);
           
           //----------------------------AlbumOzNiteklikleri-------------------------
            
            
            modelBuilder.Entity<Album>()
                .HasKey(a => a.Id);
           
            modelBuilder.Entity<Album>()
                .Property(a=>a.İndirimOrani)
                .IsRequired(false);
          
        }
    }
}
