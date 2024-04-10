using System.ComponentModel.DataAnnotations;

namespace SIMss.Models
{
    public class LoginModel
    {
       
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
