using MultipleManager.Factory.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleManager
{
    public static class CalculatorScreen
    {
        public static void UI()
        {
            Console.Clear();
            int numberOfNumbers = 0;
            Console.Write("İşlem yapmak istediğiniz sayi adedi: ");
            numberOfNumbers = int.Parse(Console.ReadLine());
            int[] values = new int[numberOfNumbers];
            for (int i = 0; i < numberOfNumbers; i++)
            {
                Console.Write("{0}. Sayi: ", i + 1);
                values[i] = int.Parse(Console.ReadLine());
            }
            int islem = MainScreen.MultipleChoice(4, "Toplama İslemi", "Cikarma İslemi", "Carpma İslemi", "Bolme İslemi");
            if (islem == 0)
            {
                Calculator calculator = new Calculator(new CalculatorFactory());
                calculator.Addition(values);
            }
            else if (islem == 1)
            {
                Calculator calculator = new Calculator(new CalculatorFactory());
                calculator.Subtraction(values);
            }
            else if (islem == 2)
            {
                Calculator calculator = new Calculator(new CalculatorFactory());
                calculator.Multiplication(values);
            }
            else if (islem == 3)
            {
                Calculator calculator = new Calculator(new CalculatorFactory());
                calculator.Division(values);
            }
        }
    }
}
