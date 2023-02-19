using SharpLabFour.Models.Students;
using SharpLabFour.Models.Subjects;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SharpLabFour.ViewModels
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Student> Students { get; set; }
        
        public StudentViewModel()
        {
            Students = new ObservableCollection<Student>();
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }
        public void RemoveSubjectFromAllStudents(Subject subject) // is called when a subject is removed in SubjectViewModel
        {
            foreach (Student student in Students.Where(st => st.SubjectsAndGrades.ContainsKey(subject)))
                student.RemoveSubject(subject);
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