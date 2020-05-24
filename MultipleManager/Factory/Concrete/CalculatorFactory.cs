using MultipleManager.Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleManager.Factory.Concrete
{
    public class CalculatorFactory:ICalculatorFactory
    {
        public ICalculate CreateResultForAddition()
        {
            return new Addition();
        }

        public ICalculate CreateResultForSubtraction()
        {
            return new Subtraction();
        }

        public ICalculate CreateResultForMultiplication()
        {
            return new Multiplication();
        }

        public ICalculate CreateResultForDivision()
        {
            return new Division();
        }
    }
}
