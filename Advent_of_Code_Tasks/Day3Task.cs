using NUnit.Framework;
using Advent_of_Code;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;

namespace Advent_of_Code_Tasks
{
    public class Day3_Task
    {

        [Test]
        public void Count_all_trees_along_the_way()
        {
            Assert.That(Day3.CountTrees(InputMapLines, 3, 1), Is.EqualTo(244));
        }

        [Test]
        public void Encouter_other_slopes_and_multiply()
        {
            var slopes = new []
            {
                (Right: 1, Down: 1),
                (Right: 3, Down: 1),
                (Right: 5, Down: 1),
                (Right: 7, Down: 1),
                (Right: 1, Down: 2)
            };

            var allSlopes = slopes
                .Select(slope => (long)Day3.CountTrees(InputMapLines, slope.Right, slope.Down))
                .Aggregate((x, y) => x * y);

            Assert.That(allSlopes, Is.EqualTo(9_406_609_920));
        }

        private List<string> InputMapLines
            => File.ReadAllLines("day3_input")
                .ToList();
    }
}