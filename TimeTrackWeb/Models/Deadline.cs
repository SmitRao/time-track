using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTrackWeb.Models
{
    public class Deadline
    {
        public DateTime Time { get; set; }
        public Guid Id { get; set; }
        public String Name { get; set; }
    }
}
