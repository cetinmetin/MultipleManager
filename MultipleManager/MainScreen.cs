using MultipleManager.Factory.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleManager
{
    class MainScreen
    {
        public static void Main(string[] args)
        {
            string tercih;
            do
            {
                int secenek = MultipleChoice(3, "Hesap Makinesi", "Faktoriyel Hesaplayıcı", "Veritabanı Yöneticisi");
                if (secenek == 0)
                {
                    CalculatorScreen.UI();
                }
                if (secenek == 1)
                {
                    FactorialScreen.UI();
                }
                if (secenek == 2)
                {
                    DatabaseScreen.UI();
                }
                Console.Write("Devam etmek istiyor musunuz?(E/H): ");
                tercih = Console.ReadLine();
            } while (tercih.ToLower() == "e");
        }

        public static int MultipleChoice(int numberOfOptions, params string[] options)
        {
            const int startX = 0;
            const int startY = 2;
            int optionsPerLine = numberOfOptions;
            int currentSelection = 0;
            ConsoleKey key;
            Console.CursorVisible = false;

            do
            {
                Console.Clear();
                Console.Write("******Çalıştırmak İstediğiniz Programı Seçin******\nCikmak İcin ESC ye Basin\n");

                for (int i = 0; i < options.Length; i++)
                {
                    Console.SetCursorPosition(startX + 0, startY + i);

                    if (i == currentSelection)
                        Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine(options[i]);

                    Console.ResetColor();
                }

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (currentSelection % optionsPerLine > 0)
                                currentSelection--;
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (currentSelection % optionsPerLine < optionsPerLine - 1)
                                currentSelection++;
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            return -1;
                        }
                }
            } while (key != ConsoleKey.Enter);

            Console.CursorVisible = true;
            return currentSelection;
        }
    }
}
