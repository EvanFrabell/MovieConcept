using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieConcept.Model
{
    public class Bio
    {
        [Key, ForeignKey("Principal")]
        [Column("nconst")]
        [StringLength(50)]
        public string NameId { get; set; }
        public Principal Principal { get; set; }

        [Column("primaryName")]
        public string PrimaryName { get; set; }
        [Column("birthYear")]
        public int BirthYear { get; set; }
        [Column("deathYear")]
        public int DeathYear { get; set; }
        [Column("primaryProfession")]
        public string PrimaryProfession { get; set; }
    }
}
