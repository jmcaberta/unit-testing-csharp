using System.Runtime.InteropServices.Marshalling;
using Xunit.Sdk;

namespace StringManipulation.Tests;

public class StringOperationTest
{
    [Fact(Skip = "At the moment this test is not recommended, for example = TICKET=001")]
    public void ConcatenateStrings()
    {
        // Arrange
        var stringOperations = new StringOperations();
        // Act
        var result = stringOperations.ConcatenateStrings("Hello", "Platzi");
        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.Equal("Hello Platzi", result);
    }
    
    [Fact]
    public void IsPalindrome_True()
    {
        // Arrange
        var stringOperations = new StringOperations();
        // Act
        var result = stringOperations.IsPalindrome("Hannah");
        //Assert
        Assert.True(result);
    }
    [Fact]
    public void IsPalindrome_False()
    {
        // Arrange
        var stringOperations = new StringOperations();
        // Act
        var result = stringOperations.IsPalindrome("Martinillo");
        //Assert
        Assert.False(result);
    }

    [Fact]
    public void RemoveWhiteSpace()
    {
        // Arrange
        var stringOperations = new StringOperations();
        //Act
        var result = stringOperations.RemoveWhitespace("Hoy no me quiero levantar");
        // Assert
        Assert.NotEmpty(result);
        Assert.Equal("Hoynomequierolevantar", result);
    }

    [Fact]
    public void QuantintyInWords()
    {
        // Arrange
        var stringOperations = new StringOperations();
        // Act
        var result = stringOperations.QuantintyInWords("cats", 7);
        //Assert
        Assert.StartsWith("sev", result);
        Assert.Contains("cat", result);
    }

    [Fact]
    public void GetStringLength_Exception()
    {
        // Arrange
        var stringOperations = new StringOperations();
        // Assert
        Assert.ThrowsAny<ArgumentNullException>(() => stringOperations.GetStringLength(null));
    }
    [Fact]
    public void GetStringLength_WhitaoutException()
    {
        // Arrange
        var stringOperations = new StringOperations();
        // Act
        var str = "Ferrocarrilero";
        var result = stringOperations.GetStringLength(str);
        // Assert
        Assert.Equal(str.Length, result);
    }

    [Theory]
    [InlineData("V", 5)]
    [InlineData("III", 3)]
    [InlineData("X", 10)]
    public void FromRomanToNumber(string romanNumber, int expected)
    {
        // Arrange
        var stringOperations = new StringOperations();
        // Act
        var result = stringOperations.FromRomanToNumber(romanNumber);
        // Assert
        Assert.Equal(expected, result);
    }
    
}