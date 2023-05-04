using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCEx
{
    internal class TipCalculatorController
    {

        private Tip tip;
        private Display display; 

        public TipCalculatorController()
        {
            display = new Display();
            tip = new Tip(display.Amt, display.Percentage);
            display.TipAmount = tip.CalculateTip();
            display.Total = tip.CalculateTotal();
            display.ShowTipandTotal();
        }

    } // end class
} // end namespace
