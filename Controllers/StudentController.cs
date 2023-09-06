using Microsoft.AspNetCore.Mvc;
using CruzKITELEC1C.Models;

namespace CruzKITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student st = new Student();
                st.StudentId = 1;
                st.StudentName = "Kyla Marielle Cruz";
                st.DateEnrolled = DateTime.Parse("30/8/2023");
                st.Course = Course.BSIT;
                st.Email = "kylamarielle.cruz.cics@ust.edu.ph";

            ViewBag.Student = st;
            return View();
        }
    }
}
