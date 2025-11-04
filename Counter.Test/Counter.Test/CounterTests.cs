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
    }
}