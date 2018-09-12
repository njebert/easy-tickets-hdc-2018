using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace easy_tickets.DataModels
{
    public class Ticket
    {
        public Ticket() { }
        public Guid Id { get; set; }
        public string Section { get; set; }
        public decimal Price { get; set; }
        public string Owner { get; set; }
        public DateTime PurchaseDate { get; set; }
    }

    public class GATicket : Ticket
    {
        public GATicket() { }
    }

    public class VIPTicket : Ticket
    {
        public VIPTicket() { }

        public DateTime MeetAndGreetTime { get; set; }

    }
}
