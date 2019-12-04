using System;

namespace debuz_test_1_2
{
    class Program
    {
        static double pi = (double)22 / 7;
        static int index;
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number between 0-15 to display the digit at that position");
            LocateDigitAtIndex();

        }

        private static void LocateDigitAtIndex()
        {
            

            bool success = Int32.TryParse(Console.ReadLine(), out index);
            if (success)
            {
                if (index == 0)
                {
                    Console.WriteLine("The digit at index [" + index + "] is " + pi.ToString().ToCharArray().GetValue(index));
                    return;
                }
                if (index < 16)
                {
                    Console.WriteLine("The digit at index [" + index + "] is " + pi.ToString().ToCharArray().GetValue(index+1));
                }
                if (index >= 16)
                {
                    Console.WriteLine("Please enter a index between 0-15");
                    LocateDigitAtIndex();

                }
            } else
            {
                Console.WriteLine("Please just numericals between 0-15");
                LocateDigitAtIndex();
            }
        }
    }
}
