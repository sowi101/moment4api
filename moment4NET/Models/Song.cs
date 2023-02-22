using System.ComponentModel.DataAnnotations;

namespace moment4NET.Models
{
    public class Song
    {
        // Properties
        public int SongId { get; set; }

        [Required]
        public string? Artist { get; set;}

        [Required]
        public string? Title { get; set;}

        [Required]
        public int? Length { get; set;}

            // Relation to Genre model
        [Required]
        public int GenreId { get; set;}
        public Genre? Genre { get; set;}
    }
}
