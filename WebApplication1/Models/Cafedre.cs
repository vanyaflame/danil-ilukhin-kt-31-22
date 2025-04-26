using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Cafedre
    {
        public int CafedreId { get; set; } // Идентификатор кафедры
        public string CafedreName { get; set; } // Название кафедры
        public DateTime CafedreCreationDate { get; set; } // Дата основания
        public string CafedreMainProfessor { get; set; } // Старший преподаватель кафедры
        public int CafedreProfessorsAmount { get; set; }

        public ICollection<Professor> Professors { get; set; } // Связь с профессорами
    }
}
