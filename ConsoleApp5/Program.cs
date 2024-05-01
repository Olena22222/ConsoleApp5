using System;

public delegate double CalcDelegate(double num1, double num2, char operation);

public class CalcProgram
{
    public static double Calc(double num1, double num2, char operation)
    {
        switch (operation)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                return num2 != 0 ? num1 / num2 : 0; 
            default:
                throw new ArgumentException("Invalid operation");
        }
    }

    public CalcDelegate funcCalc = new CalcDelegate(Calc);
}

class Program
{
    static void Main(string[] args)
    {
        CalcProgram calcProgram = new CalcProgram();

        Console.WriteLine("Enter first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter operation (+, -, *, /):");
        char operation = Convert.ToChar(Console.ReadLine());

        try
        {
            double result = calcProgram.funcCalc(num1, num2, operation);
            Console.WriteLine($"Result of {num1} {operation} {num2} = {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
