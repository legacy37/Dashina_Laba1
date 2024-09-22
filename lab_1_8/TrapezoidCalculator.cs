using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_8
{
    public class TrapezoidCalculator : ICalculatorIntegral
    {
        public double Calculate(double upper, double lower, int count, Func<double, double>fun)
        {
            double h = (upper - lower) / count;
            double answerTrapezoid = 0;
            double x0 = lower;
            for(int i = 0; i < count; i++)
            {
                x0 += h;
                answerTrapezoid += fun(x0);
            }
            answerTrapezoid += (fun(upper) - fun(lower)) / 2;
            answerTrapezoid *= h; 
            return answerTrapezoid;
        }
    }
}
