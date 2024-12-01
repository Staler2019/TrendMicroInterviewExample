using FullStackedInterview;
using FullStackedInterview.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace FullStackedInterviewTest;

public class WeatherForecastTest
{
    [Fact]
    public void Get_IsLength5_WithTypeIEnumerableWeatherForecast()
    {
        // Arrange
        var loggerDi = new Logger<WeatherForecastController>(new NullLoggerFactory());
        var controller = new WeatherForecastController(loggerDi);

        // Act
        var result = controller.Get();

        // Assert
        Assert.IsAssignableFrom<IEnumerable<WeatherForecast>>(result);
        Assert.Equal(5, result.Count());
    }
}
