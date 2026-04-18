using AirportLockerRental.UI.Actions;
using AirportLockerRental.UI.DTOs;
using NUnit.Framework;

namespace AirportLockerRental.Tests
{
    [TestFixture]
    public class LockerManagerTests
    {
        private LockerManager? _mgr;

        [SetUp]
        public void SetUpLockerManager()
        {
            _mgr = new LockerManager();
        }

        [Test]
        public void EndRental_Success()
        {
            _mgr.Lockers[0].RenterName = "Renter";
            _mgr.Lockers[0].Contents = "Stuff";
            _mgr.EndLockerRental(1);
            Assert.That(_mgr.Lockers[0].RenterName, Is.Null);
            Assert.That(_mgr.Lockers[0].Contents, Is.Null);
        }

        [Test]
        public void IsRented_No()
        {
            var result = _mgr.IsRented(1);
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsRented_Yes()
        {
            _mgr.Lockers[0].RenterName = "Rented";
            var result = _mgr.IsRented(1);
            Assert.That(result, Is.True);
        }

        [Test]
        public void RentLocker_Success()
        {
            var locker = new Locker
            {
                RenterName = "Renter",
                Contents = "Stuff"
            };

            _mgr.RentLocker(1, locker);

            Assert.That(_mgr.Lockers[0].RenterName, Is.EqualTo("Renter"));
            Assert.That(_mgr.Lockers[0].Contents, Is.EqualTo("Stuff"));
        }
    }
}