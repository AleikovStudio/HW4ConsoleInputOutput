using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Please write the first number to compare: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("Please write the second number to compare: ");
        double secondNumber = double.Parse(Console.ReadLine());

        double compareNumbers = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("Number {0} is greater",compareNumbers);
    }
}