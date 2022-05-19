# MovieConcept
 
##Setup Instructions (2 Options)

## OPTION 1 - Visit below URL for GraphQL Playground
- !! Not Hosted Yet !!

## OPTION 2 - Developers

### 1. Install Visual Studio 2022 Community
- https://visualstudio.microsoft.com/downloads/

### 2. Clone Repo onto local disk (main branch)
- https://github.com/EvanFrabell/MovieConcept

### 3. Download SQL Server and SQL Server Management Studio
- https://www.microsoft.com/en-us/sql-server/sql-server-downloads (Option to install Manager in Express)
- https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15

- In SSMS right click Databases under your server name and create a new DB.  "imdbOriginal" should be the name.

### 4. Download Files below and import to SQL Server

- Right click "imdbOriginal" database > Tasks > Import Flat File
- Use the following .csv files https://www.dropbox.com/sh/kumzl9uitv8xkcd/AACgi0tTf6iur0pd_8Exoez-a?dl=0

### 5. Run Code in Visual Studio by Debug Mode or Express



### Quick Queries to Run in GraphQL 
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