using System;

namespace Example.PropertyCascade
{
    public abstract class AvalancheCalculatorRule
    {
        public string Number { get; protected set; }

        public abstract void Calc(AvalancheViewModel viewModel);
    }

    public class First : AvalancheCalculatorRule
    {
        public First()
        {
            Number = nameof(AvalancheViewModel.Number1);
        }
        public override void Calc(AvalancheViewModel viewModel)
        {
            viewModel.Number2 = viewModel.Number1 * 2;
        }
    }

    public class Second : AvalancheCalculatorRule
    {
        public Second()
        {
            Number = nameof(AvalancheViewModel.Number2);
        }
        public override void Calc(AvalancheViewModel viewModel)
        {
            if (viewModel.Number1 * 2 != viewModel.Number2)
            {
                viewModel.Number1 = viewModel.Number2 / 2;
            }
            else
            {
                viewModel.Number3 = viewModel.Number2 * 2;
            }
        }
    }

    public class Third : AvalancheCalculatorRule
    {
        public Third()
        {
            Number = nameof(AvalancheViewModel.Number3);
        }
        public override void Calc(AvalancheViewModel viewModel)
        {
            if(viewModel.Number2 * 2 != viewModel.Number3)
            {
                viewModel.Number2 = viewModel.Number3 / 2;
            }
            viewModel.Number4 = viewModel.Number3 * 2;
        }
    }

    public class Fourth : AvalancheCalculatorRule
    {
        public Fourth()
        {
            Number = nameof(AvalancheViewModel.Number4);
        }

        public override void Calc(AvalancheViewModel viewModel)
        {
            if(viewModel.Number3 * 2 != viewModel.Number4)
            {
                viewModel.Number3 = viewModel.Number4 / 2;
            }
        }
    }
}