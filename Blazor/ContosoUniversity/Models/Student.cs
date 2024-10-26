namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public required string LastName { get; set; }
        public required string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //Navigation property
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
