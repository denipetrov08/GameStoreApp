using System.ComponentModel.DataAnnotations;

namespace GameStoreApp_.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }

        public string? Type { get; set; }

        public string? ProductKey { get; set; }

        public DateTime? Date { get; set; }

        [Required]
        public int CardId { get; set; }

        public Card Card { get; set; } = null!;

        [Required]
        public int GameId { get; set; }

        public Game Game { get; set; } = null!;
    }
}
