﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace MovieConcept
{
    //[Keyless]
    [Table("title.principals")]
    public partial class TitlePrincipals
    {
        [ForeignKey("TitleBasics")]
        [Column("tconst")]
        [StringLength(50)]
        [JsonIgnore]
        public string Tconstt { get; set; }

        [Column("ordering")]
        [UseSorting]
        public int Ordering { get; set; }

        [ForeignKey("NameBasics")]
        [Column("nconst")]
        [StringLength(50)]
        public string Nconst { get; set; }
        [Required]
        [Column("category")]
        [StringLength(50)]
        public string Category { get; set; }

        [JsonIgnore]
        public virtual TitleBasics TitleBasics { get; set; }

        public virtual NameBasics NameBasics { get; set; }  

    }
}