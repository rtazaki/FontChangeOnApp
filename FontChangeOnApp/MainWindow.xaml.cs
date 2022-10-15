using System.Windows;

namespace FontChangeOnApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TargetPageFrame.Navigate(new View.Page1());
        }
    }
}
