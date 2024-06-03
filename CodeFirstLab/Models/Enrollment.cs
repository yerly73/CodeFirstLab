namespace CodeFirstLab.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public DateTime date { get; set; }

        //Entidad Grade fk
        public int GradeId { get; set; }

        public Grade Grade { get; set; }

        //Entidad Courses fk
        public int CourseId { get; set; }
        public Course Course { get; set; }

    }
}
