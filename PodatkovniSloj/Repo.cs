using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodatkovniSloj
{
    public class Repo
    {



        public static string GetStringLineFromFile(int lineNumber, string filePath)
        {
            string line = null;
            using (var sr = new StreamReader(filePath))
            {

                for (int i = 0; i < lineNumber; ++i)
                {
                    if ((line = sr.ReadLine()) == null)
                    {
                        break;
                    }
                }

            }
            return line;
        }

        public static void SaveInfoToFile(string info, int lineNumber, string filePath)
        {
            try
            {
                string checknullLine = null;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    for (int i = 1; i <= lineNumber; ++i)
                        checknullLine = reader.ReadLine();
                }

                if (checknullLine == null)
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine(info);
                    }

                string[] lines = File.ReadAllLines(filePath);


                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                    {
                        if (currentLine == lineNumber)
                        {
                            writer.WriteLine(info);
                        }
                        else
                        {
                            writer.WriteLine(lines[currentLine - 1]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " Greška kod pisanja fajla!");
            }

        }
    }
}
