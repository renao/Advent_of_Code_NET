using System;
using System.Collections.Generic;
using System.Linq;

namespace Advent_of_Code
{
    public class Day3
    {
        private const char Tree = '#';

        public static int CountTrees(List<string> mapLines, int slopeX, int slopeY)
            => TreesOnSlope(mapLines: mapLines, x: slopeX, y: slopeY);

        private static int TreesOnSlope(List<string> mapLines, int x, int y)
        {
            var trees = 0;
            for (int i = 0; i < mapLines.Count; i += y)
            {
                var posX = (i * x) % mapLines[i].Length;
                if (mapLines[i][posX] == Tree)
                {
                    trees += 1;
                }
            }
            return trees;
        }
        
    }
}
