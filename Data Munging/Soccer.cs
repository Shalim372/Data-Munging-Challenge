using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Munging
{
    public class Soccer
    {
        public string TeamWithSmallDiff() 
        { 
            string team = null;
            double col1, col2, col3, diff, min = Double.MaxValue;
            string[] eachLine;
            //Replace with corresponding file path
            IEnumerable<String> text = File.ReadLines(@"S:\New folder\football.dat");

            foreach (string line in text)
            {
                eachLine = line.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (eachLine.Length > 0 && Double.TryParse(eachLine[0].Replace(".",""), out col1))
                {
                    col2 = Convert.ToDouble(eachLine[6]);
                    col3 = Convert.ToDouble(eachLine[8]);
                    diff = Math.Abs(col3 - col2);
                    if (diff < min)
                    {
                        min = diff;
                        team = eachLine[1];
                    }
                }
            }           
            return team;
        }
    }
        
    
}
