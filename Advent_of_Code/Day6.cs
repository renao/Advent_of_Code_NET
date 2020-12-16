using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent_of_Code
{
    public class Day6
    {

        public static int CountAllQuestionsAnsweredYes(string[] groupAnswers)
        {
            
            return groupAnswers
                .Sum(x => x.Distinct().Count(x => char.IsLetter(x)));
        }
    }
}
