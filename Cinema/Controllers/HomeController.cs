using Cinema.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace Cinema.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CenimaDBContext _context;

        public HomeController(ILogger<HomeController> logger, CenimaDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var movies = _context.Movies.Include(x => x.Genre).ToList();
            var genres = _context.Genres.ToList();
            ViewBag.movies = movies;
            ViewBag.genres = genres;
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _context.Persons.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
            if (user == null)
            {
                ViewBag.err = "username or password invalid !";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("user", JsonSerializer.Serialize(user));
                if (user.Type == 1)
                {
                    return Redirect("/Movie/Dashboard");
                }
                else
                {
                    return Redirect("/Home/Index");
                }
            }

        }

        public IActionResult Search(string? txtSearch, int? genre)
        {
            if (txtSearch == null)
            {
                txtSearch = "";
            }
            List<Movie> movies = new List<Movie>();
            if (genre != null)
            {
                movies = _context.Movies.Include(x => x.Genre).
                Where(x => x.Title.ToLower().Contains(txtSearch.ToLower()) && x.Genre.GenreId == genre)
                .ToList();
            }
            else
            {

                movies = _context.Movies.Include(x => x.Genre).
                Where(x => x.Title.ToLower().Contains(txtSearch.ToLower()))
                .ToList();
            }


            var genres = _context.Genres.ToList();
            ViewBag.movies = movies;
            ViewBag.genres = genres;
            ViewBag.genre = genre;
            ViewBag.txtSearch = txtSearch;
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("user");
            return Redirect("/Home");
        }

        public IActionResult Register(Person NewPerson, bool gender)
        {
            string sex = "";
            if (gender == true)
            {
                sex = "Nam";
            }
            else
            {
                sex = "Nu";
            }
            NewPerson.Gender = sex;
            NewPerson.IsActive = true;
            NewPerson.Type = 2;

            var check_user = _context.Persons.Where(x => x.Email == NewPerson.Email).FirstOrDefault();
            if (check_user != null || NewPerson.Email == null)
            {
                ViewBag.alert = "Tai khoan khong hop le !";
                return View();
            }
            else
            {
                _context.Persons.Add(NewPerson);
                if(_context.SaveChanges() > 0)
                {
                ViewBag.alert = "Dang ky tai khoan thanh cong !";
                }
                return View();
            }

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
