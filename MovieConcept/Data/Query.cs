using MovieConcept.Model;

namespace MovieConcept.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<MovieTitle> GetAllMovies([Service] imdbOriginalContext context) =>
            context.MovieTitles;

        //[UseProjection]
        //[UseFiltering]
        //[UseSorting]
        //public IQueryable<TitleCrew> GetFullCrew([Service] imdbOriginalContext context) =>
        //    context.TitleCrew;

        //public async Task<TitleCrew?> GetCrewId(string id, [Service] imdbOriginalContext context)
        //{
        //    if (context.TitleCrew == null)
        //    {
        //        return null;
        //    }
        //    var titleCrew = await context.TitleCrew.FindAsync(id);

        //    if (titleCrew == null)
        //    {
        //        return null;
        //    }

        //    return titleCrew;
        //}

        //public async Task<TitleBasics?> GetTitleBasics(string id, [Service] imdbOriginalContext context)
        //{
        //    if (context.TitleBasics == null)
        //    {
        //        return null;
        //    }
        //    var titleBasics = await context.TitleBasics.FindAsync(id);

        //    if (titleBasics == null)
        //    {
        //        return null;
        //    }

        //    return titleBasics;
        //}


    }
}
