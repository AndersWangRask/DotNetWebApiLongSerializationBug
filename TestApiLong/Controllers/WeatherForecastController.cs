using Microsoft.AspNetCore.Mvc;

namespace TestApiLong.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public class TestModel
        {
            public long negLongId { get; set; }
            public long posLongId { get; set; }
            public int intId { get; set; }
        }

        [HttpGet("testids")]
        public TestModel GetTestIds()
        {
            return
                new TestModel
                {
                    negLongId = -9223372036854773407,
                    posLongId = 9223372036854773406,
                    intId = -2147483648
                };
        }
    }
}