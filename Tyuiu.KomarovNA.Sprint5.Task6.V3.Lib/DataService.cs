using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KomarovNA.Sprint5.Task6.V3.Lib
{
    public class DataService : ISprint5Task6V3
    {
        public int LoadFromDataFile(string path)
        {
            int result = Regex.Matches(File.ReadAllText(path), @"[А-Яа-я]").Count;
            return result;
        }
    }
}
