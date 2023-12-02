namespace MultiTarget.Tests
{
    public class WeatherTests
    {
        [Fact]
        public async Task Run()
        {
            using var ts = new TestScope();

            var httpClient = ts.CreateClient();
            var result = await httpClient.GetStringAsync("http://localhost/weatherforecast/");

            Assert.NotNull(result);
        }
    }
}
