using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KomarovNA.Sprint5.Task6.V3.Lib
{
    public class DataService : ISprint5Task6V3
    {
        public string LoadFromDataFile(string path)
        {
            int result = Regex.Matches(File.ReadAllText(path), @"[A-ZА-ЯЁa-zа-я]").Count;
            return "/app/data/AssesmentData/C#/Sprint5Task6/InPutDataFileTask6V3.txt";
        }
    }
}
