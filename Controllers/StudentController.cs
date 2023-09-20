using Microsoft.AspNetCore.Mvc;
using CruzKITELEC1C.Models;

namespace CruzKITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Kyla", LastName = "Cruz",
                    Course = Course.BSIT, AdmissionDate = DateTime.Parse("2021-08-26"),
                    GPA = 1.5, Email = "kylamarielle.cruz.cics@ust.edu.ph"
                },
                new Student()
                {
                    Id= 2,FirstName = "Joshua",LastName = "Garcia",
                    Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-07"),
                    GPA = 1, Email = "joshua.garcia.cics@ust.edu.ph"
                },
                new Student()
                {
                    Id= 3,FirstName = "David",LastName = "Licauco",
                    Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-01-25"),
                    GPA = 1.5, Email = "david.licauco.cics@ust.edu.ph"
                },
                new Student()
                {
                    Id= 4,FirstName = "Neil",LastName = "Gallego",
                    Course = Course.OTHER, AdmissionDate = DateTime.Parse("2021-08-09"),
                    GPA = 1, Email = "neil.gallego.cics@ust.edu.ph"
                }
            };
        public IActionResult Index()
        {

            return View(StudentList);
        }

        public IActionResult ShowDetails(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            StudentList.Add(newStudent);
            return View("Index", StudentList);
        }

        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateStudent(Student studentChanges)
        {
            Student? student = StudentList.FirstOrDefault(st => st.Id == studentChanges.Id);
            if(student != null)
            {
                student.FirstName = studentChanges.FirstName;
                student.LastName = studentChanges.LastName;
                student.Email = studentChanges.Email;
                student.Course = studentChanges.Course;
                student.AdmissionDate = studentChanges.AdmissionDate;
                student.GPA = studentChanges.GPA;
            }
            return View("Index", StudentList);
        }
    }
}
