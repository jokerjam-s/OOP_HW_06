using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class UserView
    {
        public string getString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public void ShowInfo(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Нажмите клавишу...");
            Console.ReadKey();
        }

        public int ShowMenu()
        {
            Console.Clear();

            StringBuilder stringBuilder = new StringBuilder()
                .AppendLine("1 - провести вычисление")
                .AppendLine("2 - показать историю")
                .AppendLine("0 - выход")
                .Append(">");

            Console.Write(stringBuilder.ToString());
            int menu = Convert.ToInt32(Console.ReadLine());

            menu = menu < 0 || menu > 2 ? 0 : menu;

            return menu;
        }

        public void ShowHistory(List<CalcHistory> history)
        {
            Console.Clear();
            Console.WriteLine("История вычислений");

            foreach(CalcHistory cur in history)
            {
                Console.WriteLine(cur.ToString());
            }

            Console.WriteLine("нажмите клавишу ... ");
            Console.ReadKey();
        }
    }
}
