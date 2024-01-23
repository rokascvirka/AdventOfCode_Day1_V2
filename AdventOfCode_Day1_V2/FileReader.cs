using AdventOfCode_Day1_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_Day1_V2
{
    public static class FileReader
    {
        public static CalibrationDocument ReadValuesFromFile(string filePath)
        {

            var calibrationDocument = new CalibrationDocument();
            
            using(StreamReader streamReader = new StreamReader(filePath))
            {
                var text = streamReader.ReadToEnd().Split(Environment.NewLine);
                foreach(var line in text)
                {
                    if(line != null)
                    {
                        calibrationDocument.CalibrationsValues.Add(new CalibrationValue(line));
                    }
                }
            }
            return calibrationDocument;
        }
    }
}
