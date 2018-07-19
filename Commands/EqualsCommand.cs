namespace Calculator.Commands
{
    using System;
    using System.Windows.Input;

    internal sealed class EqualsCommand : ICommand
    {
        private readonly MainWindowViewModel viewModel;

        public EqualsCommand(MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            this.viewModel.Text = "new text";
        }
    }
}
