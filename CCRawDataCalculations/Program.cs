using System;

namespace CCRawDataCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            CCRawDataErrorFilteringByInstruments.CCTestFiltering(10);
            Console.WriteLine("This is the end");
            Console.ReadKey();
        }
    }
}
