using Cinemapravc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cinemapravc.Controllers
{
    public class UsuariosController : Controller 
    {
        private readonly AppDbContext _context;
        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Usuario Usuarios)
        {
            if(ModelState.IsValid)
            {
                _context.Usuarios.Add(Usuarios);
                await _context.SaveChangesAsync();
                return RedirectToAction("Homepage");
            }
            return View(Usuarios);
        }
    }
}   
