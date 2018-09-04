using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace easy_tickets.DataModels
{
    public class Show
    {
        public int ShowID { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }

        public ICollection<ShowAct> ShowActs { get; set; }

        public int LocationID { get; set; }
        public virtual Location Location { get; set; }

    }
}
