//using System;
using Xunit;
using RectService;

namespace RectService
{
public class RectTest
{
    [Fact]
    public void Test1()
    {
        Rect rect = new Rect(2, 3);
        var res = rect.Area();
        Assert.Equal(6, res);

    }
}
}