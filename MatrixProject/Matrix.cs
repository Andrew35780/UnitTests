using System.Collections.Generic;

namespace MatrixProject
{
    public class Matrix
    {
        private List<List<int>> matrix;

        public int RowsCount { get => matrix.Count; }
        public int ColumnsCount { get => matrix.Count; }

        public int this[int rowIndex, int columnIndex] => matrix[rowIndex][columnIndex];

        public Matrix(int rowsAndColumnsCount) => matrix = new List<List<int>>(rowsAndColumnsCount);

        public Matrix(List<List<int>> matrix) => this.matrix = matrix;


        public int CalculateProductOfNegativeElements()
        {
            int product = 1;

            for (int i = 0; i < matrix.Count; i++)
                for(int j = 0; j < matrix[i].Count; j++)
                    if (matrix[i][j] < 0)
                        product *= matrix[i][j];

            return product;
        }

        public int CalculateProductOfNegativeElementsInEvenRows()
        {
            int product = 1;

            for (int i = 0; i < matrix.Count; i++)
                if (i % 2 == 0 && i != 0)
                    for (int j = 0; j < matrix[i].Count; j++)
                        if (matrix[i][j] < 0)
                            product *= matrix[i][j];

            return product;
        }
    }
}
