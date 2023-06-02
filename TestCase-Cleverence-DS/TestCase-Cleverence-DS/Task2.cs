using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCase_Cleverence_DS
{
    internal class Task2
    {
        /*
         int[,] matrix1 = new int[3, 3] {
            {1, 2, 3 },
            {4, 5, 6 },
            {7, 8, 9 }
        };
         */
        public static int[] Spiralize(int width, int height, int[,] matrix)
        {
            if (matrix.Length == 0)
                return new int[0];

            int resultSize = matrix.Length;

            int[] result = new int[resultSize];

            bool isItTheEnd = false;
            int startTopIndex_i = 0;
            int endTopIndex_i = height - 1;
            int startTopIndex_j = 0;
            int endTopIndex_j = width - 1;
            int currentIndex = 0;
            while (!isItTheEnd)
            {
                for (int i = startTopIndex_i; i <= endTopIndex_i && currentIndex != resultSize; i++)
                {
                    result[currentIndex] = matrix[i, startTopIndex_j];
                    currentIndex++;
                }

                startTopIndex_j++;

                for (int j = startTopIndex_j; j <= endTopIndex_j && currentIndex != resultSize; j++)
                {
                    result[currentIndex] = matrix[endTopIndex_i, j];
                    currentIndex++;
                }

                endTopIndex_i--;

                for (int i = endTopIndex_i; i >= startTopIndex_i && currentIndex != resultSize; i--)
                {
                    result[currentIndex] = matrix[i, endTopIndex_j];
                    currentIndex++;
                }

                endTopIndex_j--;

                for (int j = endTopIndex_j; j >= startTopIndex_j && currentIndex != resultSize; j--)
                {
                    result[currentIndex] = matrix[startTopIndex_i, j];
                    currentIndex++;
                }

                startTopIndex_i++;

                if (currentIndex == resultSize)
                {
                    isItTheEnd = true;
                }
            }

            return result;
        }
    }
}
