using System.ComponentModel;
using System.Windows.Input;
using Calculator.Commands;

namespace Calculator
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private const string InitialText = "0";
        private string text = InitialText;

        public MainWindowViewModel()
        {
            this.ButtonCommands = new ButtonCommands(this);
        }

        public string Text
        {
            get => this.text;
            set
            {
                if (this.Text != value)
                {
                    this.text = value;
                    this.PropertyChanged?.Invoke(
                        this,
                        new PropertyChangedEventArgs(nameof(this.Text)));
                }
            }
        }

        public ICommand ButtonCommands { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
