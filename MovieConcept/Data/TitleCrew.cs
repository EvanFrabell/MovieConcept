using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieConcept.Data
{
    [Table("title.crew")]
    public class TitleCrew
    {
        [Key]
        [Column("tconst")]
        [StringLength(50)]
        public string? CrewId { get; set; }

        [Column("director1")]
        public string? Director1 { get; set; }

        [Column("director2")]
        public string? Director2 { get; set; }

        [Column("director3")]
        public string? Director3 { get; set; }
        
        [Column("writer1")]
        public string? Writer1 { get; set; }

        [Column("writer2")]
        public string? Writer2 { get; set; }

        [Column("writer3")]
        public string? Writer3 { get; set; }
    }

}
