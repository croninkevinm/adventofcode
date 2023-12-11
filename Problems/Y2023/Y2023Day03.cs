using System.Text.RegularExpressions;

namespace Problems.Y2023;

[ProblemName("Gear Ratios")]
[ProblemYear(2023)]
[ProblemDay(3)]
public class Y2023Day03 : ISolver
{
    public object PartOne(string input)
    {
        var rows = input.Split('\n');
        var symbols = Parse(rows, new Regex(@"[^.0-9]"));
        var nums = Parse(rows, new Regex(@"\d+"));

        return (
            from n in nums
            where symbols.Any(s => CheckAdjacent(s, n))
            select n.Int
        ).Sum();
    }

    public object PartTwo(string input)
    {
        var rows = input.Split('\n');
        var gears = Parse(rows, new Regex(@"\*"));
        var numbers = Parse(rows, new Regex(@"\d+"));

        return (
            from g in gears
            let neighbours = from n in numbers
                             where CheckAdjacent(g, n)
                             select n.Int
            where neighbours.Count() == 2
            select neighbours.First() * neighbours.Last()
        ).Sum();
    }

    bool CheckAdjacent(Part a, Part b)
    {
        return Math.Abs(a.row - b.row) <= 1 &&
            a.col <= b.col + b.Text.Length &&
            b.col <= a.col + a.Text.Length;
    }

    Part[] Parse(string[] rows, Regex rx)
    {
        var result = new List<Part>();
        for (int rowIndex = 0; rowIndex < rows.Length; rowIndex++)
        {
            foreach (Match match in rx.Matches(rows[rowIndex]))
            {
                result.Add(new(match.Value, rowIndex, match.Index));
            }
        }
        return result.ToArray();
    }

    record Part(string Text, int row, int col)
    {
        public int Int => int.Parse(Text);
    }
}
