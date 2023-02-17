using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SharpLabFour.Models.Subjects
{
    public class Subject : INotifyPropertyChanged
    {
        private string itsName;
        private double itsCredit;

        public string Name { get { return itsName; } set { itsName = value; OnPropertyChanged("Name"); } }
        public double Credit { get { return itsCredit; } set { itsCredit = value; OnPropertyChanged("Credit"); } }

        public Subject()
        {
            itsName = string.Empty;
            itsCredit = 0.0;
        }
        public Subject(string name, double credit)
        {
            itsName = name;
            itsCredit = credit;
        }


        // MVVM events
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}