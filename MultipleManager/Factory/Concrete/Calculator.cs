using MultipleManager.Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleManager.Factory.Concrete
{
    public class Calculator
    {
        private ICalculatorFactory _calculatorFactory;
        public Calculator(ICalculatorFactory calculatorFactory)
        {
            _calculatorFactory = calculatorFactory;
        }
        public void Addition(params int[] values)
        {
            ICalculate calculate = _calculatorFactory.CreateResultForAddition();
            calculate.Calculate(values);
        }
        public void Subtraction(params int[] values)
        {
            ICalculate calculate = _calculatorFactory.CreateResultForSubtraction();
            calculate.Calculate(values);
        }
        public void Multiplication(params int[] values)
        {
            ICalculate calculate = _calculatorFactory.CreateResultForMultiplication();
            calculate.Calculate(values);
        }
        public void Division(params int[] values)
        {
            ICalculate calculate = _calculatorFactory.CreateResultForDivision();
            calculate.Calculate(values);
        }
    }
}
