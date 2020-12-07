using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent_of_Code
{
    public class Day2
    {

        public static int FindAmountOfValidPasswords(List<string> passwordLines)
            => passwordLines.Count(ContainsValidPassword);

        public static int FindAmountOfValidTobogganPasswords(List<string> passwordLines)
            => passwordLines.Count(ContainsValidTobogganPassword);

        private static bool ContainsValidPassword(string passwordLine)
        {
            var definition = ReadFromLine(passwordLine);

            var letterAmount = definition.Password.Count(c => c == definition.Letter);
            return InBetween(letterAmount, definition.MinimumAmount, definition.MaximumAmount);
        }

        private static bool ContainsValidTobogganPassword(string passwordLine)
        {
            var definition = ReadFromLine(passwordLine);

            var letter1 = definition.Password.ElementAtOrDefault(definition.MinimumAmount - 1);
            var letter2 = definition.Password.ElementAtOrDefault(definition.MaximumAmount - 1);

            var letter1IsValid = letter1 == definition.Letter;
            var letter2IsValid = letter2 == definition.Letter;

            return letter1IsValid ^ letter2IsValid;
        }

        private static bool InBetween(int number, int minValue, int maxValue)
            => number >= minValue && number <= maxValue;

        private static PasswordDefinition ReadFromLine(string passwordLine)
        {
            var parts = passwordLine.Split(" ");
            var minMax = parts[0].Split("-");

            return new PasswordDefinition
            {
                MinimumAmount = int.Parse(minMax[0]),
                MaximumAmount = int.Parse(minMax[1]),
                Letter = parts[1].First(),
                Password = parts[2]
            };
        }

        private class PasswordDefinition
        {
            public int MinimumAmount { get; set; }
            public int MaximumAmount { get; set; }
            public char Letter { get; set; }
            public string Password { get; set; }
        }
    }
}
