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
    }
}   
