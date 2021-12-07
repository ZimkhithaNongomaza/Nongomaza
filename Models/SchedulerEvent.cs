using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nongomaza.Models
{
    public class SchedulerEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int EventPID { get; set; }
        public string RecType { get; set; }
        public long EventLength { get; set; }
    }
}
