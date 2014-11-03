﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStarPathFinder
{
    public static class TestGrids
    {
        public static int[,] GetGrid(int id) {
            switch (id) {
                case 1:
                    return new int[5, 7] {
                        {0, 0, 0, 0, 0, 0, 0},
                        {0, 0, 0, 1, 1, 1, 0},
                        {0, 2, 0, 1, 3, 0, 0},
                        {0, 0, 0, 1, 1, 1, 0},
                        {0, 0, 0, 0, 0, 0, 0}
                    };
                case 2:
                    return new int[6, 7] {
                        {0, 0, 0, 1, 0, 0, 0},
                        {0, 0, 0, 1, 0, 1, 0},
                        {0, 2, 0, 1, 0, 1, 0},
                        {0, 0, 0, 1, 3, 1, 0},
                        {0, 0, 0, 1, 1, 1, 0},
                        {0, 0, 0, 0, 0, 0, 0}
                    };
                case 3:
                    return new int[6, 7] {
                        {0, 0, 0, 1, 0, 0, 0},
                        {0, 0, 0, 1, 0, 1, 0},
                        {0, 3, 0, 1, 0, 1, 0},
                        {0, 0, 0, 1, 2, 1, 0},
                        {0, 0, 0, 1, 1, 1, 0},
                        {0, 0, 0, 0, 0, 0, 0}
                    };
                case 4:
                    return new int[8, 8] {
                        {0, 1, 0, 1, 0, 0, 0, 0},
                        {0, 1, 0, 0, 0, 1, 0, 0},
                        {0, 1, 0, 1, 0, 1, 1, 0},
                        {2, 1, 0, 1, 0, 0, 1, 0},
                        {0, 1, 0, 1, 0, 1, 0, 0},
                        {0, 1, 0, 1, 0, 1, 1, 0},
                        {0, 0, 0, 1, 0, 0, 1, 3},
                        {0, 1, 0, 1, 0, 1, 1, 0}
                    };
                default:
                    return new int[2, 2] {
                        {2, 0},
                        {0, 3}
                    };
            }
        }
    }
}