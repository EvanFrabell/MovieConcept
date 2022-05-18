﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace MovieConcept
{
    [Table("title.ratings")]
    public partial class TitleRatings
    {
        //[Key]
        [Key, ForeignKey("TitleBasics")]
        [Column("tconst")]
        [StringLength(50)]
        [JsonIgnore]
        public string Tconstr { get; set; }
        [Column("averageRating")]
        public double? AverageRating { get; set; }
        [Column("numVotes")]
        public int? NumVotes { get; set; }

        //[ForeignKey("Tconst")]
        // [InverseProperty("TitleRatings")]
        //[JsonIgnore]
        // public virtual TitleBasics TconstNavigation { get; set; }
        //public virtual string Tconst { get; set; }
        //[ForeignKey("Tconst")]
        [JsonIgnore]
        public virtual TitleBasics TitleBasics { get; set; }
    }
}