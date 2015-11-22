using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public static class Helper
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
    }
}
