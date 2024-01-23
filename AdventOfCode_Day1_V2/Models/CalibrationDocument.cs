using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_Day1_V2.Models
{
    public class CalibrationDocument
    {
        public List<CalibrationValue> CalibrationsValues {  get; set; }

        public CalibrationDocument()
        {
            CalibrationsValues = new List<CalibrationValue>();
        }
    }
}
