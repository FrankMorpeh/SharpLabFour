using SharpLabFour.Models.Students;
using SharpLabFour.Models.Subjects;
using SharpLabFour.States.StudentViewModelSortingStates;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace SharpLabFour.ViewModels
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Student> itsStudents;
        private IStudentViewModelSortingState itsStudentViewModelSortingState;

        public ObservableCollection<Student> Students { get { return itsStudents; } set { itsStudents = value; } }
        
        public StudentViewModel()
        {
            itsStudents = new ObservableCollection<Student>();
            itsStudentViewModelSortingState = new StudentViewModelNotSortedByLastNameState();
        }
        public void AddStudent(Student student)
        {
            itsStudents.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            itsStudents.Remove(student);
        }
        public void RemoveSubjectFromAllStudents(Subject subject) // is called when a subject is removed in SubjectViewModel
        {
            foreach (Student student in itsStudents)
            {
                if (student.SubjectsAndGrades.Where(sg => sg.Subject == subject).FirstOrDefault() != null)
                    student.RemoveSubject(subject);
            }
        }
        

        // Sorting
        public void SortByLastName(DataGrid studentsDataGrid)
        {
            itsStudentViewModelSortingState.SortByLastName(ref itsStudents, ref itsStudentViewModelSortingState);
            studentsDataGrid.ItemsSource = itsStudents;
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