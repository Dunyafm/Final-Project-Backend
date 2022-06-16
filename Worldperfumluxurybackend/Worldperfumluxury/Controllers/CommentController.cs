using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Worldperfumluxury.ViewModels.Comment;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worldperfumluxury.Data;
using Worldperfumluxury.Models;


namespace Worldperfumluxury.Controllers
{
    public class CommentController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IWebHostEnvironment _env;

        public CommentController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IWebHostEnvironment env)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _env = env;
            _context = context;
        }

        //#region Index
        //public async Task<IActionResult> Index()
        //{
        //    List<Comment> comment = await _context.Comments.ToListAsync();
        //    CommentVM comments = new CommentVM
        //    {

        //        Comments = comment

        //    };
        //    return View(comments);
        //}
        //#endregion

        #region Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Moderator")]
        public async Task<IActionResult> Create(Comment comment)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            bool isExist = _context.Comments.Any(m => m.TextMessage.ToLower().Trim() == comment.TextMessage.ToLower().Trim());

            if (isExist)
            {
                ModelState.AddModelError("Name", "Bu Comment artiq movcuddur");
                return View();
            }

            Comment comments = new Comment
            {
                Name = comment.Name,
                Email = comment.Email,
                Subject = comment.Subject,
                TextMessage = comment.TextMessage
            };

            await _context.Comments.AddAsync(comments);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Moderator")]
        public async Task<IActionResult> Delete(int Id)
        {
            Comment comment = await _context.Comments.Where(m => m.Id == Id).FirstOrDefaultAsync();

            if (comment == null) return NotFound();


            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}
