using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPriciple.Demonstration.Correct
{
    public class CurrencyConverte
    {
        private readonly InrConverter inrConverter;

        public CurrencyConverte(InrConverter inrConverter)
        {
            this.inrConverter = inrConverter;
        }
        public double ConvertToINR(double inrValue)
        {
            return inrConverter.CalculateINR(inrValue);
        }
    }
}
