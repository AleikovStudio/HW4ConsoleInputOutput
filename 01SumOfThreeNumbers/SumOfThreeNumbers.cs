using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Please write your first number: ");
        string numberOne = Console.ReadLine();
        double numberOneP = double.Parse(numberOne);

        Console.Write("Please write your second number: ");
        string numberTwo = Console.ReadLine();
        double numberTwoP = double.Parse(numberTwo);

        Console.Write("Please write your third number: ");
        string numberThree = Console.ReadLine();
        double numberThreeP = double.Parse(numberThree);
        
        Console.WriteLine("The sum of the three numbers is: " + (numberOneP + numberTwoP + numberThreeP));

    }
}