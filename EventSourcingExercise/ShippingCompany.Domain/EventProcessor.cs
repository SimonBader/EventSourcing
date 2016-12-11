using System.Collections.Generic;
using ShippingCompany.Domain.Events;

namespace ShippingCompany.Domain
{
    public class EventProcessor
    {
        public EventProcessor()
        {
            Log = new List<DomainEvent>();
        }

        public IList<DomainEvent> Log { get; }

        public void Process(DomainEvent e)
        {
            e.Process();
            Log.Add(e);
        }
    }
}