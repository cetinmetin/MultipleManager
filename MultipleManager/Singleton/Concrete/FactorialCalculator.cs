using MultipleManager.Singleton.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleManager
{
    class FactorialCalculator:IFactorial
    {
        private static FactorialCalculator _factorialCalculator;
        private FactorialCalculator()
        {
        }
        public static FactorialCalculator CreateAsSingleton()
        {
            return _factorialCalculator ?? (_factorialCalculator = new FactorialCalculator());
        }
        public void Calculate(int value)
        {
            int result = 1;
            for(int count = 1; count <= value; count++)
            {
                result *= count;
            }
            Console.WriteLine(result);
        }

    }
}
