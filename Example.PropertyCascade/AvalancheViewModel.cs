using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.PropertyCascade
{
    public class AvalancheViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly AvalancheCalculator calculator;
        private decimal number1;
        private decimal number2;
        private decimal number3;
        private decimal number4;

        public AvalancheViewModel(AvalancheCalculator calculator)
        {
            this.calculator = calculator;
        }


        public decimal Number4
        {
            get { return number4; }
            set
            {
                number4 = value;
                calculator.Recalc(this, nameof(Number4));
                OnPropertyChanged(nameof(Number4));
            }
        }


        public decimal Number3
        {
            get { return number3; }
            set
            {
                number3 = value;
                calculator.Recalc(this, nameof(Number3));
                OnPropertyChanged(nameof(Number3));
            }
        }

        public decimal Number2
        {
            get { return number2; }
            set
            {
                number2 = value;
                calculator.Recalc(this, nameof(Number2));
                OnPropertyChanged(nameof(Number2));
            }
        }

        public decimal Number1
        {
            get { return number1; }
            set
            {
                number1 = value;
                calculator.Recalc(this, nameof(Number1));
                OnPropertyChanged(nameof(Number1));
            }
        }


        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
