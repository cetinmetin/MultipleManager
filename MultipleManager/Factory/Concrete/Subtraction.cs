using MultipleManager.Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleManager.Factory.Concrete
{
    public class Subtraction : ICalculate
    {
        public void Calculate(params int[] values)
        {
            int result = values[0];
            for(int i = 1; i < values.Length; i++)
            {
                result -= values[i];
            }
            Console.WriteLine(result);
        }
    }
}
