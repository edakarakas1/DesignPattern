using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    abstract class Meeting
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; }
        public List<string> Participants { get; set; }
        public List<string> Metarials { get; set; }
        public object Summary { get; set; }
        public abstract Meeting Clone();
    }
}
