using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Library;
public interface ISolver
{
    object PartOne(string input);
    object PartTwo(string input);
}

[AttributeUsage(AttributeTargets.Class)]
public class ProblemName : Attribute
{
    public readonly string Name;
    public ProblemName(string name)
    {
        this.Name = name;
    }
}

[AttributeUsage(AttributeTargets.Class)]
public class ProblemYear : Attribute
{
    public readonly int Year;
    public ProblemYear(int year)
    {
        this.Year = year;
    }
}

[AttributeUsage(AttributeTargets.Class)]
public class ProblemDay : Attribute
{
    public readonly int Day;
    public ProblemDay(int day)
    {
        this.Day = day;
    }
}

public static class SolverExtensions
{
    public static IEnumerable<object> Solve(this ISolver solver, string input)
    {
        yield return solver.PartOne(input);
        yield return solver.PartTwo(input);
    }

    public static string Name(this ISolver solver)
    {
        ProblemName? attribute = (ProblemName?) solver.GetType().GetCustomAttribute(typeof(ProblemName));
        if (attribute == null)
        {
            return "Unnamed";
        }
        return attribute.Name;
    }

    public static int Year(this ISolver solver)
    {
        ProblemYear? attribute = (ProblemYear?)solver.GetType().GetCustomAttribute(typeof(ProblemYear));
        if (attribute == null)
        {
            return 0;
        }
        return attribute.Year;
    }

    public static int Day(this ISolver solver)
    {
        ProblemDay? attribute = (ProblemDay?)solver.GetType().GetCustomAttribute(typeof(ProblemDay));
        if (attribute == null)
        {
            return 0;
        }
        return attribute.Day;
    }
}