namespace MultiTarget.Tests
{
    public class SampleTests
    {
        [Fact]
        public async Task Run()
        {
            using var ts = new TestScope();

            var httpClient = ts.CreateClient();
            var result = await httpClient.GetStringAsync("http://localhost/sample/");
#if NET8_0_OR_GREATER
            Assert.Equal("Running on .NET8", result);
#else
            Assert.Equal("Running on .NET7", result);
#endif
        }
    }
}
