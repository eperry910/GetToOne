using System;
namespace GetToOne;
public class changeToOne
{
    public static int reduceToOne(int startingNum)
    {
        while (startingNum != 1)
        {
            startingNum = startingNum % 2 == 0 ? startingNum / 2 : (startingNum * 3) + 1;
            Console.WriteLine($"New number to evaluate: {startingNum}");
        }
        return startingNum;
    }
    public static void Main(string[] args)
    {
        reduceToOne(15);
    }
}