namespace Monstarlab.Extensions.Tests;

public class StringExtensionsTests
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
    public void TryParseEnumWithDefaultSuccess1()
    {
        const string valueToParse = "FirstValue";


        var result = valueToParse.TryParseEnum(TestEnum.RandomValue, out var parsedValue);


        Assert.IsTrue(result);
        Assert.AreEqual(TestEnum.FirstValue, parsedValue);
    }

    [Test]
    public void TryParseEnumWithDefaultSuccess2()
    {
        const string valueToParse = "ThirdValue";


        var result = valueToParse.TryParseEnum(TestEnum.RandomValue, out var parsedValue);


        Assert.IsTrue(result);
        Assert.AreEqual(TestEnum.ThirdValue, parsedValue);
    }

    [Test]
    public void TryParseEnumWithDefaultRandomString()
    {
        const string valueToParse = "I'm a random string";


        var result = valueToParse.TryParseEnum(TestEnum.RandomValue, out var parsedValue);


        Assert.IsFalse(result);
        Assert.AreEqual(TestEnum.RandomValue, parsedValue);
    }

    [Test]
    public void TryParseEnumWithDefaultNullString()
    {
        const string? valueToParse = null;


#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        var result = valueToParse.TryParseEnum(TestEnum.RandomValue, out var parsedValue);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.


        Assert.IsFalse(result);
        Assert.AreEqual(TestEnum.RandomValue, parsedValue);
    }

    [Test]
    public void TryParseEnumWithoutDefaultSuccess1()
    {
        const string valueToParse = "FirstValue";


        var result = valueToParse.TryParseEnum<TestEnum>(out var parsedValue);


        Assert.IsTrue(result);
        Assert.AreEqual(TestEnum.FirstValue, parsedValue);
    }

    [Test]
    public void TryParseEnumWithoutDefaultSuccess2()
    {
        const string valueToParse = "ThirdValue";


        var result = valueToParse.TryParseEnum<TestEnum>(out var parsedValue);


        Assert.IsTrue(result);
        Assert.AreEqual(TestEnum.ThirdValue, parsedValue);
    }

    [Test]
    public void TryParseEnumWithoutDefaultRandomString()
    {
        const string valueToParse = "I'm a random string";


        var result = valueToParse.TryParseEnum<TestEnum>(out var parsedValue);


        Assert.IsFalse(result);
        Assert.AreEqual(default(TestEnum), parsedValue);
    }

    [Test]
    public void TryParseEnumWithoutDefaultNullString()
    {
        const string? valueToParse = null;


#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        var result = valueToParse.TryParseEnum<TestEnum>(out var parsedValue);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.


        Assert.IsFalse(result);
        Assert.AreEqual(default(TestEnum), parsedValue);
    }
}
