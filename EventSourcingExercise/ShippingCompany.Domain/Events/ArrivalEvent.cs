using System;

namespace ShippingCompany.Domain.Events
{
    public class ArrivalEvent : DomainEvent
    {
        public ArrivalEvent(Port port, Ship ship)
        {
            Port = port;
            Ship = ship;
        }

        public Port Port { get; }

        public Ship Ship { get; }

        public override void Process()
        {
            Port.HandleArrival(this);
            Ship.HandleArrival(this);
        }
    }
}