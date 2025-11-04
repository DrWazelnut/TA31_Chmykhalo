namespace Counter.Test
{
    public class ParkingCounter
    {
        private TimeSpan _remainingTime;
        public TimeSpan RemainingTime=> _remainingTime;
        public bool Expired => _remainingTime <= TimeSpan.Zero;

        public void AddTime(TimeSpan timeSpan)
        {
            if (timeSpan < TimeSpan.Zero) 
            {
                throw new ArgumentException("Negative values are prohibited");
            }
            _remainingTime += timeSpan;
        }

        public void PassTime(TimeSpan timepassed)
        {
            if (timepassed < TimeSpan.Zero)
            {
                throw new ArgumentException("Negative values are prohibited");
            }
            _remainingTime -= timepassed;
        }
    }
}