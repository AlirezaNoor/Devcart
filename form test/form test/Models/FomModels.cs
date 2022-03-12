using System.Buffers;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace form_test.Models
{
    public class FomModels
    {
        [Required(ErrorMessage ="فیلد خای است" )]
        public string Email { get; set; }
        [Required(ErrorMessage = "فیلد خای است")]
        public string pasword { get; set; }
        [Required(ErrorMessage = "فیلد خای است")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "فیلد خای است")]
        public string secondAddress { get; set; }
        [Required(ErrorMessage = "فیلد خای است")]
        public string city { get; set; }
        [Required(ErrorMessage = "فیلد خای است")]
        public string state { get; set; }
    }

}
