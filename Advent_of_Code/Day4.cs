using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent_of_Code
{
    public class Day4
    {
        private const string PassportDivider = "\n\n";

        public static bool IsValid(Passport passport)
            => passport.fields != null
            && passport.fields.Length > 6
            && passport.Has("byr")
            && passport.Has("iyr")
            && passport.Has("eyr")
            && passport.Has("hgt")
            && passport.Has("hcl")
            && passport.Has("ecl")
            && passport.Has("pid");

        public static List<Passport> ReadPassports(string fileContent)
        {
            var passports = new List<Passport>();

            var passportInputs = fileContent.Split(PassportDivider);

            return passportInputs
                .Select(x => x.Replace("\n", " "))
                .Select(x => x.Split(" "))
                .Select(x => new Passport { fields = x })
                .ToList();
        }

        public class Passport
        {
            public string[] fields { get; set; } = new string[0];

            public bool Has(string fieldname)
                => fields.FirstOrDefault(x => x.StartsWith(fieldname)) != null;
        }
    }
}
