using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Task5.Tools
{
    public static class StatisticsInfoSaver
    {
        // TEMPORARY DECISION DELETE AFTER USE

        public static void LoadStatistic()
        {
            string fileName = Properties.Settings.Default.StatisticInfoSaverFileName;

            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) +
                "\\" + fileName;

            if (!File.Exists(path))
            {
                throw new FileNotFoundException("The system cannot find the file", path);
            }

            List<int> list = new List<int>();

            int arraySize = -1;

            using (StreamReader streamReader = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;

                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] substrings = line.Split(' ');

                    if (arraySize == -1) // size initialization
                    {
                        if (!Int32.TryParse(substrings[0], out arraySize))
                        {
                            throw new InvalidCastException("File content not valid");
                        }
                        else
                        {
                            continue;
                        }
                    }

                    for (int i = 0; i < substrings.Length; i++)
                    {
                        int tmp;

                        if (!Int32.TryParse(substrings[i], out tmp))
                        {
                            throw new InvalidCastException("File content not valid");
                        }

                        list.Add(tmp);
                    }
                }
            }
        }
    }
}
