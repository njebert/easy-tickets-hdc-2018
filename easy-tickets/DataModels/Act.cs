using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace easy_tickets.DataModels
{
    public class Act
    {
        public int ActID { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }

        public ICollection<ShowAct> ShowActs { get; set; }
    }
}
