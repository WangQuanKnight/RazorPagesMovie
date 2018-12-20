using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie.Models.RazorPagesMovieContext _context;

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SelectedGenre { get; set; }

        public IndexModel(RazorPagesMovie.Models.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> GenresList = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;

            Genres = new SelectList(await GenresList.Distinct().ToListAsync());

            var movies = from item in _context.Movie
                         select item;
            if (!String.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(item => item.Title.Contains(SearchString));
            }
            if (!String.IsNullOrEmpty(SelectedGenre))
            {
                movies = movies.Where(item => item.Genre == SelectedGenre);
            }
            Movie = await movies.ToListAsync();
        }
    }
}
