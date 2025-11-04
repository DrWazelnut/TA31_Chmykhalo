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
            TimeSpan timetoadd = TimeSpan.FromHours(1);
            TimeSpan expected = TimeSpan.FromHours(1);
            ParkingCounter counter = new ParkingCounter();
            // Act
            counter.AddTime(timetoadd);
            // Assert
            Assert.Equal(expected, counter.RemainingTime);
        }
        [Fact]
        public void AddTime_NegativeTime_ShouldThrowArgumentExeption()
        {
            // Arrange
            TimeSpan timetoadd = TimeSpan.FromHours(-1);
            ParkingCounter counter = new ParkingCounter();
            // Act
            // Assert
            Assert.Throws<ArgumentException>(()=>counter.AddTime(timetoadd));
        }
        [Fact]
        public void PassTime_1hour_ShouldDecreaseRemainingTimeBy1Hour()
        {
            //Arrange
            TimeSpan initialtime = TimeSpan.FromHours(3);
            TimeSpan timepassed = TimeSpan.FromHours(1);
            TimeSpan expected = TimeSpan.FromHours(2);
            ParkingCounter counter = new ParkingCounter();
            //Act
            counter.AddTime(initialtime);
            //Assert
            Assert.Equal(initialtime, counter.RemainingTime);
            //Act
            counter.PassTime(timepassed);
            //Assert
            Assert.Equal(expected, counter.RemainingTime);

        }
    }
}