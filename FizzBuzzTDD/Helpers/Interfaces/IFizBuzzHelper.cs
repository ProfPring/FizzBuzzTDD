using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTDD.Helpers.Interfaces
{
    public interface IFizBuzzHelper
    {
        public string IsDivisibleByThree();


        public string  IsDivisibleByFive();


        public string IsDivisiblebyThreeAndFive();
    }
}
