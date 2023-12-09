using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Library;
public static class InputUtils
{
    public static string NormalizeInput(string input)
    {
        input = input.Replace("\r", "");

        if (input.EndsWith("\n")) { input = input.Substring(0, input.Length - 1); }

        return input;
    }
}
