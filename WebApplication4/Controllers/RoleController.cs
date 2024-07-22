using Microsoft.AspNetCore.Mvc;
using WebApplication4.DAL;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class RoleController : Controller
    {
        private readonly CartDbContext _cartDbContext;
        public RoleController(CartDbContext cartDbContext)
        {
            _cartDbContext = cartDbContext;
        }

        public IActionResult Index()
        {
            Role r= new Role();
            RoleRepo role = new RoleRepo(_cartDbContext);
            var data = role.getRoles();
            
            
            return View(data);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Role role)
        {
            RoleRepo roleRepo = new RoleRepo(_cartDbContext);
            var data = roleRepo.AddRoles(role);
            
            return RedirectToAction("Index");
        }

    }
}
