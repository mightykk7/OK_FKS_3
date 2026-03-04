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
        [Fact]
        public void CalculatePrice_5()
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
        public void CalculatePrice_6Age()
        {
            TicketRequest request = new TicketRequest
            {
                Age = 6,
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
        public void CalculatePrice_17Age()
        {
            TicketRequest request = new TicketRequest
            {
                Age = 17,
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
        public void CalculatePrice_18Age()
        {
            TicketRequest request = new TicketRequest
            {
                Age = 18,
                IsStudent = false,
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
        public void CalculatePrice_25Age()
        {
            TicketRequest request = new TicketRequest
            {
                Age = 25,
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
        public void CalculatePrice_26Age()
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
        public void CalculatePrice_64Age()
        {
            TicketRequest request = new TicketRequest
            {
                Age = 64,
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
        public void CalculatePrice_65Age()
        {
            TicketRequest request = new TicketRequest
            {
                Age = 65,
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
        public void CalculatePrice_LessThan0_MoreThan120(int age)
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
