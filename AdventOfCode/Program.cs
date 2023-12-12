
using System.Reflection;

var problems = Assembly.Load("Problems")!.GetTypes()
    .Where(t => t.GetTypeInfo().IsClass && typeof(ISolver).IsAssignableFrom(t))
    .OrderBy(t => t.FullName)
    .ToArray();

IEnumerable<Problem> solvers = problems.Select(t =>
{
    ISolver s = (ISolver)Activator.CreateInstance(t)!;
    return new Problem(t, s.Year(), s.Day());
});

//Console.WriteLine("");
//Console.Write("Run: ");
//string run = Console.ReadLine()!.ToLower();
//switch (run)
//{
//    case "all":
//        Runner.RunAllSolvers(solvers.Select(s => (ISolver)Activator.CreateInstance(s.FullName)!).ToArray());
//        break;
//    case "today":
//        var selectedSolvers = solvers.Where(s => { return s.Year == DateTime.Now.Year && s.Day == DateTime.Now.Day; });
//        Runner.RunAllSolvers(selectedSolvers.Select(s => (ISolver)Activator.CreateInstance(s.FullName)!).ToArray());
//        break;
//    default:
//        Console.WriteLine("Bad input! Exiting...");
//        break;
//}

Runner.RunAllSolvers(solvers.Select(s => (ISolver)Activator.CreateInstance(s.FullName)!).ToArray());

record Problem(Type FullName, int Year, int Day);