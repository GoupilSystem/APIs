using System;
using Xunit;
using API0.Controllers;

namespace API0.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController(null);
        
        [Fact] void GetReturn()
        {
            var returnValue = controller.Get(10).Value;
            Assert.Equal("11", returnValue);
        }

        [Fact] void Test1()
        {

        }
    }
}
