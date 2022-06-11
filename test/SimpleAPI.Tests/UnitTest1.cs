using System;
using Xunit;
using SimpleAPi.Controllers;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
 
       
        [Fact]
        public void Test1()
        {
              using var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
     var logger = loggerFactory.CreateLogger<WeatherForecastController>();
 WeatherForecastController controller = new WeatherForecastController( logger);
  var result =controller.Get(1);
  Assert.Equal("jacob", result);
        }


        
    }
}
