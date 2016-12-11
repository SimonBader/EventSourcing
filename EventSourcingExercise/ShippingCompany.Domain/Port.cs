using ShippingCompany.Domain.Events;

namespace ShippingCompany.Domain
{
    public class Port
    {

        public Port(string name, Country country)
        {
            Name = name;
            Country = country;
        }

        public string Name { get; }

        public Country Country { get; }

        public void HandleDeparture(DepartureEvent ev)
        {
        }

        public void HandleArrival(ArrivalEvent ev)
        {
        }
    }
}