using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent_of_Code
{
    public class Day1
    {

        public static int SolveForTwoNumbers(List<int> numbers)
        {
            return numbers
                .FindAll(n => numbers.Exists(m => m + n == 2020))
                .Aggregate((a, b) => a * b);
        }

        public static int SolveForThreeNumbers(List<int> numbers)
        {
            return numbers
                .FindAll(n => numbers.Exists(m => numbers.Exists(o => o + m + n == 2020)))
                .Aggregate((a, b) => a * b);
        }
    }
}
