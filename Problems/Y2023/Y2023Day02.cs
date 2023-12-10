using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problems.Y2023;

[ProblemName("Cube Conundrum")]
[ProblemYear(2023)]
[ProblemDay(2)]
public class Y2023Day02 : ISolver
{
    record Game(int id, int blue, int green, int red);

    /// <summary>
    /// Each line represents a game. A game is a series of pulls of cubes from a bag.
    /// Determine which games would have been possible if the bag had been loaded with only 12 red cubes, 13 green cubes, and 14 blue cubes.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>The sum of game ids for games that are posible</returns>
    public object PartOne(string input)
    {
        int result = 0;
        foreach (var line in input.Split("\n"))  
        {
            Game game = ParseGame(line);
            if (game.red <= 12 && game.green <= 13 && game.blue <= 14)
            {
                result += game.id;
            }
        }
        return result;
    }

    /// <summary>
    /// What is the fewest number of cubes of each color that could have been in the bag to make the game possible.
    /// The power of a set of cubes is equal to the numbers of red, green, and blue cubes multiplied together.
    /// </summary>
    /// <param name="input"></param>
    /// <returns>For each game, find the minimum set of cubes that must have been present. What is the sum of the power of these sets?</returns>
    public object PartTwo(string input)
    {
        int result = 0;
        foreach (var line in input.Split("\n"))
        {
            Game game = ParseGame(line);
            int power = game.red * game.blue * game.green;
            result += power;
        }
        return result;
    }

    Game ParseGame(string input)
    {
        int id = ParseInt(input, @"Game (\d+)").First();
        int blue = ParseInt(input, @"(\d+) blue").Max();
        int green = ParseInt(input, @"(\d+) green").Max();
        int red = ParseInt(input, @"(\d+) red").Max();
        
        return new Game(id, blue, green, red);
    }

    IEnumerable<int> ParseInt(string st, string rx)
    {
        IEnumerable<int> result = new List<int>();
        foreach (Match match in Regex.Matches(st, rx))
        {
            result = result.Append(int.Parse(match.Groups[1].Value));
        }
        return result;
    }
}
