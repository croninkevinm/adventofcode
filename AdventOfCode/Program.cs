
using System.Reflection;

var problems = Assembly.Load("Problems")!.GetTypes()
    .Where(t => t.GetTypeInfo().IsClass && typeof(ISolver).IsAssignableFrom(t))
    .OrderBy(t => t.FullName)
    .ToArray();

//var problems = Assembly.GetEntryAssembly()!.GetTypes()
//    .Where(t => t.GetTypeInfo().IsClass && typeof(ISolver).IsAssignableFrom(t))
//    .OrderBy(t => t.FullName)
//    .ToArray();

Runner.RunAllSolvers(problems.Select(t => (ISolver) Activator.CreateInstance(t)!).ToArray());