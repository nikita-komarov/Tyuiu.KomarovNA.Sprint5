using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KomarovNA.Sprint5.Task1.V3.Lib
{
    public class DataService : ISprint5Task1V3
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            if (File.Exists(path)) { File.Delete(path); }

            double res;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i + 2.5 == 0)
                {
                    File.AppendAllText(path, "0\n");
                    continue;
                }
                res = Math.Round(Math.Cos(2 * i) + (Math.Sin(i)/(i+2.5)) + 2*i, 2);
                File.AppendAllText(path, Convert.ToString(res) + "\n");
            }
            return path;
        }
    }
}
