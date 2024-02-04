using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator.BL
{
    internal class Calculator
    {
        public float value1;
        public float value2;
        public Calculator() 
        {
            value1 = 10f;
            value2 = 10f;
        }
        public Calculator(float value1, float value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }
        public float add()
        {
            return value1 + value2;
        }
        public float subtract() 
        {
            return value1 - value2;
        }
        public float multiply() 
        {
            return value1 * value2;
        }
        public float divide() 
        {
            return value1 / value2;
        }
        public float mod() 
        {
            return value1%value2;
        }
    }
}
