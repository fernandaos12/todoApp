using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using todoApp.Data;
using Microsoft.EntityFrameworkCore;
using todoApp.Models;

namespace todoApp.Controllers
{
    [Route("[controller]")]
    [Authorize]
    public class UserController : Controller    
    {
        private readonly UserDbContext _context;

        public UserController(UserDbContext context)
        {
            _context = context;
        }


        [HttpGet()]
        public async Task<IActionResult> Index()
        {
            var retorno = await _context.user.ToListAsync();
            return View(retorno);
        }

        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            var user = _context.user.FirstOrDefault(p => p.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
            var retorno = CreatedAtAction(nameof(FindById), new { id = 1 });
            return View(retorno);
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] User user)
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

        [HttpDelete("id")]
        public async Task<IActionResult> Excluir(int id)
        {
            User user = new User();
            user.Id = id;
            _context.Remove(id);
            await _context.SaveChangesAsync();
            return NoContent();

        }
    }
}