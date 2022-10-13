using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySqlApp.Data;
using MySqlApp.Models;
using System.Diagnostics;

namespace MySqlApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlogDbContext _context;

        public HomeController(BlogDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            await _context.Posts.AddRangeAsync(
                new Post { AuthorId = Random.Shared.Next(1, 2), Title = $"Post {Random.Shared.Next()}" },
                new Post { AuthorId = Random.Shared.Next(1, 2), Title = $"Post {Random.Shared.Next()}" }
                );

            await _context.SaveChangesAsync();

            TempData["Success"] = "Successfully Added Posts to Db";

            return View(await _context.Posts.Include(x => x.Author).ToListAsync());
        }

    }
}