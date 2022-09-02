using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Data_Munging
{
    public class Weather
    {     
        public int WeatherDayMin()
        {
            int day = 0;
            double col1, col2, col3, min = Double.MaxValue, diff;
            string[] eachLine;
            //Replace with corresponding file path
            IEnumerable<String> text = File.ReadLines(@"S:\New folder\weather.dat");
            
            foreach (string line in text)
            {
                eachLine = line.Trim().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                if (eachLine.Length>0 && Double.TryParse(eachLine[0],out col1))
                {
                    col2 = Convert.ToInt32(eachLine[1].Replace("*",""));
                    col3 = Convert.ToInt32(eachLine[2].Replace("*",""));
                    diff = Math.Abs(col2 - col3);
                    if (diff < min)
                    {
                        min = diff;
                        day = Convert.ToInt32(col1);
                    }                    
                }
            }
            return day;
        }
    }
}
