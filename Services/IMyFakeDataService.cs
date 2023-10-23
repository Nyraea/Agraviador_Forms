using Agraviador_Forms.Models;
namespace Agraviador_Forms.Services;


public interface IMyFakeDataService
{
    List<Student> StudentList { get; }
    List<Instructor> InstructorList { get; }
}