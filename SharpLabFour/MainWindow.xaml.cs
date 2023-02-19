using SharpLabFour.DataFramePages;
using SharpLabFour.Strategies.ShowSubjectsPageViewStrategies;
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
            studentViewModel.AddStudent(new Models.Students.Student("Bogdan", "Bakhmatskyi"
                , new System.Collections.ObjectModel.ObservableCollection<Models.Students.SubjectOfStudent> { 
                    new Models.Students.SubjectOfStudent(subjectViewModel.Subjects[1], 93.8)
                    , new Models.Students.SubjectOfStudent(subjectViewModel.Subjects[2], 97) }));

            studentViewModel.AddStudent(new Models.Students.Student("Artem", "Legenya"
                , new System.Collections.ObjectModel.ObservableCollection<Models.Students.SubjectOfStudent> { 
                new Models.Students.SubjectOfStudent(subjectViewModel.Subjects[0], 68.1)
                , new Models.Students.SubjectOfStudent(subjectViewModel.Subjects[1], 73)
                , new Models.Students.SubjectOfStudent(subjectViewModel.Subjects[2], 70)}));

            studentViewModel.AddStudent(new Models.Students.Student("Vlad", "Bakhmatskyi"
                , new System.Collections.ObjectModel.ObservableCollection<Models.Students.SubjectOfStudent> { 
                new Models.Students.SubjectOfStudent(subjectViewModel.Subjects[0], 97.5)
                , new Models.Students.SubjectOfStudent(subjectViewModel.Subjects[2], 90.6)}));
            // End of test zone
        }

        private void AddSubject_Click(object sender, RoutedEventArgs e)
        {
            dataFrame.Content = new AddSubjectPage(this);
        }
        private void ShowSubjects_Click(object sender, RoutedEventArgs e)
        {
            dataFrame.Content = new ShowSubjectsPage(this, new ShowInitialSubjectsStrategy(), subjectViewModel);
        }
        private void ShowStudents_Click(object sender, RoutedEventArgs e)
        {
            dataFrame.Content = new ShowStudentsPage(this);
        }
    }
}