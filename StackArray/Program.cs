using System;
using System.Collections;

namespace StackArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("Elma");
            stack.Push("Armut");
            stack.Push("Erik");
            //Example 1
            Stack[] array = new Stack[3];
            array[0] = stack;
            array[1] = stack;
            array[2] = stack;

            //Example 2
            Stack[] array2 = { stack, stack, stack };
            foreach (var arr in array2)
            {
                foreach (var item in arr)
                {
                    Console.WriteLine(item);

                }

            }
        }
    }
}
