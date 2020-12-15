using NUnit.Framework;
using Advent_of_Code;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;

namespace Advent_of_Code_Tasks
{
    public class Day5_Task
    {

        [Test]
        public void Find_Highest_Seat_ID_on_all_Boarding_Passes()
        {
            Assert.That(Day5.FindHighestSeatId(ReadBoardingPasses), Is.EqualTo(848));
        }

        private string[] ReadBoardingPasses
            => File.ReadAllLines("day5_input");
    }
}