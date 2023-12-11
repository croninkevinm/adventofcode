namespace Problems.Y2019;

[ProblemName("1202 Program Alarm")]
[ProblemYear(2019)]
[ProblemDay(2)]
public class Y2019Day02 : ISolver
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public object PartOne(string input)
    {
        Computer computer = new();
        if(input.Length < 30)
        {
            return computer.Run(input);
        }
        return computer.Run(input, 12, 2);

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public object PartTwo(string input)
    {
        int result = 0;
        Computer computer = new();
        
        for (int noun = 0; noun < 100; noun++)
        {
            for (int verb = 0; verb < 100; verb++)
            {
                if (computer.Run(input, noun, verb) == 19690720)
                {
                    return 100 * noun + verb;
                }
            }
        }
        return result;
    }
}
