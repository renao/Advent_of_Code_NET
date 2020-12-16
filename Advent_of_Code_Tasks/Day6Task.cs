using NUnit.Framework;
using Advent_of_Code;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;

namespace Advent_of_Code_Tasks
{
    public class Day6_Task
    {

        [Test]
        public void Count_All_Questions_which_were_answered_yes()
        {
            Assert.That(Day6.CountAllQuestionsAnsweredYes(ReadAnswersByGroup), Is.EqualTo(6259));
        }

        [Test]
        public void Count_All_Questions_which_everyone_answered_yes()
        {
            Assert.That(Day6.CountAllQuestionsEveryoneAnsweredYes(ReadAnswersByGroup), Is.EqualTo(3178));
        }

        private string[] ReadAnswersByGroup
            => File
            .ReadAllText("day6_input")
            .Split("\n\n");
    }
}