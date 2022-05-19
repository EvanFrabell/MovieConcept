using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieConcept.Model
{
    [Table("titles.ratings")]
    public class Rating
    {
        [Key, ForeignKey("MovieTitle")]
        [Column("tconst")]
        [StringLength(50)]
        public string Tconstr { get; set; }
        [Column("averageRating")]
        public double? AverageRating { get; set; }
        [Column("numVotes")]
        public int NumVotes { get; set; }
    }
}
