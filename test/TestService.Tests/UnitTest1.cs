namespace TestService.Tests;

using Microsoft.AspNetCore.Mvc.Testing;

[TestClass]
public class UnitTest1 
{
    private WebApplicationFactory<Program> _testHost;

    [TestInitialize]
    public void TestInitialize()
    {
        // Create a new WebApplicationFactory with the Program class
        _testHost = new WebApplicationFactory<Program>().WithWebHostBuilder(builder =>
        {
        });
    }

    [TestMethod]
    public async Task TestMethod1()
    {
        var httpClient = _testHost.CreateDefaultClient();
        using var response = await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, "/weatherforecast"));
        Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
    }
}