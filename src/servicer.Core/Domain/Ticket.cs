using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace servicer.Core.Domain
{
    public class Ticket
    {
        public int Id { get; protected set; }

        public Origin Origin { get; protected set; }

        public Type Type { get; protected set; }

        public Status Status { get; protected set; }

        public Priority Priority { get; protected set; }

        [Required]
        public DateTime Created { get; protected set; }

        public DateTime Closed { get; protected set; }

        [Required, StringLength(100)]
        public string Subject { get; protected set; }

        [Required]
        public string Description { get; protected set; }

        public ICollection<UserTicket> UserTickets { get; protected set; }

        public Item Item { get; protected set; }

        public int ItemId { get; protected set; }

        protected Ticket()
        {
        }
    }
}
