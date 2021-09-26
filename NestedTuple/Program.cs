using System;

namespace NestedTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            //create nested tuple
            var numbers = Tuple.Create(1, 2, 3, Tuple.Create(4, 5, 6, 7), 8, 9, 10, 11);
        }
    }
}
