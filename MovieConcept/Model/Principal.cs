using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MovieConcept.Model
{
    [Table("principals")]
    public class Principal
    {
        [Key]
        [Column("gtin")]
        public string Gtin { get; set; }

        [ForeignKey("MovieTitle")]
        [Column("tconst")]
        public string Tid { get; set; }
        public MovieTitle MovieTitle { get; set; }

        [Column("ordering")]
        public int Ordering { get; set; }

        [ForeignKey("Bio")]
        [Column("nconst")]
        public string Nconst { get; set; }
        public Bio Bio { get; set; }

        [Column("category")]
        public string Category { get; set; }





    }
}
