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
            
            this.EqualsCommand = new EqualsCommand(this);
            this.ZeroCommand = new ZeroCommand(this);
            this.OneCommand = new OneCommand(this);
            this.TwoCommand = new TwoCommand(this);
            this.ThreeCommand = new ThreeCommand(this);
            this.FourCommand = new FourCommand(this);
            this.FiveCommand = new FiveCommand(this);
            this.SixCommand = new SixCommand(this);
            this.SevenCommand = new SevenCommand(this);
            this.EightCommand = new EightCommand(this);
            this.NineCommand = new NineCommand(this);
            this.DotCommand = new DotCommand(this);
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

        public ICommand EqualsCommand { get; }
        public ICommand ZeroCommand { get; }
        public ICommand OneCommand { get; }
        public ICommand TwoCommand { get; }
        public ICommand ThreeCommand { get; }
        public ICommand FourCommand { get; }
        public ICommand FiveCommand { get; }
        public ICommand SixCommand { get; }
        public ICommand SevenCommand { get; }
        public ICommand EightCommand { get; }
        public ICommand NineCommand { get; }
        public ICommand DotCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
