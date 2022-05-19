using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieConcept.Model
{
    [Table("titles.movies")]
    public class MovieTitle
    {
        [Key]
        [Column("tconst")]
        [StringLength(50)]
        public string Tconst { get; set; }
        
        [Column("titleType")]
        public string TitleType { get; set; }
       
        [Column("primaryTitle")]
        public string PrimaryTitle { get; set; }
        
        [Column("originalTitle")]
        public string OriginalTitle { get; set; }
        
        [Column("startYear")]
        public int StartYear { get; set; }
        
        [Column("runtimeMinutes")]
        public int RuntimeMinutes { get; set; }
        
        [Column("genres")]
        public string Genres { get; set; }
        public ICollection<Principal> Crew { get; set; }
    }
 }
