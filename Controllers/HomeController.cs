using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogProgWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogProgWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlogContext _context;

        public HomeController(BlogContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Posts = await _context.Posts.Include(x => x.Categoria).ToListAsync();

            return View();
        }

        public async Task<IActionResult> Post(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts.Include(x => x.Categoria).FirstOrDefaultAsync(x => x.Id == id);

            if (post == null)
            {
                return NotFound();
            }


            return View(post);
        }

        public async Task<IActionResult> Categorias()
        {
 
            var categorias = await _context.Categorias.Include(x => x.Posts).ToListAsync();

            return View(categorias);
        }

        public IActionResult Sobre()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
