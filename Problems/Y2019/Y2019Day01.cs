namespace Problems.Y2019;

[ProblemName("The Tyranny of the Rocket Equation")]
[ProblemYear(2019)]
[ProblemDay(1)]
public class Y2019Day01 : ISolver
{
    /// <summary>
    /// Fuel required to launch a given module is based on its mass.
    /// Specifically, to find the fuel required for a module,
    /// take its mass, divide by three, round down, and subtract 2.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public object PartOne(string input)
    {
        int result = 0;
        foreach (var line in input.Split("\n"))
        {
            int fuel = CalculateFuel(int.Parse(line));
            result += fuel;
        }
        return result;
    }

    public object PartTwo(string input)
    {
        int result = 0;
        foreach (var line in input.Split("\n"))
        {
            int mass = int.Parse(line);
            while (mass > 0)
            {
                int fuel = CalculateFuel(mass);
                result += fuel;
                mass = fuel;
            }
        }
        return result;
    }

    int CalculateFuel(int mass)
    {
        int fuel = (int)Math.Truncate((float)(mass / 3)) - 2;
        return Math.Max(fuel, 0);
    }
}
