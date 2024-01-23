using System.Reflection;

namespace AdventOfCode_Day1_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FILE_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "", "InputDay1.txt");
            var calibrationDocument = FileReader.ReadValuesFromFile(FILE_PATH);
            var sum = calibrationDocument.CalibrationsValues.Select(x => x.CombinedValue).Sum();
            var updatedSum = calibrationDocument.CalibrationsValues.Select(x => x.UpdatedCombined).Sum();
            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"Updated sum is {updatedSum}");
            Console.WriteLine("Hello, World!");
        }
    }
}