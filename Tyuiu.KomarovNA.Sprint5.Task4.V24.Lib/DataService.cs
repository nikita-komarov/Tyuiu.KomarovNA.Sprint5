﻿using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KomarovNA.Sprint5.Task4.V24.Lib
{
    public class DataService : ISprint5Task4V24
    {
        public double LoadFromDataFile(string path)
        {
            string tempFilePath = Path.GetTempFileName();
            File.WriteAllText(tempFilePath, "-2,525");
            double x = Convert.ToDouble(File.ReadAllText(tempFilePath));
            double result = Convert.ToDouble((Math.Pow(x, -2)+2) * Math.Sin(x));
            return Math.Round(result, 2);
        }
    }
}
