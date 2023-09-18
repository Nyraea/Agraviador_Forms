namespace Agraviador_Forms.Models
{
    public enum Course
    {
        IT, Nursing, OrgComm
    }

    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Course Course { get; set; }
        public DateTime AdmissionDate { get; set; }
        public int PrelimGrade { get; set; }
        public int FinalGrade { get; set; }
        public int SemestralGrade { get; set; }
    }
}

