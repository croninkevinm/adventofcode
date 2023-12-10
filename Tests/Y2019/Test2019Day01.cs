using Problems.Y2019;

namespace Tests.Y2019;
public class Test2019Day01
{
    readonly Y2019Day01 _solution = new();

    [Theory]
    [InlineData(2, "12")]
    [InlineData(2, "14")]
    [InlineData(654, "1969")]
    [InlineData(33583, "100756")]
    public void Part1(object expected, string input)
    {
        var actual = _solution.PartOne(InputUtils.NormalizeInput(input));
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2, "14")]
    [InlineData(966, "1969")]
    [InlineData(50346, "100756")]
    public void Part2(object expected, string input)
    {
        var actual = _solution.PartTwo(InputUtils.NormalizeInput(input));
        Assert.Equal(expected, actual);
    }
}
