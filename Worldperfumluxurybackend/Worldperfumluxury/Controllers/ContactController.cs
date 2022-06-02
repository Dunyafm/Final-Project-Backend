using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worldperfumluxury.Data;
using Worldperfumluxury.Models;
using Worldperfumluxury.ViewModels.Admin;

namespace Worldperfumluxury.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IWebHostEnvironment _env;

        public ContactController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IWebHostEnvironment env)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _env = env;
            _context = context;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            List<Contact> contact = await _context.Contacts.ToListAsync();
            ContactVM contacts = new ContactVM
            {

                Contacts = contact

            };
            return View(contacts);
        }
        #endregion

        #region Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ContactVM contactVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }



            Contact contacts = new Contact
            {
                UserName = contactVM.UserName,
                Email = contactVM.Email,
                Phone = contactVM.Phone,
                Yourmessage = contactVM.Yourmessage
            };

            await _context.Contacts.AddAsync(contacts);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int Id)
        {
            Contact contact = await _context.Contacts.Where(m => m.Id == Id).FirstOrDefaultAsync();

            if (contact == null) return NotFound();


            _context.Contacts.Remove(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

    }
}
