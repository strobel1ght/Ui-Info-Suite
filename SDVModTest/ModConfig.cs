﻿namespace UIInfoSuite
{
    internal class ModConfig
    {

        public int[][] Sprinkler { get; set; } = {
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
        };

        public int[][] QualitySprinkler { get; set; } = {
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
        };

        public int[][] IridiumSprinkler { get; set; } = {
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0 },
            new[] { 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0 },
            new[] { 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0 },
            new[] { 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0 },
            new[] { 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
        };
		
		public int[][] PrismaticSprinkler { get; set; } = {
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0 },
            new[] { 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0 },
            new[] { 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0 },
            new[] { 0, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0 },
            new[] { 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0 },
            new[] { 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0 },
            new[] { 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
        };

        public int[][] Beehouse { get; set; } = {
            new[] { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0 },
            new[] { 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0 },
            new[] { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
            new[] { 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0 },
            new[] { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
            new[] { 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0 },
            new[] { 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0 },
            new[] { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 }
        };
    }
}
