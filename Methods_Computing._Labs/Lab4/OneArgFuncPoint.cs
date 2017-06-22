using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    struct OneArgFuncPoint
    {
        public double Arg;
        public double Func;

        public OneArgFuncPoint(double arg, double valueFunc)
        {
            Arg = arg;
            Func = valueFunc;
        }
    }
}
