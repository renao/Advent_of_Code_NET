using NUnit.Framework;
using Advent_of_Code;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Advent_of_Code_Tasks
{
    public class Day2_Task
    {

        [Test]
        public void Find_Amount_of_valid_Passwords()
        {
            Assert.That(Day2.FindAmountOfValidPasswords(InputPasswordLines), Is.EqualTo(393));
        }

        [Test]
        public void Find_Amount_of_valid_Passwords_due_Official_Toboggan_Corporate_Authentication_System()
        {
            Assert.That(Day2.FindAmountOfValidTobogganPasswords(InputPasswordLines), Is.EqualTo(690));
        }

        private List<string> InputPasswordLines
            => File.ReadAllLines("day2_input")
                .ToList();
    }
}