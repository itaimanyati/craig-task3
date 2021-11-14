using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Module
    {
        public int Id { get; set; }

      
        public int UserId { get; set; }

        public string Name { get; set; }

        public int Credits { get; set; }

        public int HoursPerWeek { get; set; }

        [NotMapped]
        public int SelfStudyHours { get; set; }

    }
}
