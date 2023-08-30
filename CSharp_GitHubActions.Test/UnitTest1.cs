using CSharp_GitHubActions.ClassLib;

namespace CSharp_GitHubActions.Test;

public class UnitTest1
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(1, 2, 5)]
    public void Test1(int a, int b, int expected)
    {
        var class1 = new Class1();
        var actual = class1.Add(a, b);
        Assert.Equal(expected, actual);
    }
}