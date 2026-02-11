using AirportLockerRental.UI.Actions;
using NUnit.Framework;

namespace AirportLockerRental.Tests
{
    [TestFixture]
    public class LockerManagerTests
    {
        public LockerManager GetLockerManager()
        {
            return new LockerManager();
        }

        [Test]
        public void IsRented_No()
        {
            var mgr = GetLockerManager();
            var result = mgr.IsRented(1);
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsRented_Yes()
        {
            var mgr = GetLockerManager();
            mgr.Lockers[0].RenterName = "Rented";
            var result = mgr.IsRented(1);
            Assert.That(result, Is.True);
        }

        [Test]
        public void EndRental_Success()
        {
            var mgr = GetLockerManager();
            mgr.Lockers[0].RenterName = "Renter";
            mgr.Lockers[0].Contents = "Stuff";
            mgr.EndLockerRental(1);
            Assert.That(mgr.Lockers[0].RenterName, Is.Null);
            Assert.That(mgr.Lockers[0].Contents, Is.Null);
        }
    }
}