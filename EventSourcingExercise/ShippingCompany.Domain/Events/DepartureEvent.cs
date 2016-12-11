using System;

namespace ShippingCompany.Domain.Events
{
    public class DepartureEvent : DomainEvent
    {
        public DepartureEvent(Port port, Ship ship)
        {
            Port = port;
            Ship = ship;
        }

        public Port Port { get; }

        public Ship Ship { get; }

        public override void Process()
        {
            Port.HandleDeparture(this);
            Ship.HandleDeparture(this);
        }

    }
}