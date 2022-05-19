# MovieConcept
 
# Quick Queries to Run in GraphQL 
 query {
  allMovies {
    tconst,
    titleType,
    primaryTitle,
    originalTitle,
    genres,
    ratings {
      averageRating,
      numVotes
    }
    crew {
      gtin,
      role,
      bio {
        primaryName,
        birthYear,
        deathYear,
        primaryProfession,
        specifications {
          heightInches,
          favoriteWord,
          petOwned,
          numberOfKids
      }
      }
    }
  }
}


query {
  allMovies(where: {
    primaryTitle: {
      contains: "North"
      }
  }) {
    tconst,
    titleType,
    primaryTitle,
    originalTitle,
    genres,
    ratings {
      averageRating,
      numVotes
    }
    crew {
      gtin,
      role,
      bio {
        primaryName,
        birthYear,
        deathYear,
        primaryProfession,
        specifications {
          heightInches,
          favoriteWord,
          petOwned,
          numberOfKids
      }
       
      }
      
    }
  }
}