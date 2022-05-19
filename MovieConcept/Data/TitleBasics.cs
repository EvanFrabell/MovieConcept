﻿#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace MovieConcept
{
    [Table("title.basics")]
    
    public partial class TitleBasics
    {
        [Key]
        [Column("tconst")]
        [StringLength(50)]
        [JsonPropertyOrder(-7)]
        public string Tconst { get; set; }
        [Column("titleType")]
        [JsonPropertyOrder(-6)]
        public string TitleType { get; set; }
        [Column("primaryTitle")]
        [JsonPropertyOrder(-5)]
        public string PrimaryTitle { get; set; }
        [Column("originalTitle")]
        [JsonPropertyOrder(-4)]
        public string OriginalTitle { get; set; }
        [Column("startYear")]
        [JsonPropertyOrder(-3)]
        public int? StartYear { get; set; }
        [Column("runtimeMinutes")]
        [JsonPropertyOrder(-2)]
        public int? RuntimeMinutes { get; set; }
        [Column("genres")]
        [JsonPropertyOrder(-1)]
        public string Genres { get; set; }

        public virtual ICollection<TitleRatings> Ratings { get; set; }

        public virtual ICollection<TitleAkas> AlternateTitles { get; set; }

        public virtual ICollection<TitlePrincipals> Crew { get; set; }

    }
}