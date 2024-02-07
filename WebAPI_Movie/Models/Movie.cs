using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_Movie.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string? MName { get; set; }
        public string? StarCast { get; set; }
        public string? Director { get; set; }
        public string? Producer { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
