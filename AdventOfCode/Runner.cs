using System.Diagnostics;

namespace AdventOfCode;
internal class Runner
{
    public static void RunAllSolvers(ISolver[] solvers)
    {
        int previousYear = -1;
        foreach (var solver in solvers)
        {
            if (previousYear != solver.Year())
            {
                WriteLine();
                WriteLine($"Advent Of Code y={solver.Year()}", ConsoleColor.Green);
                previousYear = solver.Year();
            }
            RunSolver(solver);
        }
    }

    public static void RunSolver(ISolver solver)
    {
        WriteLine($"--- Day {solver.Day()}: {solver.Name()} ---", ConsoleColor.White);

        string inputFile = Path.Combine("Input", solver.Year().ToString(), $"Day{solver.Day().ToString("00")}.in");
        string inputData = GetNormalizedInput(inputFile);

        Stopwatch stopwatch = Stopwatch.StartNew();
        foreach (var solution in solver.Solve(inputData))
        {
            long ticks = stopwatch.ElapsedTicks;
            Write($"{solution}");
            double diff = ticks * 1000.0 / Stopwatch.Frequency;
            WriteLine(
                $" ({diff.ToString("F3")} ms)",
                diff > 1000 ? ConsoleColor.Red :
                diff > 500 ? ConsoleColor.Yellow :
                ConsoleColor.DarkGreen
            );
            stopwatch.Restart();
        }
    }

    private static string GetNormalizedInput(string inputFilePath)
    {
        string input;
        try
        {
            input = File.ReadAllText(inputFilePath);
        }
        catch (Exception)
        {

            input = "";
        }
        return InputUtils.NormalizeInput(input);
    }

    private static void Write(string text = "", ConsoleColor color = ConsoleColor.Gray)
    {
        var cacheForegroundColor = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.Write(text);
        Console.ForegroundColor = cacheForegroundColor;
    }

    private static void WriteLine(string text = "", ConsoleColor color = ConsoleColor.Gray)
    {
        Write(text + "\n", color);
    }
}
