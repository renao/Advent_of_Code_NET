using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent_of_Code
{
    public class Day5
    {
        private const char LowerHalfRow = 'F';
        private const char UpperHalfRow = 'B';
        private const char LowerHalfSeat = 'L';
        private const char UpperHalfSeat = 'R';

        public static int FindOpenSeat(string[] boardingPasses)
        {
            var usedSeats = boardingPasses
                .Select(x => CalcSeatId(x))
                .ToList();
            usedSeats.Sort();

            for (int i = 1; i < usedSeats.Count; i++)
            {
                var previous = usedSeats[i - 1];
                var current = usedSeats[i];

                if (previous + 1 != current)
                {
                    return previous + 1;
                }
            }

            return -1;
        }

        public static int FindHighestSeatId(string[] boardingPasses)
            => boardingPasses
            .Select(x => CalcSeatId(x))
            .Max();

        private static List<int> AllSeatIds(string[] boardingPasses)
            => boardingPasses
                .Select(x => CalcSeatId(x))
                .ToList();

        private static int CalcSeatId(string boardingPass)
        {
            var row = CalcRow(boardingPass[0..7]);
            var seat = CalcSeat(boardingPass[7..]);
            return row * 8 + seat;
        }

        private static int CalcRow(string rowInfo)
        {
            var input = rowInfo
                .Replace(LowerHalfRow, '0')
                .Replace(UpperHalfRow, '1');
            return ReadFromBinary(input);
        }

        private static int CalcSeat(string seatInfo)
        {
            var input = seatInfo
                .Replace(LowerHalfSeat, '0')
                .Replace(UpperHalfSeat, '1');
            return ReadFromBinary(input);
        }

        private static int ReadFromBinary(string binary)
            => Convert.ToInt32(binary, 2);
    }
}
