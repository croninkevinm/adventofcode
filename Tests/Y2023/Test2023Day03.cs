using Problems.Y2023;

namespace Tests.Y2023;
public class Test2023Day03
{
    readonly Y2023Day03 _solution = new();

    [Theory]
    [InlineData(4361, "467..114..\r\n...*......\r\n..35..633.\r\n......#...\r\n617*......\r\n.....+.58.\r\n..592.....\r\n......755.\r\n...$.*....\r\n.664.598..")]
    public void Part1(object expected, string input)
    {
        var actual = _solution.PartOne(InputUtils.NormalizeInput(input));
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(467835, "467..114..\r\n...*......\r\n..35..633.\r\n......#...\r\n617*......\r\n.....+.58.\r\n..592.....\r\n......755.\r\n...$.*....\r\n.664.598..")]
    public void Part2(object expected, string input)
    {
        var actual = _solution.PartTwo(InputUtils.NormalizeInput(input));
        Assert.Equal(expected, actual);
    }
}
