using Microsoft.AspNetCore.Mvc;
using user_registration.Models;

namespace user_registration.Controllers
{
    public class AccountController : Controller
    {
       
            private readonly UserDbcontext _context;

            public AccountController(UserDbcontext context)
            {
                _context = context;
            }







        public IActionResult Register()
        {
            return View(new UserViewModel());  
        }

        
        [HttpPost]
        public IActionResult Register(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    Username = userViewModel.Username,
                    Email = userViewModel.Email,
                    Password = userViewModel.Password
                };

                _context.Users.Add(user);
                _context.SaveChanges();

                return RedirectToAction("Login");
            }

            return View(userViewModel);  
        }

        public IActionResult Welcome()
        {
            return View();  
        }

        //login
        public IActionResult Login()
             {
                   return View();
             }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _context.Users.SingleOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                return RedirectToAction("Welcome");
            }

            ViewData["ErrorMessage"] = "User does't exist or login  are incorrect.";


            return View();
        }


    }
}
