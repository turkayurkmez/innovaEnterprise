using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public string Play(int value)
        {
            if (value % 5 == 0 && value %3 ==0)
            {
                return "FizzBuzz";
            }
            if (value % 5 == 0)
            {
                return "Buzz";
            }
            else if (value % 3 == 0)
            {
                return "Fizz";
            }


            return value.ToString();


        }
    }
}
