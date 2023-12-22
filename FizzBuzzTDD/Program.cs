using FizzBuzzTDD.Helpers.Interfaces;
using FizzBuzzTDD.Helpers;

class Program
{
    static void Main()
    {
        IFizBuzzHelper fizBuzzHelper = new FizBuzzHelper();

        for (int i = 1; i <= 100; i++)
        {
            if (fizBuzzHelper.IsDivisiblebyThreeAndFive(i))
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (fizBuzzHelper.IsDivisibleByThree(i))
            {
                Console.WriteLine("Fizz");
            }
            else if (fizBuzzHelper.IsDivisibleByFive(i))
            {
                Console.WriteLine("Buzz");
            }
            else 
            {
                Console.WriteLine(i);
            }   
        }
    }
}
