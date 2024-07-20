using HelloProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HelloProject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login(string? userName, string? passWord)
        {
            if (userName == null || passWord == null)
                return View();
            else
            {
                var rs = checkLogin(userName, passWord);
                LoginViewModel model = new LoginViewModel();
                if (rs)
                    return RedirectToAction("Index", "Home");
                else
                    model.Message = "Tên đăng nhập hoặc mật khẩu không chính xác";
                return View(model);
            }  
        }
        bool checkLogin(string? userName, string? passWord)
        {
            if (userName == null || passWord == null)
                return false;

            if (userName == "admin" && passWord == "123")
                return true;
            else
                return false;
        }
    }
}
