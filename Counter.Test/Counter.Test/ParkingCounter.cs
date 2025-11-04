namespace Counter.Test
{
    internal class ParkingCounter
    {
        private TimeSpan _remainingTime;
        public TimeSpan RemainingTime=> _remainingTime;
        public bool Expired => _remainingTime <= TimeSpan.Zero;
    }
}