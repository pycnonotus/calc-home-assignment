using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{

    public delegate double PerformMathCalculation(double x, double y);
    /// <summary>
    /// A Basic Calculator resposable for calculating the 4 basic math operations ( + , - , * , /)
    /// </summary>
    public class MathSolver
    {

        private Dictionary<char, PerformMathCalculation> mathResolverMethods = new();

        public MathSolver()
        {
            InitializeMathResolverMethods();
        }

        protected void RegisterMathResolverForOperator(char matOperator, PerformMathCalculation method)
        {
            if (mathResolverMethods.TryGetValue(matOperator, out var _))
            {
                throw new InvalidOperationException($"There is already a mathResolverMethods for {matOperator}");
            }
            mathResolverMethods.Add(matOperator, method);
        }

        private void InitializeMathResolverMethods()
        {
            mathResolverMethods.Add('+', Addition);
            mathResolverMethods.Add('-', Subtract);
            mathResolverMethods.Add('*', Multiply);
            mathResolverMethods.Add('/', Divide);
        }

        public double PerformMathCalculation(double x, char mathOperator, double y)
        {
            if (!mathResolverMethods.TryGetValue(mathOperator, out var method))
            {
                throw new ArgumentException($"Operator {mathOperator} is not supported.");
            }
            return method(x, y);
        }
        private static double Divide(double x, double y)
        {
            if (y == 0) throw new ArgumentException(" can't divide by zero");
            return x / y;
        }

        private static double Multiply(double x, double y) => x * y;
        private static double Subtract(double x, double y) => x - y;
        private static double Addition(double x, double y) => x + y;
    }
}