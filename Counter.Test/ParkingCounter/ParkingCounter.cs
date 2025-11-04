namespace Counter.Test
{
    public class ParkingCounter
    {
        private TimeSpan _remainingTime;
        public TimeSpan RemainingTime=> _remainingTime;
        public bool Expired => _remainingTime <= TimeSpan.Zero;

        public void AddTime(TimeSpan timeSpan)
        {
            _remainingTime += timeSpan;
        }
    }
}