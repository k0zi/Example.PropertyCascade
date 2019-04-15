using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example.PropertyCascade
{
    public delegate void CalculationEventHandler(Form1ViewModel sender, CalculationEventArgs args);
    public class Calculator
    {
        public void CalculateValue(Form1ViewModel sender, MyBusinessStuff1 stuff1, MyBusinessStuff2 stuff2)
        {
            if (stuff1 != null && stuff2 != null)
            {
                sender.CalculatedValue = stuff1.Number1 + stuff2.Number2;
            }
        }
    }
}
