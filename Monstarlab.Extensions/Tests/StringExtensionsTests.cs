namespace Monstarlab.Extensions.Tests;

public class Tests
{
    [Test]
    public void ToNullableEnumParseSuccess1()
    {
        const string valueToParse = "FirstValue";


        var parsedValue = valueToParse.ToNullableEnum<TestEnum>();


        Assert.AreEqual(TestEnum.FirstValue, parsedValue);
    }

    [Test]
    public void ToNullableEnumParseSuccess2()
    {
        const string valueToParse = "ThirdValue";


        var parsedValue = valueToParse.ToNullableEnum<TestEnum>();


        Assert.AreEqual(TestEnum.ThirdValue, parsedValue);
    }

    [Test]
    public void ToNullableEnumParseRandomString()
    {
        const string valueToParse = "I'm a random string";


        var parsedValue = valueToParse.ToNullableEnum<TestEnum>();


        Assert.IsNull(parsedValue);
    }

    [Test]
    public void ToNullableEnumParseNullString()
    {
        const string? valueToParse = null;


#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        var parsedValue = valueToParse.ToNullableEnum<TestEnum>();
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.


        Assert.IsNull(parsedValue);
    }

    [Test]
    public void ToEnumParseSuccess1()
    {
        const string valueToParse = "FirstValue";


        var parsedValue = valueToParse.ToEnum(TestEnum.RandomValue);


        Assert.AreEqual(TestEnum.FirstValue, parsedValue);
    }

    [Test]
    public void ToEnumParseSuccess2()
    {
        const string valueToParse = "ThirdValue";


        var parsedValue = valueToParse.ToEnum(TestEnum.RandomValue);


        Assert.AreEqual(TestEnum.ThirdValue, parsedValue);
    }

    [Test]
    public void ToEnumParseRandomString()
    {
        const string valueToParse = "I'm a random string";


        var parsedValue = valueToParse.ToEnum(TestEnum.RandomValue);


        Assert.AreEqual(TestEnum.RandomValue, parsedValue);
    }

    [Test]
    public void ToEnumParseNullString()
    {
        const string? valueToParse = null;


#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        var parsedValue = valueToParse.ToEnum(TestEnum.RandomValue);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.


        Assert.AreEqual(TestEnum.RandomValue, parsedValue);
    }
}
