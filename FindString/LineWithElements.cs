using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindString
{
    public class LineWithElements
    {
        public string LineOfElements { get; set; }
        public int LineNumber { get; set; }

        public double? SumOfElements { get;private set; }

        public LineWithElements(string line, int lineNumber)
        {
            LineOfElements = line;
            LineNumber = lineNumber;
        }

        public void CalculatedSum()
        {
            var convert = LineOfElements.ConvertToDouble();
            if (convert == null)
            {
                SumOfElements = null;
            }
            else
            {
                SumOfElements = convert.Sum();
            }

        }
    }
}
