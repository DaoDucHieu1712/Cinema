using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace Cinema.Controllers
{
    public class MovieController : Controller
    {
        private readonly CenimaDBContext _context;

        public MovieController(CenimaDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {

            Person user = HttpContext.Session.GetString("user") != null ?
    JsonSerializer.Deserialize<Person>(HttpContext.Session.GetString("user")) : null;
            if (user == null)
            {
                return Redirect("/Home/Login");
            }
            else
            {

                var movie = _context.Movies.Include(x => x.Genre).FirstOrDefault(x => x.MovieId == id);
                var ratings = _context.Rates.Include(x => x.Person).Include(x => x.Movie).Where(x => x.MovieId == id).ToList();
                double? sum = 0;
                double count = 0;
                foreach (var item in ratings)
                {
                    sum += item.NumericRating;
                    count++;
                }
                var result = sum / count;
                Rate rate = _context.Rates.Include(x => x.Person).Include(x => x.Movie).Where(x => x.MovieId == id && x.PersonId == user.PersonId).FirstOrDefault();
                
                if(rate == null)
                {
                    ViewBag.mark = 0;
                    ViewBag.cmt = "";
                }
                else
                {
                    ViewBag.mark = rate.NumericRating;
                    ViewBag.cmt = rate.Comment;
                }

                ViewBag.movie = movie;
                ViewBag.ratings = ratings;
                ViewBag.score = result;
                return View();
            }
        }

        public bool Check(Person p, int id)
        {
            var rates = _context.Rates.ToList();
            foreach (var item in rates)
            {
                if (p.PersonId == item.PersonId && id == item.MovieId)
                {
                    return true;
                }
            }
            return false;
        }

        public IActionResult Create(Rate NewRate)
        {
            Person user = HttpContext.Session.GetString("user") != null ?
    JsonSerializer.Deserialize<Person>(HttpContext.Session.GetString("user")) : null;
            if (!Check(user, NewRate.MovieId))
            {
                NewRate.PersonId = user.PersonId;
                _context.Rates.Add(NewRate);
                _context.SaveChanges();
            }
            else
            {
                var rate_up = _context.Rates.Where(x => x.MovieId == NewRate.MovieId && x.PersonId == user.PersonId).FirstOrDefault();
                rate_up.NumericRating = NewRate.NumericRating;
                rate_up.Comment = NewRate.Comment;
                _context.SaveChanges();
            }
            return Redirect($"/Movie/Detail?id={NewRate.MovieId}");
        }


        public IActionResult List()
        {
            var movies = _context.Movies.Include(x => x.Genre).ToList();
            var genres = _context.Genres.ToList();
            ViewBag.movies = movies;
            ViewBag.genres = genres;
            return View();
        }

        public IActionResult Insert(Movie NewMovie)
        {
            _context.Movies.Add(NewMovie);
            _context.SaveChanges();
            return Redirect("/Movie/List");
        }

        public IActionResult Delete(int id)
        {
            var movie = _context.Movies.FirstOrDefault(x => x.MovieId == id);
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return Redirect("/Movie/List");
        }

        public IActionResult Edit(int id)
        {
            var movies = _context.Movies.Include(x => x.Genre).ToList();
            var genres = _context.Genres.ToList();
            var movie = _context.Movies.Include(x => x.Genre).Where(x => x.MovieId == id).FirstOrDefault();
            ViewBag.movies = movies;
            ViewBag.genres = genres;
            ViewBag.movie = movie;
            return View();
        }

        public IActionResult Update(Movie NewMovie)
        {
            var movie = _context.Movies.Where(x => x.MovieId == NewMovie.MovieId).FirstOrDefault();
            if (movie != null)
            {
                movie.Title = NewMovie.Title;
                movie.Year = NewMovie.Year;
                movie.Image = NewMovie.Image;
                movie.Description = NewMovie.Description;
                movie.GenreId = NewMovie.GenreId;
                _context.SaveChanges();
            }
            return Redirect("/Movie/List");
        }


        public double? getAverageRating(int movieId)
        {
            double? a = _context.Rates.Where(c => c.MovieId == movieId).Average(r => r.NumericRating);
            return a;

        }

        public bool checkChart(Chart c, List<Chart> list)
        {
            foreach (var item in list)
            {
                if(item.Name == c.Name && item.Score == c.Score)
                {
                    return true;
                }
            }
            return false;
        }

        public IActionResult DashBoard()
        {
            var rates = _context.Rates.Include(x => x.Movie).ToList();
            List<Chart> charts = new List<Chart>();
            foreach (var item in rates)
            {
                double mark = 0;
                Chart c = new Chart();
                c.Name = item.Movie.Title;
                c.Score = getAverageRating(item.MovieId);
                if(!checkChart(c, charts))
                {
                    charts.Add(c);
                }
            }
            ViewBag.user_tt = _context.Persons.Count();
            ViewBag.movie_tt = _context.Movies.Count();
            ViewBag.genre_tt = _context.Genres.Count();
            ViewBag.charts = charts.OrderBy(x => x.Score).Take(7).ToList();
            return View();
        }


    }

    public class Chart
    {
        private string name;
        private double? score;

        public string Name { get => name; set => name = value; }
        public double? Score { get => score; set => score = value; }
    }

}
