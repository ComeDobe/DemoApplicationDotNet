using System.ComponentModel.DataAnnotations;

namespace DemoApplication.Models
{
    public class Student
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection <Course> Courses { get; set; }
    }
}
