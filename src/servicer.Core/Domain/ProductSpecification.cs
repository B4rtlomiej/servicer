using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace servicer.Core.Domain
{
    public class ProductSpecification
    {
        public int Id { get; protected set; }

        [Required]
        [StringLength(50)]
        public string Manufacturer { get; protected set; }

        [Required]
        [StringLength(50)]
        public string Series { get; protected set; }

        public ICollection<Note> Notes { get; protected set; }

        public ICollection<Item> Items { get; protected set; }

        protected ProductSpecification()
        {
        }
    }
}
