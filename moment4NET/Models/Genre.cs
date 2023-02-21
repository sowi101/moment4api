using System.ComponentModel.DataAnnotations;

namespace moment4NET.Models
{
    public class Genre
    {
        // Properties
        public int GenreId { get; set; }

        [Required]
        public string? GenreName { get; set;}

            // Relation to Song model
        public List<Song>? Songs { get; set; } = new List<Song>();
    }
}
