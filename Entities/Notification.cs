﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Notification
    {
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public DateTime Date { get; set; }
    }
}
