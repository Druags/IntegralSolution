using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLibrary
{
    public class TrapCalculator : ICalculator
    {
        public double Calculate(double a, double b, long n, Func<double, double> f)
        {
            double h = (b - a) / n;

            double sum = 0;
            if (n < 0)
            {
                return sum;
            }
            for (int i = 1; i < n; i++)
            {
                sum += f(a + h * i);
            }

            sum += (f(a) + f(b)) / 2;

            return sum * h;
        }
    }
}