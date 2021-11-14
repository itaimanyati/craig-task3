using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Session
    {
        private static Session instance;
        private Session()
        {

        }

        public static Session Instance
        {
            get { return instance; }
        }

        public static int userId { get; set; }
    }
}
