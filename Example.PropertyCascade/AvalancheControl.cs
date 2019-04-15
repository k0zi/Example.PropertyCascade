using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example.PropertyCascade
{
    public partial class AvalancheControl : UserControl
    {
        private readonly AvalancheViewModel viewModel;
        public AvalancheControl()
        {
            InitializeComponent();
            viewModel = new AvalancheViewModel(
                new AvalancheCalculator(
                    new AvalancheCalculatorRule[] 
                    {
                        new First(),
                        new Second(),
                        new Third(),
                        new Fourth()
                    }
                    ));
            bsAvalanche.DataSource = viewModel;
        }
    }
}
