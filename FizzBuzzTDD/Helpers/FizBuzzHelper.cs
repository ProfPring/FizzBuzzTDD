using FizzBuzzTDD.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTDD.Helpers
{
    public class FizBuzzHelper : IFizBuzzHelper
    {
        public string IsDivisibleByFive(int number)
        {
            throw new NotImplementedException();
        }

        public string IsDivisibleByThree(int number)
        {
            if (number % 3 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }

        public string IsDivisiblebyThreeAndFive(int number)
        {
            throw new NotImplementedException();
        }
    }
}
