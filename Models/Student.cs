using System.ComponentModel.DataAnnotations;

namespace CruzKITELEC1C.Models
{
    public enum Course
    {
        BSIT, BSCS, BSIC
    }
    public class Student
    { 
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime DateEnrolled { get; set; }
        public Course Course { get; set; }
        public string Email { get; set; }
    }
}
