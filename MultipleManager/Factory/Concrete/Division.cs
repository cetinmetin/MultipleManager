using MultipleManager.Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleManager.Factory.Concrete
{
    public class Division : ICalculate
    {
        public void Calculate(params int[] values)
        {
            float result = 1;
            for(int i = 0; i < values.Length; i++)
            {
                result /= values[i];
            }
            Console.WriteLine(result);
        }
    }
}
