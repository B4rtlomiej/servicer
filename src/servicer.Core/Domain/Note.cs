using System.ComponentModel.DataAnnotations;

namespace servicer.Core.Domain
{
    public class Note
    {
        public int Id { get; protected set; }

        [Required]
        public string Text { get; protected set; }

        public ProductSpecification ProductSpecification { get; protected set; }

        public int? ProductSpecificationId { get; protected set; }

        public Customer Customer { get; protected set; }

        public int? CustomerId { get; protected set; }

        protected Note()
        {
        }
    }
}
