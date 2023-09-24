using System;

public class Fibonacci
{
    public static void CalculateFibonacciSeriesAverage(int depth)
    {
        int  num1 = 0, num2 = 1;
        double sum = 1.0;

      //  Console.Write("Fibonacci Series: " + num1 + ", " + num2 + ", ");

        for (int i = 2; i < depth; i++)
        {
           
            int nextNum = num1 + num2;
         //   Console.Write(nextNum + ", ");
            sum = sum + nextNum;
           num1 = num2;
            num2 = nextNum;


        }
        //Console.Write("sum:" + sum);
        double avr = sum / depth;
        Console.Write("average is:" +avr );

    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the depth for Fibonacci series: ");
        int n = int.Parse(Console.ReadLine()+"");
        

        if (n < 1)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        Fibonacci.CalculateFibonacciSeriesAverage(n);
    }
}