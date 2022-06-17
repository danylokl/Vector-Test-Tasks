using System;
namespace Sudoku
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            const int customSudokuSize = 4;
            const int correctSudokuSize = 9;

            int[][] correctSudoku9x9 = new int[correctSudokuSize][];
            correctSudoku9x9[0] = new int[correctSudokuSize] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            correctSudoku9x9[1] = new int[correctSudokuSize] { 7, 8, 9, 1, 2, 3, 4, 5, 6 };
            correctSudoku9x9[2] = new int[correctSudokuSize] { 4, 5, 6, 7, 8, 9, 1, 2, 3 };
            correctSudoku9x9[3] = new int[correctSudokuSize] { 3, 1, 2, 8, 4, 5, 9, 6, 7 };
            correctSudoku9x9[4] = new int[correctSudokuSize] { 6, 9, 7, 3, 1, 2, 8, 4, 5 };
            correctSudoku9x9[5] = new int[correctSudokuSize] { 8, 4, 5, 6, 9, 7, 3, 1, 2 };
            correctSudoku9x9[6] = new int[correctSudokuSize] { 2, 3, 1, 5, 7, 4, 6, 9, 8 };
            correctSudoku9x9[7] = new int[correctSudokuSize] { 9, 6, 8, 2, 3, 1, 5, 7, 4 };
            correctSudoku9x9[8] = new int[correctSudokuSize] { 5, 7, 4, 9, 6, 8, 2, 3, 1 };

            int[][] sudokuCustomSize = new int[customSudokuSize][];


            for (int i = 0; i < customSudokuSize; i++)
            {
                sudokuCustomSize[i] = new int[customSudokuSize];
                for (int j = 0; j < customSudokuSize; j++)
                {
                    sudokuCustomSize[i][j] = random.Next(1, customSudokuSize + 1);
                }
            }

            SudokuOutput(sudokuCustomSize);

            bool isValidSudokuCustomSize = ValidateSudoku(sudokuCustomSize);
            Console.WriteLine($"Sudoku is valid: {isValidSudokuCustomSize} \n");


            SudokuOutput(correctSudoku9x9);

            bool isValidCorrectSudoku = ValidateSudoku(correctSudoku9x9);
            Console.WriteLine($"Sudoku is valid: {isValidCorrectSudoku} ");
        }


        public static bool ValidateSudoku(int[][] sudokuData)
        {

            if (Math.Sqrt(sudokuData.Length) != (int)Math.Sqrt(sudokuData.Length)||sudokuData.Length!=1)
            {
                return false;
            }

            for (int i = 0; i < sudokuData.Length; i++)
            {
                int[] rowComparison = new int[sudokuData.Length];
                int[] columnComparison = new int[sudokuData.Length];

                for (int j = 0; j < sudokuData.Length; j++)
                {

                    if ((sudokuData[i][j] - 1) < 0 || sudokuData[i][j] - 1 >= sudokuData.Length ||
                        sudokuData[i][j] == rowComparison[sudokuData[i][j] - 1] || sudokuData[j][i] == columnComparison[sudokuData[j][i] - 1])
                    {
                        return false;
                    }
                    else
                    {
                        rowComparison[sudokuData[i][j] - 1] = sudokuData[i][j];
                        columnComparison[sudokuData[j][i] - 1] = sudokuData[j][i];
                    }
                }
            }

            int row = 0;

            for (int i = 0; i < Math.Sqrt(sudokuData.Length); i++)
            {
                int col = 0;
                for (int j = 0; j < Math.Sqrt(sudokuData.Length); j++)
                {
                    SudokuSquareValid(sudokuData, row, col);
                    col += (int)Math.Sqrt(sudokuData.Length) - 1;
                }

                row += (int)Math.Sqrt(sudokuData.Length) - 1;
            }

            return true;
        }

        public static bool SudokuSquareValid(int[][] data, int startRow, int startCol)
        {
            int[] squareComparison = new int[data.Length];

            for (int i = startRow; i < startRow + Math.Sqrt(data.Length); i++)
            {
                for (int j = startCol; j < startCol + Math.Sqrt(data.Length); j++)
                {
                    if (data[i][j] == squareComparison[data[i][j] - 1])
                    {
                        return false;
                    }

                    else
                    {
                        squareComparison[data[i][j] - 1] = data[i][j];
                    }
                }
            }

            return true;
        }
        public static void SudokuOutput(int[][] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((i % Math.Sqrt(data.Length) == 0) && i != 0)
                {
                    Console.WriteLine();
                }
                for (int j = 0; j < data.Length; j++)
                {
                    if (j % Math.Sqrt(data.Length) == 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write($"{data[i][j]},");
                }

                Console.WriteLine();

            }
        }
    }
}
