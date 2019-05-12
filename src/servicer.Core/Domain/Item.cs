using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace servicer.Core.Domain
{
    public class Item
    {
        public int Id { get; protected set; }

        [Required, StringLength(100)]
        public string Name { get; protected set; }

        [Required, StringLength(50)]
        public string Manufacturer { get; protected set; }

        public DateTime ProductionYear { get; protected set; }

        public ProductSpecification ProductSpecification { get; protected set; }

        public int ProductSpecificationId { get; protected set; }

        public Customer Customer { get; protected set; }

        public int CustomerId { get; protected set; }

        public ICollection<Ticket> Tickets { get; protected set; }


        protected Item()
        {
        }
    }
}
