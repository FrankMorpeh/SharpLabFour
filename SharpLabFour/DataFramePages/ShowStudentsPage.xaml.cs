using SharpLabFour.Models.Students;
using SharpLabFour.Notification;
using System.Windows;
using System.Windows.Controls;

namespace SharpLabFour.DataFramePages
{
    /// <summary>
    /// Interaction logic for ShowStudentsPage.xaml
    /// </summary>
    public partial class ShowStudentsPage : Page
    {
        private MainWindow itsContent;
        public ShowStudentsPage(MainWindow content)
        {
            InitializeComponent();
            itsContent = content;
            DataContext = itsContent.studentViewModel;
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (studentsDataGrid.SelectedIndex == -1)
                NotificationView.ShowNotification(notificationStackPanel, notificationTextBlock, new RecordNotChosen());
            else
                itsContent.studentViewModel.RemoveStudent((Student)studentsDataGrid.SelectedItem);
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            NotificationView.HideNotification(notificationStackPanel);
        }
    }
}