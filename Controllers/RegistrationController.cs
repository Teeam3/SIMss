using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using SIMss.Models; // Import namespace của RegistrationModel
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Diagnostics.Eventing.Reader;
using System.Linq; // Thêm này để sử dụng LINQ

public class RegistrationController : Controller
{
    [HttpPost]
    public IActionResult Register(RegistrationModel model)
    {
        // Đọc dữ liệu từ tệp tin JSON hiện tại (nếu có)
        List<RegistrationModel> registrations = new List<RegistrationModel>();
        if (System.IO.File.Exists("registrations.json"))
        {
            string jsonData = System.IO.File.ReadAllText("registrations.json");
            registrations = JsonConvert.DeserializeObject<List<RegistrationModel>>(jsonData);
        }

        // Tính toán userId mới dựa trên giá trị cao nhất hiện tại
        int maxUserId = registrations.Any() ? registrations.Max(r => r.UserId) : 0;
        model.UserId = maxUserId + 1; // Tăng UserId

        // Thêm dữ liệu mới vào danh sách
        registrations.Add(model);

        // Lưu danh sách dữ liệu vào tệp tin JSON
        string newJsonData = JsonConvert.SerializeObject(registrations, Formatting.Indented);
        System.IO.File.WriteAllText("registrations.json", newJsonData);

        // Sau khi xử lý xong, chuyển hướng đến trang thành công
        return RedirectToAction("RegisterSuccess", "Registration");
    }

    public IActionResult RegisterSuccess()
    {
        // Xử lý khi đăng ký thành công
        return View();
    }
}
