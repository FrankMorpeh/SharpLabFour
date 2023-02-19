
namespace SharpLabFour.Notification
{
    public class RecordNotChosen : INotification
    {
        public string Text { get; set; }

        public RecordNotChosen() { Text = "RECORD HASN'T BEEN CHOSEN!"; }
    }
    public class IncorrectName : INotification
    {
        public string Text { get; set; }

        public IncorrectName() { Text = "INCORRECT NAME!"; }
    }
    public class SuchSubjectExists : INotification
    {
        public string Text { get; set; }

        public SuchSubjectExists() { Text = "SUCH SUBJECT ALREADY EXISTS!"; }
    }
    public class None : INotification
    {
        public string Text { get; set; }

        public None() { Text = "NONE"; }
    }
}