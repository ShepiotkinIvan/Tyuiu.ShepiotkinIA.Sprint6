using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.ShepiotkinIA.Sprint6.Task6.V19.Lib
{
    public class DataService : ISprint6Task6V19
    {
        public string CollectTextFromFile(string str, string path)
        {
            string res = "";
            string[] strPath = File.ReadAllLines(path);
            for (int i = 0; i < strPath.Length; i++)
            {
                string[] lastStr = strPath[i].Split(' ');
                foreach (string word in lastStr)
                {
                    if (word.ToLower().Contains("l"))
                    {
                        res += word + " ";
                    }
                }
            }
            return res.Trim();
        }
    }
}
