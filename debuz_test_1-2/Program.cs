using System;

namespace debuz_test_1_2
{
    class Program
    {
        static double pi = (double)22 / 7;
        static int index;
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number between 0-16 to display the digit at that position");
            LocateDigitAtIndex();

        }

        private static void LocateDigitAtIndex()
        {
            index = Int32.Parse(Console.ReadLine());
            if (index == 0)
            {
                Console.WriteLine(pi.ToString().ToCharArray().GetValue(index));
            }
            if (index < 17)
            {
                Console.WriteLine(pi.ToString().ToCharArray().GetValue(index + 1));
            }
            if (index >= 17)
            {
                Console.WriteLine("Please enter a index between 0-16");
                LocateDigitAtIndex();
                
            }
        }
    }
}
