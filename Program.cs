using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter arr elemetns : ");

            string input = Console.ReadLine();
            int[] array = input.Split(' ')
                               .Select(int.Parse)
                               .ToArray();

            Array.Sort(array);

            Console.WriteLine("enter target : ");
            int target = int.Parse(Console.ReadLine());

            BinarySearch search = new BinarySearch();

            search.SearchParams(array, target);

            int result = search.PerformBinarySearch();
            if (result == -1)
            {
                Console.WriteLine("element not found");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("element index " + result);
                Console.ReadKey();
            }
        }
    }
}
