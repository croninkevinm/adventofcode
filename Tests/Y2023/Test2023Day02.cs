using Problems.Y2023;

namespace Tests.Y2023;
public class Test2023Day02
{
    readonly Y2023Day02 _solution = new();

    [Theory]
    [InlineData(8, "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green\r\nGame 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue\r\nGame 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red\r\nGame 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red\r\nGame 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green")]
    public void Part1(object expected, string input)
    {
        var actual = _solution.PartOne(InputUtils.NormalizeInput(input));
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2286, "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green\r\nGame 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue\r\nGame 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red\r\nGame 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red\r\nGame 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green")]
    public void Part2(object expected, string input)
    {
        var actual = _solution.PartTwo(InputUtils.NormalizeInput(input));
        Assert.Equal(expected, actual);
    }
}
