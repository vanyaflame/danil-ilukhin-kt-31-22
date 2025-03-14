namespace WebApplication1.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }

        public string ProfessorFirstName { get; set; }

        public string ProfessorLastName { get; set; }

        public string ProfessorMiddleName { get; set; }

        public string ProfessorTitle { get; set; }

        public int CafedreId { get; set; }

        public Cafedre Cafedre { get; set; }
    }
}
