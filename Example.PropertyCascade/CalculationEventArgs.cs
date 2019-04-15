using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.PropertyCascade
{
    public class CalculationEventArgs : EventArgs
    {
        public CalculationEventArgs(MyBusinessStuff1 selectedValue1, MyBusinessStuff2 selectedValue2)
        {
            Stuff1 = selectedValue1;
            Stuff2 = selectedValue2;
        }

        public MyBusinessStuff1 Stuff1 { get; set; }
        public MyBusinessStuff2 Stuff2 { get; set; }
    }
}
