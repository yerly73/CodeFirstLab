namespace CodeFirstLab.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName {get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        //Entidad Grade fk
        public int GradeId { get; set; }
        public Nullable<bool> Active { get; set; }

        public Grade? Grade { get; set; }


    }
}
