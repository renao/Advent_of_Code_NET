using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent_of_Code
{
    public class Day7
    {

        public static int CountPossibleBagColors(string[] bagRules, string bagColor)
        {
            var found = new List<string>();
            FindPossibleBags(bagRules, bagColor, ref found);
            return found.Count();
        }

        private static void FindPossibleBags(
            string[] bagRules,
            string bagColor,
            ref List<string> found)
        {
            var newColors = bagRules
                .Where(x => x.Split(" contain ").Last().Contains(bagColor))
                .Select(x => x.Split("s contain ").First().Trim())
                .Except(found)
                .ToList();

            foreach (var newColor in newColors)
            {
                if (!found.Contains(newColor))
                {
                    found.Add(newColor);
                    FindPossibleBags(bagRules, newColor, ref found);
                }
            }
        }

        
    }
}
