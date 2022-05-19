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
        [StringLength(50)]
        public string Tconstt { get; set; }
        public MovieTitle MovieTitle { get; set; }

        [Column("ordering")]
        [UseSorting]
        public int Ordering { get; set; }

        //[ForeignKey("NameBasics")]
        [Column("nconst")]
        [StringLength(50)]
        public string Nconst { get; set; }

        [Column("category")]
        public string Category { get; set; }

       
    }
}
