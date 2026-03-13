namespace AirportLockerRental.UI.DTOs
{
    /// <summary>
    /// Used to retrieve and assign renter information concerning a locker.
    /// </summary>
    public class Locker
    {
        public string? RenterName { get; set; }
        public string? Contents { get; set; }
    }
}