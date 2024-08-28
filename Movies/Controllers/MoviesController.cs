using Microsoft.AspNetCore.Mvc;

namespace Movies.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}
