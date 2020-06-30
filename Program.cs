using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 7,4,7,9,0};
            var sorter = new BubbleSort();
            sorter.Numbers = numbers;
            sorter.sort(); 
            Console.WriteLine("[{0}]", string.Join(", ", sorter.Numbers));
        }
    }
}
