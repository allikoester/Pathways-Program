using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMVC
{
    internal class CalcController
    {
        private CalcModel calcModel;
        private CalcView calcView;

        public CalcController()
        {
            bool exitApp = false;

            while (!exitApp)
            {
                calcModel = new CalcModel();    
                calcView = new CalcView();
                calcModel.Number1 = calcView.GetValidNumber();
                calcModel.Number2 = calcView.GetValidNumber();
                calcModel.Operation = calcView.SelectOperation();
                calcModel.Result = calcModel.DoOperation();
                calcView.DisplayResult(calcModel.Result);
                exitApp = calcView.QuitProgram();

            } // end while continuing program 
            return;

        }


    } // end class
} // end namespace
