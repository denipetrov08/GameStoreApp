using System.ComponentModel.DataAnnotations;

namespace GameStoreApp_.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Number { get; set; } = string.Empty;

        public string? Cvc { get; set; }

        public string? Type { get; set; }

        [Required]
        public int UserId { get; set; }

        public User User { get; set; } = null!;

        public ICollection<Purchase> Purchases { get; set; }
            = new List<Purchase>();
    }
}
