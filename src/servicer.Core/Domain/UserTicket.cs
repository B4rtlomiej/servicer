using System;
using System.Collections.Generic;
using System.Text;

namespace servicer.Core.Domain
{
    public class UserTicket
    {
        public User User { get; protected set; }

        public int UserId { get; protected set; }

        public Ticket Ticket { get; protected set; }

        public int TicketId { get; protected set; }
    }
}
