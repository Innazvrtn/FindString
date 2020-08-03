using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FindString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LineWithElements> lines = new List<LineWithElements>();
            Console.WriteLine("Input path to file");
            string path = Console.ReadLine();


            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                int lineNumber = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(new LineWithElements(line, ++lineNumber));
                }
            }

            foreach (var line in lines)
            {
                line.CalculatedSum();
            }

            var result = lines.OrderByDescending(x => x.SumOfElements).Where(x => x.SumOfElements != null).FirstOrDefault();
            if (result != null)
            {
                Console.WriteLine("Max sum of elevent in " + result.LineNumber + " line");
            }
            else
            {
                Console.WriteLine("All lines with wrong format. Sum could not be found");
            }
            Console.WriteLine("Line with wrong format: ");
            foreach (var line in lines.Where(x => x.SumOfElements == null))
            {
                Console.WriteLine(line.LineNumber);
            }
            Console.ReadKey();
        }
    }
}
