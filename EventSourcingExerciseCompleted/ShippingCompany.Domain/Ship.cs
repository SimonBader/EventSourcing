using System;
using System.Collections.Generic;
using ShippingCompany.Domain.Events;

namespace ShippingCompany.Domain
{
    public class Ship
    {
        public Ship(string name)
        {
            Name = name;
            Cargos = new List<Cargo>();
        }

        public string Name { get; }

        public Port Port { get; private set; }

        public IList<Cargo> Cargos { get; }

        public void HandleDeparture(DepartureEvent ev)
        {
            if (!ev.Initial && ev.Port != Port)
            {
                throw new NotSupportedException();
            }

            Port = null;
        }

        public void HandleArrival(ArrivalEvent ev)
        {
            if (Port != null)
            {
                throw new NotSupportedException();
            }

            Port = ev.Port;
        }

        public void HandleLoad(LoadEvent ev)
        {
            if (Port == null)
            {
                throw new NotSupportedException();
            }

            if (!ev.Initial && !Port.Cargos.Contains(ev.Cargo))
            {
                throw new NotSupportedException();
            }

            Port.Cargos.Remove(ev.Cargo);
            Cargos.Add(ev.Cargo);
        }

        public void HandleUnload(UnloadEvent ev)
        {
            Cargos.Remove(ev.Cargo);
            Port.Cargos.Add(ev.Cargo);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}