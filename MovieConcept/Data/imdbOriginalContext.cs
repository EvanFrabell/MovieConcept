#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MovieConcept.Data;

namespace MovieConcept
{
    public partial class imdbOriginalContext : DbContext
    {
        public imdbOriginalContext()
        {
        }

        public imdbOriginalContext(DbContextOptions<imdbOriginalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NameBasics> NameBasics { get; set; }
        public virtual DbSet<TitleAkas> TitleAkas { get; set; }
        public virtual DbSet<TitleBasics> TitleBasics { get; set; }
        public virtual DbSet<TitlePrincipals> TitlePrincipals { get; set; }
        public virtual DbSet<TitleRatings> TitleRatings { get; set; }
        public virtual DbSet<TitleCrew> TitleCrew { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TitlePrincipals>().HasKey(tp => new { tp.Tconstt, tp.Nconst });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}