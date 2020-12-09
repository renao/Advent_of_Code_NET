using NUnit.Framework;
using Advent_of_Code;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;

namespace Advent_of_Code_Tasks
{
    public class Day4_Task
    {

        [Test]
        public void Count_Valid_Passports()
        {
            var validPassports = Day4
                .ReadPassports(this.ReadPassportFile)
                .Count(Day4.IsValid);
            Assert.That(validPassports, Is.EqualTo(-1));
        }

        private string ReadPassportFile
            => File.ReadAllText("day4_input");
    }
}