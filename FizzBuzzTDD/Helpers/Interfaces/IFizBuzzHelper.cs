using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTDD.Helpers.Interfaces
{
    public interface IFizBuzzHelper
    {
        public bool IsDivisibleByThree(int number);


        public bool  IsDivisibleByFive(int number);


        public bool IsDivisiblebyThreeAndFive(int number);
    }
}
