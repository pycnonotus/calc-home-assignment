using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BetterCalculator;
using Core.Interfaces;
using Domain;

namespace Infrastructure.Services
{
    public class MathResolver : IMathResolver
    {
        private readonly BetterCalculator.BetterMathSolver mathSolver;

        public MathResolver()
        {
            this.mathSolver = new();
        }

        public async Task<MathResultDto> ResolveMathQuestionAsync(MathQuestionDto mathQuestion)
        {
            var number = await Task.FromResult<double>(this.mathSolver.PerformMathCalculation(mathQuestion.X!.Value, mathQuestion.MathOperator!.Value, mathQuestion.Y!.Value)); // assuming some operations are heavy on the CPU like find the y-th diver of x
            return new MathResultDto(number);
        }
    }
}