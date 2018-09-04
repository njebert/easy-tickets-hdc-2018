using easy_tickets.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace easy_tickets.Models
{
    public class ShowDetails
    {
        public DateTime ShowDate { get; set; }
        public string ShowName { get; set; }
        public List<Act> Acts { get; set; }

        public ShowDetails()
        {
        }

        public ShowDetails(Show show, List<Act> acts)
        {
            Acts = new List<Act>();

            ShowDate = show.Date;
            ShowName = show.Name;

            foreach (Act _act in acts)
            {
                Acts.Add(_act);
            }
        }
    }
}
