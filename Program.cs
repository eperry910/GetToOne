using System;
namespace GetToOne;
public class changeToOne
{
    public static int reduceToOne(int startingNum)
    {
        int steps = 0;
        while (startingNum != 1)
        {
            startingNum = startingNum % 2 == 0 ? startingNum / 2 : (startingNum * 3) + 1;
            Console.WriteLine($"New number to evaluate: {startingNum}");
            steps++;
        }
        return steps;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(reduceToOne(15));
    }
}