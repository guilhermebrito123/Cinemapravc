using Cinemapravc.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

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

        public ActionResult Homepage()
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
                Usuarios.Senha = BCrypt.Net.BCrypt.HashPassword(Usuarios.Senha);
                _context.Usuarios.Add(Usuarios);
                await _context.SaveChangesAsync();
                return RedirectToAction("Homepage");
            }
            return View(Usuarios);
        }

        public IActionResult Login() 
        {
            return View(); 
        }

        [HttpPost]
        public async Task<IActionResult> Login(Usuario Usuarios) 
        {
            var dados = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == Usuarios.Email);

            if (dados == null)
            {
                ViewBag.Message = "Email ou senha inválidos";
                return View();
            }
            bool senhaOK = BCrypt.Net.BCrypt.Verify(Usuarios.Senha, dados.Senha);
            if(senhaOK)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, dados.Nome),
                    new Claim(ClaimTypes.Email, dados.Email),
                    new Claim(ClaimTypes.Role, dados.Tipo.ToString())
                };

                var usuarioIdentidade = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(usuarioIdentidade);

                var propsAutenticacao = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, propsAutenticacao);
                return RedirectToAction("Homepage");
            }
            else
            {
                ViewBag.Message = "Email ou senha inválidos";
                return View();
            }
        }
    }
}   
