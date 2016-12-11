using System;

namespace ShippingCompany.Domain.Events
{
    public class LoadEvent : DomainEvent
    {
        public LoadEvent(Ship ship, Cargo cargo)
        {
            Ship = ship;
            Cargo = cargo;
        }

        public Ship Ship { get; }

        public Cargo Cargo { get; }

        public override void Process()
        {
            Ship.HandleLoad(this);
            Cargo.HandleLoad(this);
        }
    }
}
