using NUnit.Framework;
using Advent_of_Code;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Advent_of_Code_Tasks
{
    public class Day3_Task
    {

        [Test]
        public void Count_all_trees_along_the_way()
        {
            Assert.That(Day3.CountTrees(InputMapLines, 3, 1), Is.EqualTo(244));
        }

        private List<string> InputMapLines
            => File.ReadAllLines("day3_input")
                .ToList();
    }
}