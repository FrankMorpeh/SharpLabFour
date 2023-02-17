using SharpLabFour.Models.Subjects;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SharpLabFour.ViewModels
{
    public class SubjectViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Subject> Subjects { get; set; }

        public SubjectViewModel()
        {
            Subjects = new ObservableCollection<Subject>() { new Subject("Maths"), new Subject("Programming") };
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