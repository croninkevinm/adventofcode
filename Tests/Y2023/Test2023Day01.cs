using Problems.Y2023;

namespace Tests.Y2023;
public class Test2023Day01
{
    readonly Y2023Day01 _solution = new();
    
    [Theory]
    [InlineData(142, "1abc2\npqr3stu8vwx\na1b2c3d4e5f\ntreb7uchet")]
    public void Part1(object expected, string input)
    {
        var actual = _solution.PartOne(InputUtils.NormalizeInput(input));
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(281, "two1nine\neightwothree\nabcone2threexyz\nxtwone3four\n4nineeightseven2\nzoneight234\n7pqrstsixteen")]
    public void Part2(object expected, string input)
    {
        var actual = _solution.PartTwo(InputUtils.NormalizeInput(input));
        Assert.Equal(expected, actual);
    }
}
