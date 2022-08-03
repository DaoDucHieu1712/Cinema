using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Models;


namespace Cinema.Controllers
{
    public class PersonController : Controller
    {
        private readonly CenimaDBContext _context;

        public PersonController(CenimaDBContext context)
        {
            _context = context;
        }

        public IActionResult List()
        {
            var persons = _context.Persons.ToList();
            ViewBag.persons = persons;
            return View();
        }

        public IActionResult Block(int id)
        {
            var person = _context.Persons.Where(x => x.PersonId == id).FirstOrDefault();
            if(person != null)
            {   
                person.IsActive = false;
                _context.SaveChanges();
            }
            return Redirect("/Person/List");
        }

        public IActionResult UnBlock(int id)
        {
            var person = _context.Persons.Where(x => x.PersonId == id).FirstOrDefault();
            if (person != null)
            {
                person.IsActive = true;
                _context.SaveChanges();
            }
            return Redirect("/Person/List");
        }
    }
}
