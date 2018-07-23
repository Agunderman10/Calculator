﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculator.Commands
{
    class NineCommand : ICommand
    {
        private readonly MainWindowViewModel viewModel;

        public NineCommand(MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            this.viewModel.Text = "9";
        }
    }
}
