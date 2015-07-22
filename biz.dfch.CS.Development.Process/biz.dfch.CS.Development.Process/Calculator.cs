using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biz.dfch.CS.Development.Process
{
    public class Calculator
    {
        public static object Add(Int32 summand1, Int32 summand2)
        {
            return summand1 + summand2;
        }

        public static object Subtract(Int32 minuend, Int32 subtrahend)
        {
            return minuend - subtrahend;
        }

        public static object Divide(Int32 dividend, Int32 divisor)
        {
            return dividend/divisor;
        }

        public static object Multiply(Int32 factor1, Int32 factor2)
        {
            return factor1*factor2;
        }
    }
}
