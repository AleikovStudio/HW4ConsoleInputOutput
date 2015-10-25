using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Please write your 1st number \"a\":");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Please write your 2nd number \"b\":");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Please write your 3rd number \"c\":");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("|{0, -10:X}|{1, 10}|{2, 10:F2}|{3, -10:F3}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
    }
}
