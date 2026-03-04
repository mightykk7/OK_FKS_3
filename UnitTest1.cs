using CinemaTicketSystem;

namespace zad
{
    public class UnitTest1
    {
        [Fact]
        public void CalculatePrice_defoult()
        {
            TicketRequest request = new TicketRequest
            {
                Age = 26,
                IsStudent = false,
                IsVip = false,
                Day = DayOfWeek.Monday,
                SessionTime = new TimeSpan(15, 0, 0),
            };
            decimal price = 300;
            TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();
            decimal actualprice = ticketPriceCalculator.CalculatePrice(request);
            Assert.Equal(price, actualprice);
        }
        [Fact]
        public void CalculatePrice_ShouldReturnZero_ForChildUnder6()
        {
            TicketRequest request = new TicketRequest
            {
                Age = 5,
                IsStudent = false,
                IsVip = false,
                Day = DayOfWeek.Monday,
                SessionTime = new TimeSpan(15, 0, 0),
            };
            decimal price = 0;
            TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();
            decimal actualprice = ticketPriceCalculator.CalculatePrice(request);
            Assert.Equal(price, actualprice);
        }
        [Fact]
        public void CalculatePrice_ShouldReturn180_ForChildUpper6()
        {
            TicketRequest request = new TicketRequest
            {
                Age = 7,
                IsStudent = false,
                IsVip = false,
                Day = DayOfWeek.Monday,
                SessionTime = new TimeSpan(15, 0, 0),
            };
            decimal price = 300 - (300 * 40) / 100;
            TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();
            decimal actualprice = ticketPriceCalculator.CalculatePrice(request);
            Assert.Equal(price, actualprice);
        }
        [Fact]
        public void CalculatePrice_ForStudent()
        {
            TicketRequest request = new TicketRequest
            {
                Age = 20,
                IsStudent = true,
                IsVip = false,
                Day = DayOfWeek.Monday,
                SessionTime = new TimeSpan(15, 0, 0),
            };
            decimal price = 300 - (300 * 20) / 100;
            TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();
            decimal actualprice = ticketPriceCalculator.CalculatePrice(request);
            Assert.Equal(price, actualprice);
        }
        [Fact]
        public void CalculatePrice_ForMorning()
        {
            TicketRequest request = new TicketRequest
            {
                Age = 26,
                IsStudent = false,
                IsVip = false,
                Day = DayOfWeek.Monday,
                SessionTime = new TimeSpan(11, 0, 0),
            };
            decimal price = 300 - (300 * 15) / 100;
            TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();
            decimal actualprice = ticketPriceCalculator.CalculatePrice(request);
            Assert.Equal(price, actualprice);
        }
        [Fact]
        public void CalculatePrice_ForWednesday()
        {
            TicketRequest request = new TicketRequest
            {
                Age = 26,
                IsStudent = false,
                IsVip = false,
                Day = DayOfWeek.Wednesday,
                SessionTime = new TimeSpan(15, 0, 0),
            };
            decimal price = 300 - (300 * 30) / 100;
            TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();
            decimal actualprice = ticketPriceCalculator.CalculatePrice(request);
            Assert.Equal(price, actualprice);
        }
        [Fact]
        public void CalculatePrice_ForVIP()
        {
            TicketRequest request = new TicketRequest
            {
                Age = 26,
                IsStudent = false,
                IsVip = true,
                Day = DayOfWeek.Monday,
                SessionTime = new TimeSpan(15, 0, 0),
            };
            decimal price = 300 + (300 * 100) / 100;
            TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();
            decimal actualprice = ticketPriceCalculator.CalculatePrice(request);
            Assert.Equal(price, actualprice);
        }
        [Fact]
        public void CalculatePrice_ForLotsOfDiscounts()
        {
            TicketRequest request = new TicketRequest
            {
                Age = 5,
                IsStudent = true,
                IsVip = false,
                Day = DayOfWeek.Wednesday,
                SessionTime = new TimeSpan(11, 0, 0),
            };
            decimal price = 300 - (300 * 100) / 100;
            TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();
            decimal actualprice = ticketPriceCalculator.CalculatePrice(request);
            Assert.Equal(price, actualprice);
        }
        [Fact]
        public void CalculatePrice_ForStudent_MaximumDiscount()
        {
            TicketRequest request = new TicketRequest
            {
                Age = 20,
                IsStudent = true,
                IsVip = false,
                Day = DayOfWeek.Wednesday,
                SessionTime = new TimeSpan(15, 0, 0),
            };
            decimal price = 300 - (300 * 30) / 100;
            TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();
            decimal actualprice = ticketPriceCalculator.CalculatePrice(request);
            Assert.Equal(price, actualprice);
        }
    }
    public class UnitTest2
    {
        //[Fact]
        //public void CalculatePrice_defoult()
        //{
        //    TicketRequest request = new TicketRequest
        //    {
        //        Age = 26,
        //        IsStudent = false,
        //        IsVip = false,
        //        Day = DayOfWeek.Monday,
        //        SessionTime = new TimeSpan(15, 0, 0),
        //    };
        //    decimal price = 300;
        //    TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();
        //    decimal actualprice = ticketPriceCalculator.CalculatePrice(request);
        //    Assert.Equal(price, actualprice);
        //}
        [Fact]
        public void CalculatePrice_MinimumAge()
        {
            TicketRequest request = new TicketRequest
            {
                Age = 0,
                IsStudent = false,
                IsVip = false,
                Day = DayOfWeek.Monday,
                SessionTime = new TimeSpan(15, 0, 0),
            };
            decimal price = 300 - (300 * 100) / 100;
            TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();
            decimal actualprice = ticketPriceCalculator.CalculatePrice(request);
            Assert.Equal(price, actualprice);
        }
        [Fact]
        public void CalculatePrice_MaximumAge()
        {
            TicketRequest request = new TicketRequest
            {
                Age = 120,
                IsStudent = false,
                IsVip = false,
                Day = DayOfWeek.Monday,
                SessionTime = new TimeSpan(15, 0, 0),
            };
            decimal price = 300 - (300 * 50) / 100;
            TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();
            decimal actualprice = ticketPriceCalculator.CalculatePrice(request);
            Assert.Equal(price, actualprice);
        }
        [Theory]
        [InlineData(5)]
        [InlineData(6)]
        public void CalculatePrice_5_6Age(int age)
        {
            TicketRequest request = new TicketRequest
            {
                Age = age,
                IsStudent = false,
                IsVip = false,
                Day = DayOfWeek.Monday,
                SessionTime = new TimeSpan(15, 0, 0),
            };
            decimal price = 0;
            TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();
            decimal actualprice = ticketPriceCalculator.CalculatePrice(request);
            Assert.Equal(price, actualprice);
        }
        [Theory]
        [InlineData(17)]
        [InlineData(18)]
        public void CalculatePrice_17_18Age(int age)
        {
            TicketRequest request = new TicketRequest
            {
                Age = age,
                IsStudent = false,
                IsVip = false,
                Day = DayOfWeek.Monday,
                SessionTime = new TimeSpan(15, 0, 0),
            };
            decimal price = 0;
            TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();
            decimal actualprice = ticketPriceCalculator.CalculatePrice(request);
            Assert.Equal(price, actualprice);
        }
        [Theory]
        [InlineData(25)]
        [InlineData(26)]
        public void CalculatePrice_25_26Age(int age)
        {
            TicketRequest request = new TicketRequest
            {
                Age = age,
                IsStudent = false,
                IsVip = false,
                Day = DayOfWeek.Monday,
                SessionTime = new TimeSpan(15, 0, 0),
            };
            decimal price = 0;
            TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();
            decimal actualprice = ticketPriceCalculator.CalculatePrice(request);
            Assert.Equal(price, actualprice);
        }
        [Theory]
        [InlineData(64)]
        [InlineData(66)]
        public void CalculatePrice_64_65Age(int age)
        {
            TicketRequest request = new TicketRequest
            {
                Age = age,
                IsStudent = false,
                IsVip = false,
                Day = DayOfWeek.Monday,
                SessionTime = new TimeSpan(15, 0, 0),
            };
            decimal price = 0;
            TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();
            decimal actualprice = ticketPriceCalculator.CalculatePrice(request);
            Assert.Equal(price, actualprice);
        }
    }
    public class UnitTest3
    {
        [Fact]
        public void CalculatePrice_RequestNull()
        {
            TicketRequest request = null;
            TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();
            Assert.Throws<ArgumentNullException>(() => ticketPriceCalculator.CalculatePrice(request));
        }
        [Theory]
        [InlineData(-1)]
        [InlineData(150)]
        public void CalculatePrice_ArgumentOutOfRangeException_Over_0(int age)
        {
            var request = new TicketRequest
            {
                Age = age,
                IsStudent = false,
                IsVip = false,
                Day = DayOfWeek.Monday,
                SessionTime = new TimeSpan(15, 0, 0)
            };
            TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();
            Assert.Throws<ArgumentOutOfRangeException>(() => ticketPriceCalculator.CalculatePrice(request));
        }
    }
}
