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
        private readonly ToDoDbContext _context;

        public ToDoController(ToDoDbContext context)
        {
            _context = context;
        }

        //Get Todo
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var retorno = await _context.To_Do.ToListAsync();
            return View(retorno);
        }

        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {           
            var toDo = _context.To_Do.FirstOrDefault(p=>p.id == id);
              if (toDo == null)
            {
                return NotFound();
            } 
           
            return View(toDo);       
        }     
        
        [HttpGet]
        public IActionResult Create(int id)
        {            
            var retorno = CreatedAtAction(nameof(FindById), new{id= 1});
            return View(retorno);
        }   


        [HttpPost]
        public async Task<IActionResult> Create([FromBody]ToDo to_do)
        {   
                if (ModelState.IsValid)
                {
                 to_do.User = User.Identity.Name;

                  _context.Add(to_do);
                  await _context.SaveChangesAsync();
                  return RedirectToAction(nameof(Index));  
                }
            return View(to_do.id);
        }

        [HttpDelete("id")]
        public async Task<IActionResult> Excluir(int id)
        {
            ToDo to_do = new ToDo();
            to_do.id = id;
            _context.Remove(id);
            await _context.SaveChangesAsync();
            return NoContent();       

        }
    }
}