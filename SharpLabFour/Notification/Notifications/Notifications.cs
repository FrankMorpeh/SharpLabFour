namespace SharpLabFour.Notification
{
    public class SubjectAdded : INotification
    {
        public string Text { get; set; }

        public SubjectAdded() { Text = "THE SUBJECT HAS BEEN ADDED!"; }
    }
}