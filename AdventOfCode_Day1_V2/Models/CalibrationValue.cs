using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_Day1_V2.Models
{
    public class CalibrationValue
    {
        public string Line { get; set; }
        public string FirstValue { get; set; }
        public string SecondValue { get; set; }
        public int CombinedValue {  get; set; }

        public string UpdatedLine { get; set; }
        public string UpdatedFirstValue { get; set; }
        public string UpdatedLastValue { get; set; }
        public int UpdatedCombined {  get; set; }


        public CalibrationValue(string line)
        {
            FirstValue = GetFirstValue(line);
            SecondValue = GetLastValue(line);
            CombinedValue = GetCombinedValue(FirstValue, SecondValue);
            UpdatedLine = ChangeValues(line);
            UpdatedFirstValue = GetFirstValue(UpdatedLine);
            UpdatedLastValue = GetLastValue(UpdatedLine);
            UpdatedCombined = GetCombinedValue(UpdatedFirstValue, UpdatedLastValue);
        }

        private static string ChangeValues(string line)
        {
            Dictionary<string, string> values = new Dictionary<string, string>()
            {
                {"nine", "9e" },
                {"eight", "e8t" },
                {"seven", "7n" },
                {"six", "6" },
                {"five", "5e" },
                {"four", "4" },
                {"three", "3e" },
                {"two", "2o" },
                {"one", "o1e" },
            };
            foreach (var value in values)
            {
                line = line.Replace(value.Key, value.Value);
            }
            return line;
        }

        private static string GetFirstValue(string line)
        {
            var values = line.Where(x => char.IsDigit(x)).ToList();
            if (values.Count > 0)
            {
                return values.First().ToString();
            }
            return string.Empty;
        }
        private static string GetLastValue(string line)
        {
            var values = line.Where(x => char.IsDigit(x)).ToList();
            if (values.Count > 0)
            {
                return values.LastOrDefault().ToString();
            }
            return string.Empty;
        }
        private static int GetCombinedValue(string first, string second)
        {
            if (!String.IsNullOrEmpty(first) || !String.IsNullOrEmpty(second))
            {
                return int.Parse(first + second);
            }
            return 0;
        }
    }
}
