using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace VSL_CODIUM_AVALONIA
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<EditorTab> Tabs { get; } = new();

        public ICommand SwitchTabCommand { get; }

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

            Tabs.Add(new EditorTab { Title = "main.cpp" });
            Tabs.Add(new EditorTab { Title = "Program.cs" });

            SwitchTabCommand = new RelayCommand<EditorTab>(tab =>
            {
            });
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }

    public class EditorTab
    {
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";
    }

    public class RelayCommand<T> : ICommand
    {
        private readonly System.Action<T?> _execute;

        public RelayCommand(System.Action<T?> execute)
        {
            _execute = execute;
        }

        public event System.EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter) => _execute((T?)parameter);
    }
}
