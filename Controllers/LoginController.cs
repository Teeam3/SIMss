// LoginController.cs

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SIMss.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class LoginController : Controller
{
    private List<RegistrationModel> registrations;

    public LoginController()
    {
        // Load dữ liệu từ tệp registrations.json khi khởi tạo
        string jsonData = System.IO.File.ReadAllText("Registrations.json");
        registrations = JsonConvert.DeserializeObject<List<RegistrationModel>>(jsonData);
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View(); // Trả về view để hiển thị form đăng nhập
    }

    [HttpPost]
    public IActionResult Login(LoginModel model)
    {
        if (ModelState.IsValid)
        {
            // Xác thực thông tin đăng nhập
            var user = registrations.FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);
            if (user != null)
            {
                // Đăng nhập thành công, chuyển hướng đến view "RegisterSuccess.cshtml"
                return RedirectToAction("RegisterSuccess", "Registration");
            }
            else
            {
                // Xử lý trường hợp đăng nhập không thành công, hiển thị lại form đăng nhập với thông báo lỗi
                ModelState.AddModelError(string.Empty, "Email hoặc mật khẩu không chính xác.");
                return View(model);
            }
        }
        else
        {
            // Trường hợp ModelState không hợp lệ, hiển thị lại form đăng nhập với thông báo lỗi
            return View(model);
        }
    }
}
