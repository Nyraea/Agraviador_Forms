using Microsoft.AspNetCore.Mvc;
using Agraviador_Forms.Models;

namespace Agraviador_Forms.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
            {
                new Student()
                {
                    FirstName = "Maria",LastName = "Edang", AdmissionDate = DateTime.Parse("1992-01-04"), Course = Course.IT ,Id = 1, PrelimGrade = 95, FinalGrade = 90
                },
                new Student()
                {
                    FirstName = "Jobert",LastName = "Magtamo",  AdmissionDate = DateTime.Parse("1994-08-26"),  Course = Course.Nursing, Id = 2, PrelimGrade = 89, FinalGrade = 94
                },
                new Student()
                {
                    FirstName = "Sinturon",LastName = "Dela Cruz", AdmissionDate = DateTime.Parse("1997-04-16"),  Course = Course.OrgComm, Id = 3, PrelimGrade = 97, FinalGrade = 87
                }
            };
        public IActionResult Index()
        {

            return View(StudentList);
        }

        public IActionResult ShowDetail(int id)
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
        public IActionResult EditDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();

        }

        [HttpPost]
        public IActionResult EditDetail(Student studentChange)
        {
            Student? student = StudentList.FirstOrDefault(st => st.Id == studentChange.Id);

            if(student != null)
            {
                student.Id = studentChange.Id;
                student.FirstName = studentChange.FirstName;
                student.LastName = studentChange.LastName;
                student.Email = studentChange.Email;
                student.Course = studentChange.Course;
                student.AdmissionDate = studentChange.AdmissionDate;
            }
            return View("Index", StudentList);
        }

    }
}