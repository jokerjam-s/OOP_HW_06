using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /**
     * История вычислений
     */

    public class CalcHistory
    {
        public String inputString {get; set;}

        public String result { get; set; }

        public CalcHistory(string inputString, string result)
        {
            this.inputString = inputString;
            this.result = result;
        }

        public override string? ToString()
        {
            return inputString + " = " + result;
        }
    }
}
