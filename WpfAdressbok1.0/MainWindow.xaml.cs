
using System.Windows;
using WpfAdressbok1._0.ViewModels;


namespace WpfAdressbok1._0
{

    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}