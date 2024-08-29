using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Movies.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _moviesService;

        public MoviesController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }
        
        public async Task<ActionResult> Index()
        {
            var movies = await _moviesService.GetMovies();
            
            return View(movies);
        }

        public async Task<ActionResult> Details(int id)
        {
            var movie = await _moviesService.GetMovieById(id);
            if (movie is null) return NotFound("Movie not found.");

            return View(movie);
        }
        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create([Bind("Id,Title,ReleaseDate,Genre,Price,Rating")] Movie movie)
        {
            if (!ModelState.IsValid) return View(movie);

            await _moviesService.AddMovie(movie);
            return RedirectToAction("Index");
        }

    }
}
