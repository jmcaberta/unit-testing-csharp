namespace StringManipulation.Tests;

public class StringOperationTest
{
    [Fact]
    public void ConcatenateStrings()
    {
        var stringOperations = new StringOperations();

        var result = stringOperations.ConcatenateStrings("Hello", "Platzi");
        
        Assert.Equal("Hello Platzi", result);
    }
}