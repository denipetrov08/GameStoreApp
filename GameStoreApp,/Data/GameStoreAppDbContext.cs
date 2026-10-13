using GameStoreApp_.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStoreApp_.Data
{
    public class GameStoreAppDbContext : DbContext
    {
        public GameStoreAppDbContext(
            DbContextOptions<GameStoreAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Developer> Developers { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Card> Cards { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

        public DbSet<GameTag> GameTags { get; set; }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        
            modelBuilder.Entity<GameTag>()
                .HasKey(gt => new { gt.GameId, gt.TagId });

                      

            modelBuilder.Entity<Game>()
                .Property(g => g.Price)
                .HasPrecision(18, 2);

                      

            modelBuilder.Entity<Game>()
                .Property(g => g.ReleaseDate)
                .HasColumnType("date");

            modelBuilder.Entity<Purchase>()
                .Property(p => p.Date)
                .HasColumnType("date");

                      

            modelBuilder.Entity<Game>()
                .HasOne(g => g.Developer)
                .WithMany(d => d.Games)
                .HasForeignKey(g => g.DeveloperId)
                .OnDelete(DeleteBehavior.Restrict);

                      

            modelBuilder.Entity<Game>()
                .HasOne(g => g.Genre)
                .WithMany(ge => ge.Games)
                .HasForeignKey(g => g.GenreId)
                .OnDelete(DeleteBehavior.Restrict);

                     

            modelBuilder.Entity<Card>()
                .HasOne(c => c.User)
                .WithMany(u => u.Cards)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);

          

            modelBuilder.Entity<Purchase>()
                .HasOne(p => p.Card)
                .WithMany(c => c.Purchases)
                .HasForeignKey(p => p.CardId)
                .OnDelete(DeleteBehavior.Restrict);


          
            modelBuilder.Entity<Purchase>()
                .HasOne(p => p.Game)
                .WithMany(g => g.Purchases)
                .HasForeignKey(p => p.GameId)
                .OnDelete(DeleteBehavior.Restrict);


           
            modelBuilder.Entity<GameTag>()
                .HasOne(gt => gt.Game)
                .WithMany(g => g.GameTags)
                .HasForeignKey(gt => gt.GameId)
                .OnDelete(DeleteBehavior.Restrict);

               

            modelBuilder.Entity<GameTag>()
                .HasOne(gt => gt.Tag)
                .WithMany(t => t.GameTags)
                .HasForeignKey(gt => gt.TagId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
