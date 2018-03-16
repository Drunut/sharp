using System;

namespace sharp
{
    class Program // Class
    {
        static void Main(string[] args) // primary run method, 'start method'
        {
            // Arrays, man.
            int[] numbers = new int[5]; //creates an empty object (in this case, an array) of five ints
            numbers[0] = 12; // Sets first element to 12
            numbers[1] = 3;
            numbers[2] = 5; // The rest default to 0

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadKey();
        }
    }
}
