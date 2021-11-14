using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StudyHours
    {
        public int Id { get; set; }

        [ForeignKey("Module")]
        public int ModuleId { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }
    }
}
