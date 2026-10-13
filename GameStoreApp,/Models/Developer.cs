using System.ComponentModel.DataAnnotations;

namespace GameStoreApp_.Models
{
    public class Developer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<Game> Games { get; set; }
            = new List<Game>();
    }
}
