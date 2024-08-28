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

    }
}
