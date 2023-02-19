using System.Windows.Controls;
using System.Windows;

namespace SharpLabFour.Notification
{
    public static class NotificationView
    {
        public static void ShowNotification(StackPanel notificationPanel, TextBlock notificationTextBlock, INotification notification)
        {
            notificationTextBlock.Text = notification.Text;
            notificationPanel.Visibility = Visibility.Visible;
        }
        public static void HideNotification(StackPanel notificationPanel)
        {
            notificationPanel.Visibility = Visibility.Hidden;
        }
    }
}