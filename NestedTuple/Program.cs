using System;

namespace NestedTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            //create nested tuple
            var numbers = Tuple.Create(1, 2, 3, Tuple.Create(4, 5, 6, 7), 8, 9, 10, 11);

            //access the elements
            Console.WriteLine(numbers.Item1); // returns 1
            Console.WriteLine(numbers.Item2); // returns 2
            Console.WriteLine(numbers.Item3); // returns 3
            Console.WriteLine(numbers.Item4); // returns (4,5,6,7)
            Console.WriteLine(numbers.Item4.Item1); // returns 4
            Console.WriteLine(numbers.Item5); // returns 8
            Console.WriteLine(numbers.Rest.Item1); //returns 11
        }
    }
}
