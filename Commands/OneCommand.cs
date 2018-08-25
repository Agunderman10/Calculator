using System;
using System.Windows.Input;

namespace Calculator
{
    class OneCommand : ICommand
    {
        private readonly MainWindowViewModel viewModel;

        public OneCommand(MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            this.viewModel.Text = "1";
        }
    }
}
