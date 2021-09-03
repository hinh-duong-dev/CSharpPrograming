using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDelegate
{
    public class Calculator
    {
        public delegate int Calculate(int input);

        public event Action<object, CalculatorEventArgs> CalculateTriggered;

        public int Execute(Calculate calculate, int input)
        {
            return calculate(input);
        }

        public void RaiseEvent(string name)
        {
            CalculateTriggered.Invoke(this, new CalculatorEventArgs { Name = name });
        }

    }
}
