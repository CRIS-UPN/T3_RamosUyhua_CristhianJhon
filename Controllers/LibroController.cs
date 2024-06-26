using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using T3_RamosUyhua_CristhianJhon.Libros;
using T3_RamosUyhua_CristhianJhon.Models;

namespace T3_RamosUyhua_CristhianJhon.Controllers
{
    public class LibroController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LibroController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Libro> lista = _db.Libros;
            return View(lista);
        }

        [Authorize]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Libro Libro)
        {
            if (ModelState.IsValid)
            {
                _db.Libros.Add(Libro);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(Libro);

        }

        [Authorize]
        //Get Editar
        public IActionResult Editar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var obj = _db.Libros.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Post Editar

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Libro Libro)
        {
            if (ModelState.IsValid)
            {
                _db.Libros.Update(Libro);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(Libro);
        }

        [Authorize]
        //Get Eliminar
        public IActionResult Eliminar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var obj = _db.Libros.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //Post Eliminar

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Eliminar(Libro Libro)
        {
            if (Libro == null)
            {
                return NotFound();
            }

            _db.Libros.Remove(Libro);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
