namespace WebApplication1.Models
{
    public class WorkTime
    {
        public int WorkTimeId { get; set; }

        public int WorkTimeHours { get; set; }

        public int ProfessorId { get; set; }

        public ICollection<Professor> Professor { get; set; }

        public int CafedreId { get; set; }

        public ICollection<Cafedre> Cafedre { get; set; }

        public int DisciplineId { get; set; }

        public ICollection<Discipline> Discipline { get; set; }
    }
}
