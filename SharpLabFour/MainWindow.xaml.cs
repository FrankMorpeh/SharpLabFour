using SharpLabFour.DataFramePages;
using SharpLabFour.ViewModels;
using System.Windows;

namespace SharpLabFour
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public StudentViewModel studentViewModel;
        public SubjectViewModel subjectViewModel;
        public MainWindow()
        {
            InitializeComponent();

            studentViewModel = new StudentViewModel();
            subjectViewModel = new SubjectViewModel(studentViewModel);

            // Test zone
            var subjectsAndGrades = new System.Collections.Generic.Dictionary<Models.Subjects.Subject, double>();
            subjectsAndGrades.Add(subjectViewModel.Subjects[1], 93.8);
            subjectsAndGrades.Add(subjectViewModel.Subjects[2], 96);
            studentViewModel.AddStudent(new Models.Students.Student("Bogdan", "Bakhmatskyi", subjectsAndGrades));

            subjectsAndGrades = new System.Collections.Generic.Dictionary<Models.Subjects.Subject, double>();
            subjectsAndGrades.Add(subjectViewModel.Subjects[0], 73);
            subjectsAndGrades.Add(subjectViewModel.Subjects[1], 67.8);
            subjectsAndGrades.Add(subjectViewModel.Subjects[2], 80);
            studentViewModel.AddStudent(new Models.Students.Student("Artem", "Legenya", subjectsAndGrades));

            subjectsAndGrades = new System.Collections.Generic.Dictionary<Models.Subjects.Subject, double>();
            subjectsAndGrades.Add(subjectViewModel.Subjects[0], 100);
            subjectsAndGrades.Add(subjectViewModel.Subjects[2], 90);
            studentViewModel.AddStudent(new Models.Students.Student("Vlad", "Bakhmatskyi", subjectsAndGrades));
            // End of test zone
        }

        private void ShowSubjects_Click(object sender, RoutedEventArgs e)
        {
            dataFrame.Content = new ShowSubjectsPage(this);
        }
        private void ShowStudents_Click(object sender, RoutedEventArgs e)
        {
            dataFrame.Content = new ShowStudentsPage(this);
        }
    }
}