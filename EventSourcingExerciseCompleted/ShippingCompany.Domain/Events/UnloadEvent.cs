using System;

namespace ShippingCompany.Domain.Events
{
    public class UnloadEvent : DomainEvent
    {
        public UnloadEvent(Ship ship, Cargo cargo)
        {
            Ship = ship;
            Cargo = cargo;
        }

        public Ship Ship { get; }

        public Cargo Cargo { get; }

        public override void Process()
        {
            Ship.HandleUnload(this);
            Cargo.HandleUnload(this);
        }
    }
}