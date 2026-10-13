using System.ComponentModel.DataAnnotations;

namespace GameStoreApp_.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public decimal? Price { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public int DeveloperId { get; set; }

        public Developer Developer { get; set; } = null!;

        [Required]
        public int GenreId { get; set; }

        public Genre Genre { get; set; } = null!;

        public ICollection<GameTag> GameTags { get; set; }
            = new List<GameTag>();

        public ICollection<Purchase> Purchases { get; set; }
            = new List<Purchase>();
    }
}
