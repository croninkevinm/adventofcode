using Problems.Y2019;

namespace Tests.Y2019;

public class Test2019Day02
{
    readonly Y2019Day02 _solution = new();

    [Theory]
    [InlineData(3500, "1,9,10,3,2,3,11,0,99,30,40,50")]
    [InlineData(2, "1,0,0,0,99")]
    [InlineData(6, "2,3,0,3,99")]
    [InlineData(9801, "2,4,4,5,99,0")]
    [InlineData(30, "1,1,1,4,99,5,6,0,99")]
    public void Part1(object expected, string input)
    {
        var actual = _solution.PartOne(InputUtils.NormalizeInput(input));
        Assert.Equal(expected, actual);
    }

    //[Theory]
    //[InlineData(2, "14")]
    //public void Part2(object expected, string input)
    //{
    //    var actual = _solution.PartTwo(InputUtils.NormalizeInput(input));
    //    Assert.Equal(expected, actual);
    //}
}
