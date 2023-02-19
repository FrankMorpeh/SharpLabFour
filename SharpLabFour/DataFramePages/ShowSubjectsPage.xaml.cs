using SharpLabFour.Models.Subjects;
using SharpLabFour.Notification;
using System.Windows;
using System.Windows.Controls;

namespace SharpLabFour.DataFramePages
{
    /// <summary>
    /// Interaction logic for ShowSubjectsPage.xaml
    /// </summary>
    public partial class ShowSubjectsPage : Page
    {
        private MainWindow itsContent;
        public ShowSubjectsPage(MainWindow content)
        {
            InitializeComponent();
            itsContent = content;
            DataContext = itsContent.subjectViewModel;
        }


        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (subjectsDataGrid.SelectedIndex == -1)
                NotificationView.ShowNotification(notificationStackPanel, notificationTextBlock, new RecordNotChosen());
            else
                itsContent.subjectViewModel.RemoveSubject((Subject)subjectsDataGrid.SelectedItem);
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            NotificationView.HideNotification(notificationStackPanel);
        }
    }
}