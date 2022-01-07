using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPriciple.Demonstration.Correct
{
    public class Tirham: InrConverter
    {
        double currentValue;
        public double CurrentValue { get { return currentValue;  } private set { currentValue = 20.23; } }

        public override double CalculateINR(double inrValue)
        {
            return currentValue * inrValue;
        }
    }
}
