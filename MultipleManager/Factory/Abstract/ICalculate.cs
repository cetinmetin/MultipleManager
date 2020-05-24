using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleManager.Factory.Abstract
{
    public interface ICalculate
    {
        void Calculate(params int[] values);
    }
}
