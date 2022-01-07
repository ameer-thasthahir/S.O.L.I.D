using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPriciple.Demonstration.Correct
{
    class CurrencyConverter
    {
        public double ConvertToINR(object[] currencies, double INR)
        {
            double convertedValue = INR;
            foreach (var currency in currencies)
            {
                if (currency is Tirham)
                {
                    Tirham tirham = (Tirham)currency;
                    convertedValue += tirham.CurrentValue * INR;
                }
                else if (currency is Euro)
                {
                    Euro euro = (Euro)currency;
                    convertedValue += euro.CurrentValue * INR;
                }
                else if(currency is Dollar)
                {
                    Dollar dolllar = (Dollar)currency;
                    convertedValue += dolllar.CurrentValue * INR;
                }                     
            }

            return convertedValue;
        }
    }
}
