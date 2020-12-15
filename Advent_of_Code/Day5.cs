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

        public static int FindHighestSeatId(string[] boardingPasses)
        {
            var maxSeatId = -1;
            foreach (var boardingPass in boardingPasses)
            {
                var row = CalcRow(boardingPass[0..7]);
                var seat = CalcSeat(boardingPass[7..]);
                var seatId = row * 8 + seat;
                if (seatId > maxSeatId)
                {
                    maxSeatId = seatId;
                }
            }
            return maxSeatId;
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
