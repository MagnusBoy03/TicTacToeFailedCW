using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CourseWork
{
    internal class HighScore
    {
        Dictionary<string, int> highscore = new Dictionary<string, int>();
        public string text;
        string filePath = @"../../../../HighScore.txt";
        public HighScore() 
        {
            ReadFrom();
            text = InsertInOneFile();
            
        }
        public void ReadFrom()
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] temp = line.Split(' ');
                    highscore.Add(temp[0], int.Parse(temp[1]));
                }
                reader.Close();
            }
            
        }

        public void Clean()
        {
            File.WriteAllText(filePath, string.Empty);
        }

        public void WriteTo()
        {
            using(StreamWriter writer = new StreamWriter(filePath)) 
            {
                foreach(var temp in highscore)
                {
                    writer.WriteLine($"{temp.Key} {temp.Value}");
                }
                writer.Close();
            }
        }
        public void IncreaseScore(string name)
        {
            if(highscore.ContainsKey(name))
            {
                highscore[name]++;
            }
            else
            {
                highscore.Add(name, 1);
            }
            Clean();
            WriteTo();
        }
        public string InsertInOneFile()
        {
            string bigText = File.ReadAllText(filePath);
            return bigText;
        }
    }
}
