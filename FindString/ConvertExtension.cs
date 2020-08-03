using System.Collections.Generic;
using System.Globalization;

namespace FindString
{
    public static class ConvertExtension
    {
        public static List<double> ConvertToDouble(this string line)
        {
            List<double> result = new List<double>();
            double value;
            foreach (var element in line.Split(','))
            {
                if (!double.TryParse(element, System.Globalization.NumberStyles.Any, CultureInfo.CurrentCulture, out value) &&
                    !double.TryParse(element, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out value))
                {
                    return null;
                }
                result.Add(value);
            }

            return result;
        }
    }
}
