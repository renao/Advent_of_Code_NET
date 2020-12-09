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
            && passport.HasValidByr
            && passport.HasValidIyr
            && passport.HasValidEyr
            && passport.HasValidHgt
            && passport.HasValidHcl
            && passport.HasValidEcl
            && passport.HasValidPid;

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

            public bool HasValidByr
            {
                get
                {
                    var byr = this.ReadValue("byr");
                    if (byr == null) return false;

                    int.TryParse(byr, out int year);

                    return year >= 1920 && year <= 2002;
                }
            }

            public bool HasValidIyr
            {
                get
                {
                    var iyr = ReadValue("iyr");
                    if (iyr == null) return false;

                    int.TryParse(iyr, out int year);

                    return year >= 2010 && year <= 2020;
                }
            }

            public bool HasValidEyr
            {
                get
                {
                    var eyr = ReadValue("eyr");
                    if (eyr == null) return false;

                    int.TryParse(eyr, out int year);

                    return year >= 2020 && year <= 2030;
                }
            }

            public bool HasValidHgt
            {
                get
                {
                    var hgt = this.ReadValue("hgt");
                    if (hgt == null) return false;

                    var system = hgt.Substring(hgt.Length - 2, 2);

                    if (system == "in")
                    {
                        int.TryParse(hgt.Replace("in", ""), out var height);
                        return height >= 59 && height <= 76;
                    }

                    if (system == "cm")
                    {
                        int.TryParse(hgt.Replace("cm", ""), out var height);
                        return height >= 150 && height <= 193;
                    }

                    return false;
                }
            }

            private char[] ValidHclValues = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };

            public bool HasValidHcl
            {
                get
                {
                    var hcl = this.ReadValue("hcl");
                    if (hcl == null || hcl.Length != 7 || !hcl.StartsWith("#")) return false;

                    var color = hcl.Substring(1);
                    return color.All(ValidHclValues.Contains);
                }
            }


            private char[] ValidPidValues = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            public bool HasValidPid
            {
                get
                {
                    var pid = this.ReadValue("pid");
                    if (pid == null || pid.Length != 9) return false;

                    return pid.All(x => ValidPidValues.Contains(x));
                }
            }

            private string[] ValidEcls = { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };

            public bool HasValidEcl
            {
                get
                {
                    var ecl = ReadValue("ecl");
                    return ecl != null && ValidEcls.Contains(ecl);
                }
            }

            private string ReadValue(string fieldname)
                => fields
                .FirstOrDefault(x => x.StartsWith(fieldname))?
                .Split(":")
                .Last();
        }
    }
}
