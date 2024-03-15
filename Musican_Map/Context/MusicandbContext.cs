using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Musican_Map.Entites;

namespace Musican_Map.Context
{
    public class MusicandbContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =ELNAHAS\\SQLEXPRESS; database=MusicanDB; trusted_connection=true;");
        }

        public DbSet<Musican>  musicans { get; set; }
        public DbSet<Instrument>  instruments { get; set; }
        public DbSet<Album>  albums { get; set; }
        public DbSet<Song>  songs { get; set; }

        public DbSet<Album_Song> album_Songs { get; set; }


        public DbSet<Music_Song>  Music_Songs { get; set; }

        public DbSet<Music_Instrument>  music_Instruments { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album_Song>()
                 .HasKey(x => new { x.AlbumId, x.SongTitle });


            modelBuilder.Entity<Music_Song>()
               .HasKey(x => new { x.MusicanId, x.SongTitle });


            modelBuilder.Entity<Music_Instrument>()
               .HasKey(x => new { x.MusicanId, x.InstrumentName });
        }

    }
}
