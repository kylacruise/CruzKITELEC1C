﻿using Microsoft.AspNetCore.Mvc;
using CruzKITELEC1C.Models;
namespace CruzKITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorsList = new List<Instructor>()
        {
            new Instructor()
            {
                InstructorId = 1,
                InstructorFirstName = "Gabriel", InstructorLastName = "Montano", HiringDate = DateTime.Now,
                IsTenured = true, Rank = Rank.Instructor
            },
            new Instructor()
            {
                InstructorId = 2,
                InstructorFirstName = "Leo", InstructorLastName = "Lintag", HiringDate = DateTime.Parse("25/2/2000").Date,
                IsTenured = true, Rank = Rank.AssistantProfessor
            },
            new Instructor()
            {
                InstructorId = 3,
                InstructorFirstName = "Amado", InstructorLastName = "Sapit",  HiringDate = DateTime.Parse("25/3/2000").Date,
                IsTenured = false, Rank = Rank.AssociateProfessor
            },
            new Instructor()
            {
                InstructorId = 4,
                InstructorFirstName = "Bernard", InstructorLastName = "Sanidad", HiringDate = DateTime.Parse("1/1/2015").Date,
                IsTenured = false, Rank = Rank.Professor
            }

        };
        public IActionResult Index()
        {
            return View(InstructorsList);
        }

        public IActionResult ShowDetails(int id)
        {


            Instructor instructor = InstructorsList.FirstOrDefault(t => t.InstructorId == id);
            if (instructor != null)
            {
                return View(instructor);
            }
            return NotFound();
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            InstructorsList.Add(newInstructor);
            return View("Index", InstructorsList);
        }

        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
            Instructor? instructor = InstructorsList.FirstOrDefault(t => t.InstructorId == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateInstructor(Instructor instructorChanges)
        {
            Instructor? instructor = InstructorsList.FirstOrDefault(t => t.InstructorId == instructorChanges.InstructorId);
            if (instructor != null)
            {
                instructor.InstructorFirstName = instructorChanges.InstructorFirstName;
                instructor.InstructorLastName = instructorChanges.InstructorLastName;
                instructor.Rank = instructorChanges.Rank;
                instructor.HiringDate = instructorChanges.HiringDate;
            }
            return View("Index", InstructorsList);
        }
    }
}
