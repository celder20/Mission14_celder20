using Microsoft.AspNetCore.Mvc;
using Mission14_API.Data;

namespace Mission14_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private MovieDbContext context;

        //Constructor
        public MovieController(MovieDbContext temp)
        {
            context = temp;
        }

        //Goes through all of the movies and grabs the data
        public IEnumerable<Movie> Get()
        {
            //Filtering the data to where it only displays movies that are edited, and orders them by the title
            var x = context.Movies.Where(m => m.Edited == "Yes").OrderBy(m => m.Title).ToArray();
            return x;
        }
    }
}
