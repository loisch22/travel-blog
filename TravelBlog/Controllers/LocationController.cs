using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TravelBlog.Models;

namespace TravelBlog.Controllers
{
    public class LocationController : Controller
    {
        private TravelBlogDbContext db = new TravelBlogDbContext();

        public IActionResult Index()
        {
            return View(db.Locations.ToList());
        }
    }
}
