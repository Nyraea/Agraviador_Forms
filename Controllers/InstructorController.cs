using Microsoft.AspNetCore.Mvc;
using Agraviador_Forms.Models;

namespace Agraviador_Forms.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    FirstName = "Tyrone",LastName = "Tiaga",  Birthday = DateTime.Parse("1992-01-04"), IsTenured = true, SalaryPerHour = 1200, Id = 1
                },
                new Instructor()
                {
                    FirstName = "Johann",LastName = "Yee",  Birthday = DateTime.Parse("1994-08-26"), IsTenured = true, SalaryPerHour = 1200, Id = 2
                }
            };
        public IActionResult Index()
        {

            return View(InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

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
            InstructorList.Add(newInstructor);
            return View("Index", InstructorList);
        }

        [HttpGet]
        public IActionResult EditDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();

        }

        [HttpPost]
        public IActionResult EditDetail(Instructor instructorChange)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == instructorChange.Id);

            if (instructor != null)
            {
                instructor.Id = instructorChange.Id;
                instructor.FirstName = instructorChange.FirstName;
                instructor.LastName = instructorChange.LastName;
                instructor.Email = instructorChange.Email;
                instructor.Status = instructorChange.Status;
                instructor.Birthday = instructorChange.Birthday;
                instructor.SalaryPerHour = instructorChange.SalaryPerHour;
            }
            return View("Index", InstructorList);
        }

    }
}