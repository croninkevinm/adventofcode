using System.Text.RegularExpressions;

namespace Problems.Y2023;

[ProblemName("Trebuchet?!")]
[ProblemYear(2023)]
[ProblemDay(1)]
public class Y2023Day01 : ISolver
{
    public object PartOne(string input)
    {
        return Solve(input, @"\d");
    }

    public object PartTwo(string input)
    {
        return Solve(input, @"\d|one|two|three|four|five|six|seven|eight|nine");
    }

    int Solve(string input, string rx)
    {
        int result = 0;
        foreach (var line in input.Split("\n"))
        {
            var first = ParseMatch(Regex.Match(line, rx).Value);
            var last = ParseMatch(Regex.Match(line, rx, RegexOptions.RightToLeft).Value);
            result += first * 10 + last;
        }
        return result;
    }

    int ParseMatch(string st)
    {
        switch (st)
        {
            case "one": return 1;
            case "two": return 2;
            case "three": return 3;
            case "four": return 4;
            case "five": return 5;
            case "six": return 6;
            case "seven": return 7;
            case "eight": return 8;
            case "nine": return 9;
            case "zero": return 0;
            default: return int.Parse(st);
        }
    }
}
