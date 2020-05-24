using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleManager
{
    public static class FactorialScreen
    {
        public static void UI()
        {
            Console.Clear();
            int number;
            Console.Write("Faktoriyel Hesabı Yapılacak Sayı: ");
            number = int.Parse(Console.ReadLine());
            var factorialCalculator = FactorialCalculator.CreateAsSingleton();
            factorialCalculator.Calculate(number);
        }
    }
}
