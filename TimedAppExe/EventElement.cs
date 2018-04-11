using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimedAppExe
{
    class EventElement
    {
        public int ID { get; set; }

        public String Name { get; set; }

        // Really String? Nope
        public String StartTimeStamp { get; set; }

        public String EndTimeStamp { get; set; }
    }
}
