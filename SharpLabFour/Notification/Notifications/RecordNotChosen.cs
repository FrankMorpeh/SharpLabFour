namespace SharpLabFour.Notification
{
    public class RecordNotChosen : INotification
    {
        public string Text { get; set; }

        public RecordNotChosen() { Text = "RECORD HASN'T BEEN CHOSEN!"; }
    }
}