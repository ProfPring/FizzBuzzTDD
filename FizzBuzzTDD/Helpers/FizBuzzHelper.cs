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
        public bool IsDivisibleByFive(int number)
        {
            if (number % 5 == 0)
            {
                return true;
            }

            return false;
        }

        public bool IsDivisibleByThree(int number)
        {
            if (number % 3 == 0)
            {
                return true; 
            }

            return false;
        }

        public bool IsDivisiblebyThreeAndFive(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
