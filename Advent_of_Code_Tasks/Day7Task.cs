using NUnit.Framework;
using Advent_of_Code;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;

namespace Advent_of_Code_Tasks
{
    public class Day7_Task
    {

        [Test]
        public void Amount_of_Bag_Colors_that_could_contain_a_Shiny_Gold_bag()
        {
            Assert.That(Day7.CountPossibleBagColors(ReadRules, "shiny gold"), Is.EqualTo(316));
        }

        private string[] ReadRules
            => File
            .ReadAllLines("day7_input");
    }
}