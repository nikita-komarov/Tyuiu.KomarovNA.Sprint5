using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KomarovNA.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {
            string str = File.ReadAllText(path);

            StringBuilder result = new StringBuilder(str.Length);

            foreach (char c in str)
            {
                if (c >= 'А' && c <= 'Я')
                {
                    result.Append((char)(c + 'а' - 'А'));
                }
                else 
                { 
                    result.Append(c);
                }
            }

            File.WriteAllText(Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V8.txt"), result.ToString());
            return result.ToString();
        }
    }
}
