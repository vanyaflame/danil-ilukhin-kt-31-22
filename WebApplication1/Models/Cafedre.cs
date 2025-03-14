namespace WebApplication1.Models
{
    public class Cafedre
    {
        public int CafedreId { get; set; }

        public string CafedreName { get; set; }

        public int CafedreCreationDate { get; set; }

        public string CafedreMainProfessor { get; set; }

        public int ProfessorId { get; set; }

        public ICollection<Professor> Professor { get; set; }
    }
}
