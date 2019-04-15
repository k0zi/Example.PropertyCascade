using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.PropertyCascade
{
    public class Form1ViewModel : INotifyPropertyChanged
    {
        
        private readonly MyBusinessStuffProvider provider;
        private readonly Calculator calculator;
        private MyBusinessStuff1 selectedValue1;
        private MyBusinessStuff2 selectedValue2;
        private decimal calculatedValue;

        public Form1ViewModel(MyBusinessStuffProvider provider, Calculator calculator)
        {
            this.provider = provider;
            this.calculator = calculator;
            SelectedValue1 = null;
            SelectedValue2 = null;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        internal void Load()
        {
            MyBusinessStuff1s = provider.GetStuff1s();
            MyBusinessStuff2s = provider.GetStuff2s();
        }

        public List<MyBusinessStuff1> MyBusinessStuff1s { get; private set; }
        public List<MyBusinessStuff2> MyBusinessStuff2s { get; private set; }

        [Bindable(true)]
        public MyBusinessStuff1 SelectedValue1
        {
            get { return selectedValue1; }
            set
            {
                selectedValue1 = value;
                OnCalcuationChanged();
                OnPropertyChanged(nameof(SelectedValue1));
            }
        }

        [Bindable(true)]
        public MyBusinessStuff2 SelectedValue2
        {
            get { return selectedValue2; }
            set
            {
                selectedValue2 = value;
                OnCalcuationChanged();
                OnPropertyChanged(nameof(SelectedValue2));
            }
        }

        private void OnCalcuationChanged()
        {
            calculator.CalculateValue(this, SelectedValue1, SelectedValue2);
        }

        public decimal CalculatedValue
        {
            get { return calculatedValue; }
            set
            {
                calculatedValue = value;
                OnPropertyChanged(nameof(CalculatedValue));
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
