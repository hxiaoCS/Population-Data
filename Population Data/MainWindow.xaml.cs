using System.Windows;

namespace Population_Data
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm = new VM();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm; // data context set up
        }
        private void BtnShow_Click(object sender, RoutedEventArgs e)
        {
            //see vm for more details 
            vm.DisplayResult();
        }
        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            //Clear the listbox
            vm.Clear();
        }
    }
}
