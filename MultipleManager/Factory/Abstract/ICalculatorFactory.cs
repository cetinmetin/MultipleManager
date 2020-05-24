using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleManager.Factory.Abstract
{
    public interface ICalculatorFactory
    {
        ICalculate CreateResultForAddition();
        ICalculate CreateResultForSubtraction();
        ICalculate CreateResultForMultiplication();
        ICalculate CreateResultForDivision();
    }
}
