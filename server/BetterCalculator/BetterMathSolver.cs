using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterCalculator
{
    /// <summary>
    /// An extended of the Basic Calculator responsible for calculating the 4 basic math operations ( + , - , * , /)
    /// And power (^)
    /// this is class is an example of open for extension, but closed for modification
    /// </summary>
    public class BetterMathSolver : Calculator.MathSolver
    {
        public BetterMathSolver()
        {
            InitializePerformMathCalculation();
        }

        private void InitializePerformMathCalculation()
        {
            // mathResolverMethods.Add('^', Power);
            this.RegisterMathResolverForOperator('^', Power);
        }
        private static double Power(double x, double y) => Math.Pow(x, y);
    }
}