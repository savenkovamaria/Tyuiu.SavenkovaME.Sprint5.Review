using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SavenkovaME.Sprint5.TaskReview.V4.Lib
{
    public class DataService : ISprint5Task7V4
    {
        public string LoadDataAndSave(string path)
        {
            string pathSave = @"C:\DataSprint5\OutPutDataFileTask7V4.txt";
            FileInfo fileinfo = new FileInfo(pathSave);
            bool exists = fileinfo.Exists;
            string text = File.ReadAllText(path);
            char[] res = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                char sym = text[i];
                if ((sym >= 'А' && sym <= 'Я') || (sym >= 'а' && sym <= 'я'))
                {
                    res[i] = '#';
                }
                else
                {
                    res[i] = sym;
                }
            }
            using (StreamWriter writer = new StreamWriter(pathSave))
            {
                writer.Write(res);
            }
            return pathSave;
        }
    }
}
