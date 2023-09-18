namespace Agraviador_Forms.Models
{
    public enum Status
    {
        Probationary, Permanent
    }

    public class Instructor
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public bool IsTenured { get; set; }
        public int SalaryPerHour { get; set; }
        public Status Status { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
    }
}

