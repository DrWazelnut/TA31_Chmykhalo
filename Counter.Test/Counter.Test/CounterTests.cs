namespace Counter.Test
{
    public class CounterTests
    {
        [Fact]
        public void Expired_NewTicket_ShouldReturnTrue()
        {
            // Arrange
            bool expected = true;
            ParkingCounter counter = new ParkingCounter();
            // Act
            // Assert
            Assert.Equal(expected, counter.Expired);
        }
        [Fact]
        public void AddTime_1hour_ShouldIncreaseRemainingTimeBy1Hour()
        {
            // Arrange
            TimeSpan expected = TimeSpan.FromHours(1);
            ParkingCounter counter = new ParkingCounter();
            // Act
            counter.AddTime(TimeSpan.FromHours(1));
            // Assert
            Assert.Equal(expected, counter.RemainingTime);
        }
        [Fact]
        public void AddTime_NegativeTime_ShouldThrowArgumentExeption()
        {
            // Arrange
            ParkingCounter counter = new ParkingCounter();
            // Act
            // Assert
            Assert.Throws<ArgumentException>(()=>counter.AddTime(TimeSpan.FromHours(-1)));
        }
    }
}