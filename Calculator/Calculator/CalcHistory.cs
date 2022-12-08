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

    internal class CalcHistory
    {
        private String inputString { get; set; }

        private string result { get; set; }

        public CalcHistory() { }

        public CalcHistory(String inputString ) 
        { 
            this.inputString = inputString;
        }
    }
}
