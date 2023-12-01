using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PassMan.Core;
using PassMan.Core.DB;
using PassMan.Core.Models;

namespace PassMan.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly PasswordManagerDbContext _context;

        public UsersController(PasswordManagerDbContext context)
        {
            _context = context;
        }


        // GET: Users/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: Users/Register
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("Username,Password,Email,Firstname,Lastname")] User user)
        {
            if (ModelState.IsValid)
            {
                user.Password = Encrypter.Encrypt(user.Email, user.Password.Trim());
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Login));
            }
            return View(user);
        }

        private bool UserExists(string id)
        {
          return (_context.Users?.Any(e => e.Username == id)).GetValueOrDefault();
        }

        // GET: Users/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: Users/Login
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Login(string Username, string Password)
        {
            var FoundUser = await _context.Users.FirstOrDefaultAsync(m => m.Username == Username);
            if (FoundUser == default(User)) 
            {
                Debug.WriteLine($"User not found: {Username}");
                return View();
            }
           
            Password = Password.Trim();
            string FoundPassword = Encrypter.Decrypt(FoundUser.Email, FoundUser.Password);
            
            if (FoundPassword == Password)
            {
                Core.Models.User.LoggedInUser = FoundUser;
                return RedirectToAction("Index", "Vaults");
            }
            
            return View();
        }

        public IActionResult Logout()
        {
            Core.Models.User.LoggedInUser = null;
            return RedirectToAction("Login", "Users");
        }
    }
}
