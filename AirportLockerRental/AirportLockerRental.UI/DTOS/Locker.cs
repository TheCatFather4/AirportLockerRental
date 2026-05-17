namespace AirportLockerRental.UI.DTOs
{
    /// <summary>
    /// Represents a Locker that contains the renter's name and locker contents.
    /// </summary>
    public class Locker
    {
        /// <summary>
        /// Gets or sets the renter's name.
        /// </summary>
        public string? RenterName { get; set; }

        /// <summary>
        /// Gets or sets the locker's contents.
        /// </summary>
        public string? Contents { get; set; }
    }
}