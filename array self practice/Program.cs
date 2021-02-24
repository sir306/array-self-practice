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

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("this is : {0}", array1[i]);
            }
            foreach (string item in array2)
            {
                Console.WriteLine("this is : {0}", item);
            }
            Console.WriteLine("Hello World!");

            string[,] multiString = new string[3, 3];
            multiString[0, 0] = "this";
            multiString[0, 1] = "is";
            multiString[0, 2] = "a";
            multiString[1, 0] = "multi";
            multiString[1, 1] = "array";
            multiString[1, 2] = "that";
            multiString[2, 0] = "i";
            multiString[2, 1] = "made";
            multiString[2, 2] = "!";
            
            foreach(string item in multiString)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
