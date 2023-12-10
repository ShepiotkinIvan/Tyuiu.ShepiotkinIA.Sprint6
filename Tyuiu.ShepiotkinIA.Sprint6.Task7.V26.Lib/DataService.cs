using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShepiotkinIA.Sprint6.Task7.V26.Lib
{
    public class DataService : ISprint6Task7V26

    {
        public int[,] GetMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, 1] > 5)
                {
                    matrix[i, 1] = 222;
                }
            }
            return matrix;
        }
    }
}
