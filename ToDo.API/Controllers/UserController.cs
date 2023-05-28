using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using todoApp.Models;
using ToDoApp.Core.Repository;

namespace todoApp.Controllers
{
    [Route("api/users")]
    //[Authorize]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet()]
        public async Task<IActionResult> Index()
        {
            var retorno = await _context.User.ToListAsync();
            return View(retorno);
        }

        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            var user = _context.User.FirstOrDefault(p => p.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        //[HttpGet()]
        //public IActionResult CreateReturn(int id)
        //{
        //    var retorno = CreatedAtAction(nameof(FindById), new { id = 1 });
        //    return View(retorno);
        //}


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserModel user)
        {
            if (ModelState.IsValid)
            {
                user.Name = User.Identity.Name;

                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user.Id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Excluir(int id)
        {
            UserModel user = new UserModel();
            user.Id = id;
            _context.Remove(id);
            await _context.SaveChangesAsync();
            return NoContent();

        }
    }
}