using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPriciple.Demonstration.Correct
{
    public class Dollar: InrConverter
    {
        double currentValue;
        public double CurrentValue { get { return currentValue; } private set { currentValue = 84.06; } }

        public override double CalculateINR(double inrValue)
        {
            return currentValue * inrValue;
        }
    }
}
