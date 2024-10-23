using System;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KomarovNA.Sprint5.Task2.V10.Lib
{
    public class DataService : ISprint5Task2V10
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            if (File.Exists(path)) { File.Delete(path); }

            int matrixLen = matrix.GetLength(0);
            int submatrixLen = matrix.GetLength(1);
            int[,] newMatrix = new int[matrixLen, submatrixLen];
            for (int i = 0; i < matrixLen; i++)
            {
                for (int j = 0; j < submatrixLen; j++)
                {
                    newMatrix[i, j] = matrix[i, j] > 0 ? 1: 0;
                    Console.Write(newMatrix[i, j]);
                    File.AppendAllText(path, Convert.ToString(newMatrix[i, j]));
                }
                Console.WriteLine();
                File.AppendAllText(path, "\n");
            }
            return path;
        }
    }
}
