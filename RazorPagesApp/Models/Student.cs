
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        [RegularExpression(@"^[\p{L}]+$", ErrorMessage = "Use letters only please")]
        public string Name { get; set; }
        [RegularExpression(@"^[\p{L}]+$", ErrorMessage = "Use letters only please")]
        public string Surname { get; set; }

        [Range(1,150, ErrorMessage = "Please enter a correct age")]
        public int Age { get; set; }
    }
}
