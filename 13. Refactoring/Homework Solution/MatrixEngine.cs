using System;
using System.Linq;

namespace Matrics
{
    public class MatrixEngine
    {
        private const int MaxSize = 100;
        private IConsole console;
        private int size;
        private int[,] matrix;
        private int[,] movements = { { 1, 1 }, { 1, 0 }, { 1, -1 }, { 0, -1 }, { -1, -1 }, { -1, 0 }, { -1, 1 }, { 0, 1 } };
        private int row;
        private int column;
        private int direction;

        public MatrixEngine(IConsole console, int size)
        {
            this.console = console;
            this.Size = size;
            matrix = new int[this.Size, this.Size];
            this.row = 0;
            this.column = 0;
            this.direction = 0;
        }

        public int Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < 1 || value > MaxSize)
                {
                    throw new ArgumentOutOfRangeException("Matrix sie should be between 0 and " + MaxSize);
                }

                this.size = value;
            }
        }

        private bool IsCellInRange(int searchedRow, int searchedColumn)
        {
            bool isInRow = searchedRow >= 0 && searchedRow < this.Size;
            bool isInColumn = searchedColumn >= 0 && searchedColumn < this.Size;
            return isInRow && isInColumn;
        }

        private bool IsNextCellFree()
        {
            if (this.matrix[this.row, this.column] < 1)
            {
                return true;
            }

            int currentDirection = this.direction;
            do
            {
                int rowToCheck = this.row + movements[direction, 0];
                int columnToCheck = this.column + movements[direction, 1];
                if (IsCellInRange(rowToCheck, columnToCheck) && this.matrix[rowToCheck, columnToCheck] < 1)
                {
                    this.row = rowToCheck;
                    this.column = columnToCheck;
                    return true;
                }

                this.direction++;
                if (this.direction >= this.movements.GetLength(0))
                {
                    this.direction = 0;
                }
            }
            while (currentDirection != this.direction);

            for (this.row = 0; this.row < this.Size; this.row++)
            {
                for (this.column = 0; this.column < this.Size; this.column++)
                {
                    if (this.matrix[this.row, this.column] < 1)
                    {
                        this.direction = 0;
                        return true;
                    }
                }
            }

            return false;
        }

        public void PrintMatrix()
        {
            for (this.row = 0; this.row < this.Size; this.row++)
            {
                for (this.column = 0; this.column < this.Size; this.column++)
                {
                    console.Write(String.Format("{0,3}", this.matrix[this.row, this.column]));
                }

                console.WriteLine();
            }

            return;
        }

        public void Run()
        {
            int number = 1;
            while (this.IsNextCellFree())
            {
                this.matrix[this.row, this.column] = number;
                number++;
            }
        }
    }
}
