using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Semester
    {
        public int Id { get; set; }
        public int NumberOfWeeks { get; set; }
        public DateTime StartDate { get; set; }
    }
}
