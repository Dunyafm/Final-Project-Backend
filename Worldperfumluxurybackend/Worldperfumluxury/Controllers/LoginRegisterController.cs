using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using System.IO;
using System.Security.Claims;
//using System.Net.Mail;
using System.Threading.Tasks;
using Worldperfumluxury.Models;
using Worldperfumluxury.ViewModels.Account;
using static Worldperfumluxury.Utilites.Helpers.Helper;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace Worldperfumluxury.Controllers
{
    public class LoginRegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IWebHostEnvironment _env;
        private readonly RoleManager<IdentityRole> _roleManager;

        public LoginRegisterController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IWebHostEnvironment env, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _env = env;
            _roleManager = roleManager;
        }
        #region Register
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View(registerVM);

            AppUser newUser = new AppUser()
            {
                FullName = registerVM.FullName,
                UserName = registerVM.Username,
                Email = registerVM.Email
            };

            IdentityResult result = await _userManager.CreateAsync(newUser, registerVM.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);

                }
                return View(registerVM);
            }


            if (string.IsNullOrWhiteSpace(registerVM.Email))
            {
                return RedirectToAction("Index", "Error");
            }
            AppUser appUser = await _userManager.FindByEmailAsync(registerVM.Email);

            if (appUser == null)
                return RedirectToAction("Index", "Error");

            var message = new MimeMessage();

            message.From.Add(new MailboxAddress("Worldperfumluxury", "Dunyafm@code.edu.az"));

            message.To.Add(new MailboxAddress(appUser.FullName, appUser.Email));
            message.Subject = "Confirm Email";

            string emailbody = string.Empty;

            using (StreamReader streamReader = new StreamReader(Path.Combine(_env.WebRootPath, "Templates", "Confirm.html")))
            {
                emailbody = streamReader.ReadToEnd();
            }

            await _userManager.AddToRoleAsync(newUser, UserRoles.User.ToString());

            var code = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
            var url = Url.Action(nameof(VerifyEmail), "LoginRegister", new { userId = newUser.Id, token = code }, Request.Scheme, Request.Host.ToString());


            emailbody = emailbody.Replace("{{fullname}}", $"{appUser.FullName}").Replace("{{code}}", $"{url}");

            message.Body = new TextPart(TextFormat.Html) { Text = emailbody };

            using var smtp = new SmtpClient();

            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("Dunyafm@code.edu.az", "fpqnwcqsuweiidrp");
            smtp.Send(message);
            smtp.Disconnect(true);


            return RedirectToAction("Index", "Home");
        }
        #endregion

        #region VerifyEmail
        public async Task<IActionResult> VerifyEmail(string userId, string token)
        {
            if (userId == null || token == null) return BadRequest();

            AppUser user = await _userManager.FindByIdAsync(userId);

            if (user is null) return BadRequest();


            await _userManager.ConfirmEmailAsync(user, token);

            await _signInManager.SignInAsync(user, false);

            return RedirectToAction("Index", "Home");
        }
        #endregion



        #region logout
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("index", "home");

        }
        #endregion



        #region Login
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid) return View(loginVM);

            AppUser user = await _userManager.FindByEmailAsync(loginVM.UserNameOrEmail);
            if (user is null)
            {
                user = await _userManager.FindByNameAsync(loginVM.UserNameOrEmail);

            }

            if (user is null)
            {
                ModelState.AddModelError("", "Email or Password is Wrong");
                return View(loginVM);
            }

            if (!user.IsActivated)
            {
                ModelState.AddModelError("", "Contact with Admin");
                return View(loginVM);
            }

            SignInResult signInResult = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);

            if (!signInResult.Succeeded)
            {
                if (signInResult.IsNotAllowed)
                {
                    ModelState.AddModelError("", "Please Confirm Your Accaunt");
                    return View(loginVM);
                }
                ModelState.AddModelError("", "Email or Password is Wrong");
                return View(loginVM);
            }

            if (User.FindFirstValue(ClaimTypes.Role) == "User")
            {
                return RedirectToAction("Index", "Home");

            }
            else
            {
                return RedirectToAction("Dashboard", "AdminArea");
            }

            return RedirectToAction("Index", "Home");
        }
        #endregion


        #region ForgotPassword
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordVM forgotPasswordVM)
        {
            if (!ModelState.IsValid) return View(forgotPasswordVM);

            var user = await _userManager.FindByEmailAsync(forgotPasswordVM.Email);

            if (user is null)
            {
                ModelState.AddModelError("", "This email hasn't been registrated");
                return View(forgotPasswordVM);
            }

            var message = new MimeMessage();

            message.From.Add(new MailboxAddress("Worldperfumluxury", "Dunyamamadli@gmail.com"));

            message.To.Add(new MailboxAddress(user.FullName, user.Email));
            message.Subject = "Reset Password";

            string emailbody = string.Empty;

            using (StreamReader streamReader = new StreamReader(Path.Combine(_env.WebRootPath, "Templates", "Reset.html")))
            {
                emailbody = streamReader.ReadToEnd();
            }

            string forgotpasswordtoken = await _userManager.GeneratePasswordResetTokenAsync(user);
            string url = Url.Action(nameof(ResetPasswordVM), "Accaunt", new { email = user.Email, Id = user.Id, token = forgotpasswordtoken, }, Request.Scheme);

            emailbody = emailbody.Replace("{{fullname}}", $"{user.FullName}").Replace("{{code}}", $"{url}");

            message.Body = new TextPart(TextFormat.Html) { Text = emailbody };

            using var smtp = new SmtpClient();

            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("test.code.asgerov@gmail.com", "testcode007");
            smtp.Send(message);
            smtp.Disconnect(true);
            return View();
        }
        #endregion


        #region Reset Password
        [HttpGet]
        public IActionResult ResetPassword(string email, string token)
        {
            var resetPasswordModel = new ResetPasswordVM { Email = email, Token = token };
            return View(resetPasswordModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM resetPasswordVM)
        {
            if (!ModelState.IsValid) return View(resetPasswordVM);

            var user = await _userManager.FindByEmailAsync(resetPasswordVM.Email);

            if (user is null) return NotFound();

            IdentityResult result = await _userManager.ResetPasswordAsync(user, resetPasswordVM.Token, resetPasswordVM.Password);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(resetPasswordVM);

            }


            return RedirectToAction(nameof(Login));

        }
        #endregion


        //public async Task CreateRole()
        //{
        //    foreach (var role in Enum.GetValues(typeof(Utilites.Helpers.Helper.UserRoles)))
        //    {
        //        if (!await _roleManager.RoleExistsAsync(role.ToString()))
        //        {
        //            await _roleManager.CreateAsync(new IdentityRole { Name = role.ToString() });
        //        }
        //    }
        //}


    }
}
