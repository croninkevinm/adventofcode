using System.Text.RegularExpressions;
using System.Windows.Markup;

namespace Problems.Y2023;

[ProblemName("Scratchcards")]
[ProblemYear(2023)]
[ProblemDay(4)]
public class Y2023Day04 : ISolver
{
    public object PartOne(string input)
    {
        int result = 0;
        foreach (var card in input.Split("\n"))
        {
            int wins = ScoreCard(card);
            if (wins > 0)
            {
                result += (int)Math.Pow(2, wins - 1);
            }
        }
        return result;
    }

    public object PartTwo(string input)
    {
        var cardScores = input.Split("\n").Select(ScoreCard).ToArray();
        var counts = cardScores.Select(_ => 1).ToArray();

        for (int i = 0; i < cardScores.Length; i++)
        {
            var cardScore = cardScores[i];
            var count = counts[i];

            for (int j = 0; j < cardScore; j++)
            {
                counts[i + j+ 1] += count;
            }
        }
        return counts.Sum();
    }

    int ScoreCard(string card)
    {
        var parts = card.Split(':', '|');
        var winningNumbers = from m in Regex.Matches(parts[1], @"\d+") select m.Value;
        var cardNumbers = from m in Regex.Matches(parts[2], @"\d+") select m.Value;

        return winningNumbers.Intersect(cardNumbers).Count();
    }
}
