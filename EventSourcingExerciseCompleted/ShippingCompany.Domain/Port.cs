using System.Collections.Generic;
using ShippingCompany.Domain.Events;

namespace ShippingCompany.Domain
{
    public class Port
    {

        public Port(string name, Country country)
        {
            Ships = new List<Ship>();
            Cargos = new List<Cargo>();
            Name = name;
            Country = country;
        }

        public string Name { get; }

        public Country Country { get; }

        public IList<Ship> Ships { get; }

        public IList<Cargo> Cargos { get; }

        public void HandleDeparture(DepartureEvent ev)
        {
            Ships.Remove(ev.Ship);
        }

        public void HandleArrival(ArrivalEvent ev)
        {
            Ships.Add(ev.Ship);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}