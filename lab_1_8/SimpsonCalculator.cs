using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_8
{
    public class SimpsonCalculator : ICalculatorIntegral
    {
        public double Calculate(double upper, double lower, int count, Func<double, double> fun)
        {
            double h = (upper - lower) / count;
            double sum = fun(lower) + fun(upper);
            for (int i = 1; i < count; i++)
            {
                double x = lower + i * h;
                if (i % 2 == 0)
                {
                    sum += 2 * fun(x);
                }
                else
                {
                    sum += 4 * fun(x);
                }
            }
            return (h / 3) * sum;

        }
    }
}
