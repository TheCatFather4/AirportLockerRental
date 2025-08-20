using AirportLockerRental.DTOS;

namespace AirportLockerRental.Actions
{
    public class LockerManager
    {
        private LockerContents[] _lockers = new LockerContents[100];

        public LockerContents GetLockerContents(int number)
        {
            return _lockers[number - 1];
        }

        public bool IsAvailable(int number)
        {
            return _lockers[number - 1] == null;
        }

        public bool RentLocker(int number, LockerContents contents)
        {
            if (_lockers[number - 1] == null)
            {
                _lockers[number - 1] = contents;
                return true;
            }
            else 
            {
                return false;
            }
        }

        public LockerContents ReturnLocker(int number)
        {
            return _lockers[number - 1] = null;
        }

        public void ViewAllLockers()
        {
            for (int i = 0; i < _lockers.Length; i++)
            {
                if (_lockers[i] != null)
                {
                    ConsoleIO.PrintLockerContents(i + 1, _lockers[i]);
                }
            }
        }
    }
}
