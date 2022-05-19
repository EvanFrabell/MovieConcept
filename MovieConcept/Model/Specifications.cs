using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieConcept.Model
{
    [Table("title.specs")]
    public class Specifications
    {
        [Key, ForeignKey("Bio")]
        [Column("nconst")]
        public string Nid { get; set; }
        public Bio Bio { get; set; }

        [Column("heightInches")]
        public byte HeightInches { get; set; }

        [Column("favoriteWord")]
        public string FavoriteWord { get; set; }

        [Column("petOwned")]
        public string PetOwned { get; set; }

        [Column("numberOfKids")]
        public byte NumberOfKids{ get; set; }

    }
}
