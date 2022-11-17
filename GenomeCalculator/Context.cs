using System;
using GenomeCalculator.Interface;

//This nuget/library was developed according to the Strategy design pattern-
namespace GenomeCalculator
{
    public class Context
    {
        private ICalculate calculator;

        public Context(ICalculate operation)
        {
            calculator = operation;
        }

        public double execute(string filepath)
        {
            return calculator.calc(filepath);
        }
    }
}
