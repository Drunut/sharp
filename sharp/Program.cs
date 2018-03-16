using System;

namespace sharp
{
    class Program // Class
    {
        static void Main(string[] args) // primary run method, 'start method'
        {
            // Step 2
            Add(4, 8);
            // Step 3
            int result = Add(4, 8, 12);
            if (result > 10)
            {
                Console.WriteLine("Result is larger then 10!");
            }
            else
            {
                Console.WriteLine("Result is smaller than or equal to 10");
            }
            // Step 4


            Console.ReadKey();
        }

        // Step 2 //
        public static void Add(int num01, int num02)
        {
            Console.WriteLine(num01 + num02);
        }
        // Step 3 //
        public static int Add(int num01, int num02, int num03)
        {
            return (num01 + num02 + num03);
        }


    }
}
