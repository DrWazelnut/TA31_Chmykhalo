using Counter.Test;

ParkingCounter counter = new ParkingCounter();
Console.WriteLine("Default time for new ticket: " + counter.RemainingTime + "Is Expired:" + counter.Expired);
counter.AddTime(TimeSpan.FromHours(2));
Console.WriteLine("New remaining time value after adding 2 hours: " + counter.RemainingTime +" Is Expired:"+ counter.Expired);
counter.PassTime(TimeSpan.FromMinutes(30));
Console.WriteLine("New remaining time value after 30 minutes passed: " + counter.RemainingTime+ " Is Expired:" + counter.Expired);
counter.PassTime(TimeSpan.FromDays(1));
Console.WriteLine("New remaining time value after 1 day passed: " + counter.RemainingTime+ " Is Expired:" + counter.Expired);
