using System.Diagnostics;

namespace AgeToDays
{
    internal class FeelingOld
    {
        public static int CalcAge(int age)      // Always ensure capital letters in method heading
        {
            int days = age * 365;     // Conversion of age into days
            return days;
        }

        static void Main()
        {
            Console.WriteLine(CalcAge(42));     // 42 x 365 = 15,330
            Console.WriteLine();

            Console.WriteLine(CalcAge(10));     // 10 x 365 = 3,650
            Console.WriteLine();

            Console.WriteLine(CalcAge(25));     // 25 x 365 = 9,125
            Console.WriteLine();
        }
    }
}