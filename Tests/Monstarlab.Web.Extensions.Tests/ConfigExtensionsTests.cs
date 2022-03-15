namespace Monstarlab.Web.Extensions.Tests;

public class ConfigExtensionsTests
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private IServiceCollection _serviceCollection;
    private IConfiguration _configuration;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private const string _configStringValue = "Hello I'm a string";
    private const int _configIntValue = 42;

    [SetUp]
    public void Setup()
    {
        var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json");

        _configuration = builder.Build();

        _serviceCollection = new ServiceCollection();
    }

    [Test]
    public void AddConfig()
    {
        var section = _configuration.GetSection("Test");


        _serviceCollection.AddConfig<TestConfig>(section);
        var services = _serviceCollection.BuildServiceProvider();


        var configuration = services.GetRequiredService<TestConfig>();
        Assert.AreEqual(_configIntValue, configuration.IntValue);
        Assert.AreEqual(_configStringValue, configuration.StringValue);
    }
}
