#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MovieConcept.Data;
using MovieConcept.Model;

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

        public virtual DbSet<MovieTitle> MovieTitles { get; set; }
        public virtual DbSet<Principal> Principals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}