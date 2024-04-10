using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SIMss.Models;
using System.Diagnostics;

namespace SIMss.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ActionResult edit()
        {
            return View("~/Views/Shared/edituser.cshtml");
        }
        public ActionResult save()
        {
            return View("~/Views/Shared/RegisterSuccess.cshtml");
        }
        // Action để hiển thị trang đăng nhập
        public ActionResult login()
        {
            return View("~/Views/Shared/login.cshtml");
        }
        public ActionResult signup()
        {
            return View("~/Views/Shared/signup.cshtml");
        }






        public ActionResult testteacher()
        {
            return View("~/Views/Shared/teacher.cshtml");
        }
        public ActionResult testcourse()
        {
            return View("~/Views/Shared/course.cshtml");
        }
        public ActionResult teststudent()
        {
            return View("~/Views/Shared/student.cshtml");
        }
        public ActionResult testupdate()
        {
            return View("~/Views/Shared/update.cshtml");
        }
        public ActionResult testdashboard()
        {
            return View("~/Views/Shared/admdash.cshtml");
        }
        public ActionResult testadmaddcourse()
        {
            return View("~/Views/Shared/admaddcourse.cshtml");
        }
        public ActionResult testadmaddteacher()
        {
            return View("~/Views/Shared/admaddteacher.cshtml");
        }
        public ActionResult testadmcourse()
        {
            return View("~/Views/Shared/admcourse.cshtml");
        }
        public ActionResult testadmeditstudent()
        {
            return View("~/Views/Shared/admeditstudent.cshtml");
        }
        public ActionResult testadmeditteacher()
        {
            return View("~/Views/Shared/admeditteacher.cshtml");
        }
        public ActionResult testadmstudent()
        {
            return View("~/Views/Shared/admstudent.cshtml");
        }
        public ActionResult testadmteacher()
        {
            return View("~/Views/Shared/admteacher.cshtml");
        }
        











        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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