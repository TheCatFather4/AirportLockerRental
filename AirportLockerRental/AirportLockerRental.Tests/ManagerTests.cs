using AirportLockerRental.Actions;
using AirportLockerRental.DTOS;
using NUnit.Framework;

namespace AirportLockerRental.Tests
{
    [TestFixture]
    public class ManagerTests
    {
        public LockerContents GetContents()
        {
            return new LockerContents()
            {
                RenterName = "Tester",
                Description = "Testable Things"
            };
        }

        public LockerManager GetManager()
        {
            return new LockerManager();
        }

        [Test]
        public void Rent_Empty_Locker()
        {
            var mgr = GetManager();
            var contents = GetContents();

            bool result = mgr.RentLocker(1, contents);

            Assert.That(result, Is.True);
        }

        [Test]
        public void Rent_Filled_Locker()
        {
            var mgr = GetManager();
            var contents = GetContents();

            mgr.RentLocker(1, contents);
            bool result = mgr.RentLocker(1, contents);

            Assert.That(result, Is.False);
        }
    }
}
