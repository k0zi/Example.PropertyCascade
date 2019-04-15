using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example.PropertyCascade
{
    public partial class Form1 : Form
    {
        private readonly Form1ViewModel viewModel;
        public Form1()
        {
            InitializeComponent();
            viewModel = new Form1ViewModel(
                new MyBusinessStuffProvider(), 
                new Calculator());
            bsViewModel.DataSource = viewModel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            viewModel.Load();
            bsCombo1.DataSource = viewModel.MyBusinessStuff1s;
            bsCombo1.ResetBindings(false);
            bsCombo2.DataSource = viewModel.MyBusinessStuff2s;
            bsCombo2.ResetBindings(false);
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }
    }
}
