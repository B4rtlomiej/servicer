using System.Collections.Generic;

namespace servicer.Core.Domain
{
    public class Customer
    {
        public int Id { get; protected set; }

        public Person Person { get; protected set; }

        public SupportLevel SupportLevel { get; protected set; }

        public ICollection<Note> Notes { get; protected set; }

        public ICollection<Item> Items { get; protected set; }

        protected Customer()
        {
        }
    }
}