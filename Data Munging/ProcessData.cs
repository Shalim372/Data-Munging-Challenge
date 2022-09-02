using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Munging
{
    public class ProcessData
    {
        public static string FindLowestData(string filePath, int firstColumn, int secondColumn, int returnColumn)
        {
            string finalValue = "";
            Double min = Double.MaxValue, col1, col2, col3, diff;

            try
            {
                IEnumerable<string> text = File.ReadAllLines(filePath);
                foreach (string line in text)
                {
                    string[] eachLine = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    if (eachLine.Length > 0 && Double.TryParse(eachLine[0].Replace(".", ""), out col1))
                    {
                        col2 = Convert.ToInt32(eachLine[firstColumn].Replace("*", ""));
                        col3 = Convert.ToInt32(eachLine[secondColumn].Replace("*", ""));
                        diff = Math.Abs(col2 - col3);

                        if (diff <= min)
                        {
                            min = diff;
                            finalValue = eachLine[returnColumn];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error processing data");
            }

            return finalValue;
        }
    }
}
