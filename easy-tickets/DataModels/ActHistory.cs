using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace easy_tickets.DataModels
{
    public class ActStarted
    {
        public int ActID { get; set; }
        public string Name { get; set; }
        public string StartedLocation { get; set; }
        public DateTime StartTime { get; set; }

        public override string ToString()
        {
            return $"Act {Name} was formed in {StartedLocation} on {StartTime.ToShortDateString()}.";
        }
    }

    public class ActVisited
    {
        public Guid ID { get; set; }
        public int ActID { get; set; }
        public string Name { get; set; }
        public DateTime VisitTime { get; set; }
    }

    public class ActDissolved
    {
        public int ActID { get; set; }
        public string Name { get; set; }
        public string DissolvedLocation { get; set; }
        public DateTime DissolvedTime { get; set; }
        public string DissolvedReason { get; set; }

        public override string ToString()
        {
            return $"Act {Name} was dissolved in {DissolvedLocation} on {DissolvedTime.ToShortDateString()}. The reason was {DissolvedReason}. ";
        }

    }
}
