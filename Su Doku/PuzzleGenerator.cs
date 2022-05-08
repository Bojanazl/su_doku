using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Su_Doku
{
    internal static class PuzzleGenerator
    {
        
        static Random random = new Random();

        public static bool hasSingleSolution(List<Tuple<int, int>> selectedValues, int[,] allValues)
        {
            int[,] testSudoku = new int[9, 9];

            foreach (var value in selectedValues)
            {
                var row = value.Item1;
                var column = value.Item2;

                testSudoku[row, column] = allValues[row, column];
            }

            int numSolutions = solveSudoku(0, 0, testSudoku, 0);
            if (numSolutions != 1)
            {
                return false;
            }

            return true;
        }

        public static bool hasSingleSolution(int[,] allValues)
        {
            int numSolutions = solveSudoku(0, 0, allValues, 0);
            if (numSolutions != 1)
            {
                return false;
            }

            return true;
        }

        public static int[,] GeneratePuzzle(int[,] array)
        {


            ////9x9
            //for (int j = 0; j <= 8; j++)
            //{
            //    int i = 0;
            //    var storeValue = array[i, j];
            //    array[i, j] = 0;
            //    if (!hasSingleSolution(array))
            //        array[i, j] = storeValue;
            //}

            //for (int j = 0; j <= 8; j++)
            //{
            //    int i = 8;
            //    var storeValue = array[i, j];
            //    array[i, j] = 0;
            //    if (!hasSingleSolution(array))
            //        array[i, j] = storeValue;
            //}

            //for (int i = 0; i <= 8; i++)
            //{
            //    int j = 0;
            //    var storeValue = array[i, j];
            //    array[i, j] = 0;
            //    if (!hasSingleSolution(array))
            //        array[i, j] = storeValue;
            //}

            //for (int i = 0; i <= 8; i++)
            //{
            //    int j = 8;
            //    var storeValue = array[i, j];
            //    array[i, j] = 0;
            //    if (!hasSingleSolution(array))
            //        array[i, j] = storeValue;
            //}


            ////7x7
            //for (int j = 1; j <= 7; j++)
            //{
            //    int i = 7;
            //    var storeValue = array[i, j];
            //    array[i, j] = 0;
            //    if (!hasSingleSolution(array))
            //        array[i, j] = storeValue;
            //}


            //for (int j = 1; j <= 7; j++)
            //{
            //    int i = 1;
            //    var storeValue = array[i, j];
            //    array[i, j] = 0;
            //    if (!hasSingleSolution(array))
            //        array[i, j] = storeValue;
            //}

            //for (int i = 1; i <= 7; i++)
            //{
            //    int j = 1;
            //    var storeValue = array[i, j];
            //    array[i, j] = 0;
            //    if (!hasSingleSolution(array))
            //        array[i, j] = storeValue;
            //}

            //for (int i = 1; i <= 7; i++)
            //{
            //    int j = 7;
            //    var storeValue = array[i, j];
            //    array[i, j] = 0;
            //    if (!hasSingleSolution(array))
            //        array[i, j] = storeValue;
            //}


            ////5x5

            //for (int j = 2; j <= 6; j++)
            //{
            //    int i = 2;
            //    var storeValue = array[i, j];
            //    array[i, j] = 0;
            //    if (!hasSingleSolution(array))
            //        array[i, j] = storeValue;
            //}


            //for (int i = 3; i <= 5; i++)
            //{
            //    int j = 2;
            //    var storeValue = array[i, j];
            //    array[i, j] = 0;
            //    if (!hasSingleSolution(array))
            //        array[i, j] = storeValue;
            //}


            //for (int j = 2; j <= 6; j++)
            //{
            //    int i = 6;
            //    var storeValue = array[i, j];
            //    array[i, j] = 0;
            //    if (!hasSingleSolution(array))
            //        array[i, j] = storeValue;
            //}

            //for (int i = 3; i <= 5; i++)
            //{
            //    int j = 6;
            //    var storeValue = array[i, j];
            //    array[i, j] = 0;
            //    if (!hasSingleSolution(array))
            //        array[i, j] = storeValue;
            //}

            ////3x3
            //for (int i = 3; i <= 5; i++)
            //{
            //    for (int j = 3; j <= 5; j++)
            //    {
            //        var storeValue = array[i, j];
            //        array[i, j] = 0;
            //        if (!hasSingleSolution(array))
            //            array[i, j] = storeValue;
            //    }
            //}


            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (array[i, j] == 0)
                        continue;
                    var storeValue = array[i, j];
                    array[i, j] = 0;
                    if (!hasSingleSolution(array))
                        array[i, j] = storeValue;
                }
            }

            return array;
        }

        private static int solveSudoku(int i, int j, int[,] cells, int count)
        {
            if (i == 9)
            {
                i = 0;
                if (++j == 9)
                    return 1 + count;
            }

            if (cells[i, j] != 0)
                return solveSudoku(i + 1, j, cells, count);

            for (int val = 1; val <= 9 && count < 2; ++val)
            {
                if (isSafe(i, j, val, cells))
                {
                    cells[i, j] = val;
                    count = solveSudoku(i + 1, j, cells, count);
                }
            }
            cells[i, j] = 0;
            return count;
        }

        private static bool isSafe(int row, int column, int value, int[,] cells)
        {
            for (int d = 0; d < 9; d++)
            {
                if (cells[row, d] == value)
                {
                    return false;
                }
            }

            for (int r = 0; r < 9; r++)
            {
                if (cells[r, column] == value)
                {
                    return false;
                }
            }

            int sqrt = 3;
            int boxRowStart = row - row % sqrt;
            int boxColumnStart = column - column % sqrt;

            for (int r = boxRowStart; r < boxRowStart + sqrt; r++)
            {
                for (int d = boxColumnStart; d < boxColumnStart + sqrt; d++)
                {
                    if (cells[r, d] == value)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
