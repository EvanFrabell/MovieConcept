#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace MovieConcept
{
    [Table("name.basics")]
    public partial class NameBasics
    {
        [Key]
        [Column("nconst")]
        [StringLength(50)]
        [JsonIgnore]
        public string NameId { get; set; }
        [Column("primaryName")]
        [Required]
        public string PrimaryName { get; set; }
        [Column("birthYear")]
        public int? BirthYear { get; set; }
        [Column("deathYear")]
        public int? DeathYear { get; set; }
        [Column("primaryProfession")]
        public string PrimaryProfession { get; set; }

        
       // public virtual ICollection<TitlePrincipals> TitlePrincipals { get; set; }

    
    }
}