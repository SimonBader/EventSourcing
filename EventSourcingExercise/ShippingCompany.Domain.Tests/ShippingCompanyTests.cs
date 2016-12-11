using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShippingCompany.Domain.Events;

namespace ShippingCompany.Domain.Tests
{
    [TestClass]
    public class ShippingCompanyTests
    {
        private Ship _albatross, _queenMary, _endeavor, _helvetia;
        private Port _hamburg, _sanFrancisco, _rotterdam, _basel;
        private Cargo _kohle, _stahl, _gold;
        private EventProcessor _processor;

        /// <summary>
        /// - Basel
        ///     - Helvetia
        ///         - Gold
        /// - Hamburg
        ///     - Endeavor
        ///     - Queen Mary
        ///     - Albatross
        ///         - Stahl
        ///         - Kohle
        /// - Amsterdam
        /// - San Francisco
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            _processor = new EventProcessor();
            _kohle = new Cargo("Kohle");
            _stahl = new Cargo("Stahl");
            _gold = new Cargo("Gold");
            _albatross = new Ship("Albatross");
            _queenMary = new Ship("Queen Mary");
            _endeavor = new Ship("Endeavor");
            _helvetia = new Ship("Helvetia");
            _hamburg = new Port("Hamburg", Country.Germany);
            _basel = new Port("Basel", Country.Switzerland);
            _sanFrancisco = new Port("San Francisco", Country.UnitedStates);
            _rotterdam = new Port("Rotterdam", Country.Nederlands);

            _processor.Process(new ArrivalEvent(_basel, _helvetia));
            _processor.Process(new ArrivalEvent(_hamburg, _albatross));
            _processor.Process(new ArrivalEvent(_hamburg, _queenMary));
            _processor.Process(new ArrivalEvent(_hamburg, _endeavor));

            _processor.Process(new LoadEvent(_helvetia, _gold));
            _processor.Process(new LoadEvent(_albatross, _kohle));
            _processor.Process(new LoadEvent(_albatross, _stahl));
        }

        [TestMethod]
        public void GetGoldToSanFranciscoTest()
        {
        }
    }
}
