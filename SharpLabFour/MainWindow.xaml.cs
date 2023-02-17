using SharpLabFour.DataFramePages;
using System.Windows;

namespace SharpLabFour
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataFrame.Content = new ShowSubjectsPage();
        }

        private void ShowSubjects_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}