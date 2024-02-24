using System.ComponentModel.DataAnnotations;

namespace NewStudentWeb.Models
{
    public class Student
    {
        [Key]
        public int Unicode { get; set;}
        public string Name { get; set;}
        public string Email { get; set;}
        public DateOnly Date_birth { get; set;}
    }
}
