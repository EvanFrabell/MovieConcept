using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieConcept.Model
{
    [Table("title.ratings")]
    public class Rating
    {
        [Key, ForeignKey("MovieTitle")]
        [Column("tconst")]
        public string Tconstr { get; set; }
        public MovieTitle MovieTitle { get; set; }

        [Column("averageRating")]
        public double? AverageRating { get; set; }
        [Column("numVotes")]
        public int NumVotes { get; set; }

        //public virtual ICollection<MovieTitle> MovieTitle { get; set; }
    }
}
