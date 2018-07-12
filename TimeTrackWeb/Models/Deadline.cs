using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace TimeTrackWeb.Models
{
    public class Deadline
    {
        public DateTime Time { get; set; }
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
    }
}
