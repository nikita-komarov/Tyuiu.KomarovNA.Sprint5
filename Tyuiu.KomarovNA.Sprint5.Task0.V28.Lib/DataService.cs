using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KomarovNA.Sprint5.Task0.V28.Lib
{
    public class DataService : ISprint5Task0V28
    {
        public string SaveToFileTextData(int x)
        {
            double res = Math.Round(x * Math.Sqrt(x + 3), 3);
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            File.WriteAllText(path, Convert.ToString(res));
            return path;
        }
    }
}
