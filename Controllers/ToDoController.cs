using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using todoApp.Data;
using todoApp.Models;

namespace todoApp.Controllers
{
    [Route("[controller]")]
    [Authorize]
    public class ToDoController : Controller
    {
    
        private readonly ApplicationDbContext _context;

        public ToDoController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Get Todo
        public async Task<IActionResult> Index()
        {
            return View(await _context.Todos.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        [HttpGet]
        public async Task<IActionResult> Create([Bind("id,Title,Done")])
        {
        }   


        [HttpPost]
        public async Task<IActionResult> Create([Bind("id,Title,Done")])
        {
                if (ModelState.IsValid)
                {
                 ToDo.User = User.Identity.Name;
                  _context.Add(ToDo);
                  await _context.SaveChangesAsync();
                  return RedirectToAction(nameof(Index));  
                }
                return View(ToDo);
        }


           public async Task<IActionResult> Edit(int? id)
        {

        }

           public async Task<IActionResult> Excluir(int? id)
           {

           }
    }
}