using System.ComponentModel.DataAnnotations;

namespace GameStoreApp_.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<GameTag> GameTags { get; set; }
            = new List<GameTag>();
    }
}
