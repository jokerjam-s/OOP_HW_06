using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.Expressions;

namespace Calculator
{
    public class Controller
    {
        UserView userView = new UserView();
        List<CalcHistory> history = new List<CalcHistory>();

        public void Run()
        {
            int menu = 1;
            while (menu > 0)
            {
                menu = userView.ShowMenu();

                switch(menu)
                {
                    // вычисление 
                    case 1:
                        String eval = userView.getString("Введите выражение: ");
                        double result = Eval.Execute<double>(eval);

                        CalcHistory calcResult = new CalcHistory(eval, result.ToString());
                        history.Add(calcResult);

                        userView.ShowInfo(calcResult.ToString());
                        break;

                    // history
                    case 2:
                        userView.ShowHistory(history); 
                        break;
                        
                }
            }
        }
    }
}
