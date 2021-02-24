using System;


namespace ArraySelfPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6 };
            string[] array2 = { "hello", "bye" };

            foreach (int item in array1)
            {
                Console.WriteLine("this is : {0}", item);
            }
            foreach (string item in array2)
            {
                Console.WriteLine("this is : {0}", item);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
