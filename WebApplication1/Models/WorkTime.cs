namespace WebApplication1.Models
{
    public class WorkTime
    {
        public int WorkTimeId { get; set; }

        public int WorkTimeHours { get; set; }

        public int ProfessorId { get; set; }

        public Professor Professor { get; set; }

        public int CafedreId { get; set; }

        public Cafedre Cafedre { get; set; }

        public int DisciplineId { get; set; }

        public Discipline Discipline { get; set; }
    }
}
