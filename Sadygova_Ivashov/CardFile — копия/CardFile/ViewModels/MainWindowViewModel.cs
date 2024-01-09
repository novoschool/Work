using CardFile.Business.Models;
using CardFile.Business.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.ViewModels
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        private StudentsService _service = new StudentsService();

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<StudentsViewModel> Students { get; } = new ObservableCollection<StudentsViewModel>();

        public StudentsViewModel SelectedStudent { get; set; }

        public bool CanEdit => SelectedStudent != null;

        public bool CanDelete => SelectedStudent != null;

        public MainWindowViewModel()
        {
            GetAllStudents();
        }

        public void GetAllStudents()
        {
            var allStudents = _service.GetAllStudents();
            Students.Clear();
            foreach (var student in allStudents)
            {
                Students.Add(new StudentsViewModel
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    MiddleName = student.MiddleName,
                    LastName = student.LastName,
                    BirthDate = student.BirthDate,
                    Position = student.Position,
                    Division = student.Division,
                    StudentDate = student.StudentsDate,
                }); 
            }
        }

        public void CreateNewStudent(IStudentsWindow window)
        {
            var student = new StudentsViewModel();
            window.ViewModel = student;
        }

        public void SaveStudent(IStudentsWindow window)
        {
            var studentViewModel = window.ViewModel;
            _service.SaveStudents(new Students
            {
                Id = studentViewModel.Id,
                FirstName = studentViewModel.FirstName,
                MiddleName = studentViewModel.MiddleName,
                LastName = studentViewModel.LastName,
                BirthDate = studentViewModel.BirthDate,
                Position = studentViewModel.Position,
                Division = studentViewModel.Division,
                StudentsDate = studentViewModel.StudentDate,
            });

            GetAllStudents();
        }

        public void EditStudent(IStudentsWindow window)
        {
            var Student = SelectedStudent;
            window.ViewModel = new StudentsViewModel
            {
                Id = Student.Id,
                FirstName = Student.FirstName,
                MiddleName = Student.MiddleName,
                LastName = Student.LastName,
                BirthDate = Student.BirthDate,
                Position = Student.Position,
                Division = Student.Division,
                StudentDate = Student.StudentDate,
            };
        }

        public void UpdateButtons()
        {
            OnPropertyChanged(nameof(CanEdit));
            OnPropertyChanged(nameof(CanDelete));
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
