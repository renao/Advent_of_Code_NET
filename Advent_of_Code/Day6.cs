using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent_of_Code
{
    public class Day6
    {

        public static int CountAllQuestionsAnsweredYes(string[] groupAnswers)
            => groupAnswers
                .Sum(x => x.Distinct().Count(x => char.IsLetter(x)));

        public static int CountAllQuestionsEveryoneAnsweredYes(string[] groupAnswers)
        {
            var count = 0;
            foreach (var group in groupAnswers)
            {

                var personalAnswers = group.Split("\n");
                var everyonesYes = personalAnswers.First().ToCharArray().ToList();

                foreach (var answer in personalAnswers)
                {
                    everyonesYes = everyonesYes.Intersect(answer.ToCharArray()).ToList();
                }

                count += everyonesYes.Count;
            }

            return count;
        }
    }
}
