using System;

namespace ShippingCompany.Domain.Events
{
    public abstract class DomainEvent
    {
        protected DomainEvent()
        {
            Occurred = DateTime.Now;
        }

        public DateTime Occurred { get; }

        public bool Initial { get; set; }

        public abstract void Process();
    }
}