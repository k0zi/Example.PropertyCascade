using System;
using System.Linq;

namespace Example.PropertyCascade
{
    public class AvalancheCalculator
    {
        private readonly AvalancheCalculatorRule[] rules;
        public AvalancheCalculator(params AvalancheCalculatorRule[] rules)
        {
            this.rules = rules;
        }
        internal void Recalc(AvalancheViewModel avalancheViewModel, string propertyName)
        {
            rules.FirstOrDefault(r => r.Number == propertyName).Calc(avalancheViewModel);
        }
    }
}