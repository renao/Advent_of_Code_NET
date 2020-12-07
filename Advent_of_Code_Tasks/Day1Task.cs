using NUnit.Framework;
using Advent_of_Code;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Advent_of_Code_Tasks
{
    public class Day1_Task
    {

        [Test]
        public void Find_Solution_for_2_Numbers()
        {
            Assert.That(Day1.SolveForTwoNumbers(InputNumbers), Is.EqualTo(381699));
        }

        [Test]
        public void Find_Solution_for_3_Numbers()
        {
            Assert.That(Day1.SolveForThreeNumbers(InputNumbers), Is.EqualTo(111605670));
        }

        private List<int> InputNumbers
            => File.ReadAllLines("day1_input")
                .Select(line => int.Parse(line))
                .ToList();
    }
}