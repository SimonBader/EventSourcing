using System;
using ShippingCompany.Domain.Events;

namespace ShippingCompany.Domain
{
    public class Cargo
    {
        public Cargo(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public Port Port { get; private set; }

        public Ship Ship { get; private set; }

        public void HandleLoad(LoadEvent ev)
        {
            Port = null;
            Ship = ev.Ship;
        }

        public void HandleUnload(UnloadEvent ev)
        {
            Port = ev.Ship.Port;
            Ship = null;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}