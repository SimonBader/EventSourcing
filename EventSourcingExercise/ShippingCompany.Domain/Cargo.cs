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

        public void HandleLoad(LoadEvent ev)
        {
        }

        public void HandleUnload(UnloadEvent ev)
        {
        }
    }
}