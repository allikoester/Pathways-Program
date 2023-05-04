using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCEx
{
    internal class Tip
    {
        private double amount;
        private double tipPercent;

        public Tip()
        {
            Amount = 0;
            TipPercent = 0; 
        }

        public Tip(double amount, double percent)
        {
            Amount = amount;
            TipPercent = percent;
        }

        public double Amount
        { 
            get { return amount; }
            set { amount = value; }
        }

        public double TipPercent 
        { 
            get {  return tipPercent; } 
            set {  if (value > 1)
                {
                    value /= 100;
                }
                tipPercent = value; 
            }
        }

        public double CalculateTip()
        {
            return Amount * TipPercent;
        }

        public double CalculateTotal()
        {
            return CalculateTip() + Amount; 
        }



    } // end class
} // end namespace
