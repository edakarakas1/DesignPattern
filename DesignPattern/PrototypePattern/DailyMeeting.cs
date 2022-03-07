using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class DailyMeeting : Meeting
    {
        public override Meeting Clone()
        {
            return (Meeting)this.MemberwiseClone();
          
        }
    }
}
