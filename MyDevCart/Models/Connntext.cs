using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace MyDevCart.Models
{
    public class Connntext
    {
        [Required(ErrorMessage = "این فیلد اجباریس")]
        public string Name { get; set; }
        [Required(ErrorMessage = "این فیلد اجباریس")]
        [EmailAddress(ErrorMessage = "ایمیل وارد کن عزیز")]
        public string Email { get; set; }
        public string service { get; set; }
        public string message { get; set; }
    }
}
