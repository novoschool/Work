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
        private EmployeeService _service = new EmployeeService();

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<EmployeeViewModel> Employees { get; } = new ObservableCollection<EmployeeViewModel>();

        public EmployeeViewModel SelectedEmployee { get; set; }

        public bool CanEdit => SelectedEmployee != null;

        public bool CanDelete => SelectedEmployee != null;

        public MainWindowViewModel()
        {
            GetAllEmployees();
        }

        public void GetAllEmployees()
        {
            var allEmployees = _service.GetAllEmployees();
            Employees.Clear();
            foreach (var employee in allEmployees)
            {
                Employees.Add(new EmployeeViewModel
                {
                    Id = employee.Id,
                    Stamp = employee.Stamp,
                    CarModel = employee.CarModel,
                    GosNumber = employee.GosNumber,
                    BirthDate = employee.BirthDate,
                    Mileage = employee.Mileage,
                    Price = employee.Price,
                    DateOfLastUse = employee.DateOfLastUse,
                });
            }
        }

        public void CreateNewEmployee(IEmployeeWindow window)
        {
            var employee = new EmployeeViewModel();
            window.ViewModel = employee;
        }

        public void SaveEmployee(IEmployeeWindow window)
        {
            var employeeViewModel = window.ViewModel;
            _service.SaveEmployee(new Employee
            {
                Id = employeeViewModel.Id,
                Stamp = employeeViewModel.Stamp,
                CarModel = employeeViewModel.CarModel,
                GosNumber = employeeViewModel.GosNumber,
                BirthDate = employeeViewModel.BirthDate,
                Mileage = employeeViewModel.Mileage,
                Price = employeeViewModel.Price,
                DateOfLastUse = employeeViewModel.DateOfLastUse,
            });

            GetAllEmployees();
        }

        public void EditEmployee(IEmployeeWindow window)
        {
            var employee = SelectedEmployee;
            window.ViewModel = new EmployeeViewModel
            {
                Id = employee.Id,
                Stamp = employee.Stamp,
                CarModel = employee.CarModel,
                GosNumber = employee.GosNumber,
                BirthDate = employee.BirthDate,
                Mileage = employee.Mileage,
                Price = employee.Price,
                DateOfLastUse = employee.DateOfLastUse,
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
