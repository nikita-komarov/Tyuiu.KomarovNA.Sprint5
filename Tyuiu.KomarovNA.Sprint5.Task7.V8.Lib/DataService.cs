using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KomarovNA.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {
            string str = File.ReadAllText(path);
            File.WriteAllText(Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V8.txt"), str);
            return str.ToLower();
        }
    }
}
