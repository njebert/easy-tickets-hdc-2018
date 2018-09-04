using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace easy_tickets.DataModels
{
    public class ShowAct
    {
        public int ShowID { get; set; }
        public Show Show { get; set; }
        public int ActID { get; set; }
        public Act Act { get; set; }
    }
}
