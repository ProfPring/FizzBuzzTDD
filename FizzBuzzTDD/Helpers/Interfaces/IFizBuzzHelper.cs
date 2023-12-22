using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTDD.Helpers.Interfaces
{
    public interface IFizBuzzHelper
    {
        public string IsDivisibleByThree(int number);


        public string  IsDivisibleByFive(int number);


        public string IsDivisiblebyThreeAndFive(int number);
    }
}
