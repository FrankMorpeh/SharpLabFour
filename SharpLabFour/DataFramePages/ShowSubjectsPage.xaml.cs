using SharpLabFour.ViewModels;
using System.Windows.Controls;

namespace SharpLabFour.DataFramePages
{
    /// <summary>
    /// Interaction logic for ShowSubjectsPage.xaml
    /// </summary>
    public partial class ShowSubjectsPage : Page
    {
        public ShowSubjectsPage()
        {
            InitializeComponent();
            DataContext = new SubjectViewModel();
        }
    }
}
