using Hospital.DataAccessLayer.Data;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    public class HomeController: Controller
    {
        readonly private ApplicationDbContext _dbContext;
        public HomeController(ApplicationDbContext context)
        {
            _dbContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Appointment()
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Price()
        {
            return View();
        }
        public IActionResult Search()
        {
            return View();
        }
        public IActionResult Team()
        {
            
            return View(_dbContext.Doctors.AsQueryable().ToList());
        }
        public IActionResult Testimonial()
        {
            return View(_dbContext.Doctors.Where(d=>d.Image.Contains("tes")).ToList());
        }
    }
}
