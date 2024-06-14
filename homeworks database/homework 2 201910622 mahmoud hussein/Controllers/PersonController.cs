using Microsoft.AspNetCore.Mvc;
using PersonApp.Data;
using PersonApp.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PersonApp.Controllers
{
    public class PersonController : Controller
    {
        private readonly PersonDBContext _context;

        public PersonController(PersonDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Persons.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Mobile,Address")] Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }
    }
}