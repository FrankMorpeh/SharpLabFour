using SharpLabFour.Models.Subjects;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SharpLabFour.Models.Students
{
    public class Student : INotifyPropertyChanged
    {
        private string itsFirstName;
        private string itsLastName;
        private Dictionary<Subject, double> itsSubjectsAndGrades;

        public string FirstName
        {
            get { return itsFirstName; }
            set { itsFirstName = value; OnPropertyChanged("FirstName"); }
        }
        public string LastName
        {
            get { return itsLastName; }
            set { itsLastName = value; OnPropertyChanged("LastName"); }
        }
        public Dictionary<Subject, double> SubjectsAndGrades { get { return itsSubjectsAndGrades; } }

        public Student() : this(string.Empty, string.Empty, null) {}
        public Student(string firstName, string lastName)
        {
            itsFirstName = firstName;
            itsLastName = lastName;
            itsSubjectsAndGrades = new Dictionary<Subject, double>();
        }
        public Student(string firstName, string lastName, Dictionary<Subject, double> subjectsAndGrades)
        {
            itsFirstName = firstName;
            itsLastName = lastName;
            itsSubjectsAndGrades = subjectsAndGrades;
        }
        public void AddSubjectAndGrade(Subject subject, double grade)
        {
            itsSubjectsAndGrades.Add(subject, grade);
        }
        public void RemoveSubject(Subject subject)
        {
            itsSubjectsAndGrades.Remove(subject);
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