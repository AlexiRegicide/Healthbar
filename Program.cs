using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthbar
{
    /// <summary>
    /// Обычный healthbar и manabar
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 5; 
            int maxHealth = 10;

            int mana = 7;
            int maxMana = 10;

            while(true)
            {
                DrawBar(health, maxHealth, ConsoleColor.Green, 0, '|') ; // отрисовка здоровья 
                DrawBar(mana, maxMana, ConsoleColor.Blue, 1); // отрисовка маны

                Console.SetCursorPosition(0, 5);
                Console.Write("Введите число, на которе изменятся жизни: ");
                health += Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число, на которое изменится мана: ");
                mana += Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
                Console.Clear();

            }
        }

        static void DrawBar(int value, int maxValue, ConsoleColor color, int position, char symbol = '_')
        {
            // запомнить цвет консоли 
            ConsoleColor def = Console.BackgroundColor;

            // строка с элементами
            string bar = "";
            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }

            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = def;

            bar = "";

            // отрисовка пустных (черных) пробелов
            for (int i = value; i < maxValue; i++)
            {
                bar += symbol;
            }

            Console.Write(bar + ']');
        }
    }
}