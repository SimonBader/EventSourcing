using ShippingCompany.Domain.Events;

namespace ShippingCompany.Domain
{
    public class Ship
    {
        public Ship(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void HandleDeparture(DepartureEvent ev)
        {
        }

        public void HandleArrival(ArrivalEvent ev)
        {
        }

        public void HandleLoad(LoadEvent ev)
        {
        }

        public void HandleUnload(UnloadEvent ev)
        {
        }
    }
}