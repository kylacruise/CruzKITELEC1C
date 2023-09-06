using Microsoft.AspNetCore.Mvc;
using CruzKITELEC1C.Models;
namespace CruzKITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorsList = new List<Instructor>()
        {
            new Instructor()
            {
                InstructorName = "Gabriel Montano", DateHired = DateTime.Now,
                InstructorEmail = "gbmontano@ust.edu.ph", Rank = Rank.Instructor
            },
            new Instructor()
            {
                InstructorName = "Leo Lintag", DateHired = DateTime.Parse("25/2/2000"),
                InstructorEmail = "leolintag@ust.edu.ph", Rank = Rank.AssistProf
            },
            new Instructor()
            {
                InstructorName = "Mark Calina", DateHired = DateTime.Parse("25/3/2000"),
                InstructorEmail = "mcalina@ust.edu.ph", Rank = Rank.Prof
            },
        };
        public IActionResult Index()
        {
            return View(InstructorsList);
        }
    }
}
