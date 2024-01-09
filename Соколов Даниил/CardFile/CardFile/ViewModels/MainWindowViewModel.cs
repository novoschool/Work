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
                    Name = employee.Name,
                    ManufacturedProduction = employee.ManufacturedProduction,
                    ValueOutputProduction = employee.ValueOutputProduction,
                    LastName = employee.LastName,
                    CreationDate = employee.CreationDate,
                    RenovationNeed = employee.RenovationNeed,
                    EmployeesNumber = employee.EmployeesNumber,
                    LastRenovationDate = employee.LastRenovationDate,
                });
            }
        }

        public void CreateNewEmployee(IEmployeeWindow window)
        {
            var employee = new EmployeeViewModel();
            window.ViewModel = employee;
        }

        public void DeleteEmployee(IEmployeeWindow window)
        {
            var employeeViewModel = window.ViewModel;
            _service.Delete(new Employee
            {
                Id = employeeViewModel.Id,
                Name = employeeViewModel.Name,
                ManufacturedProduction = employeeViewModel.ManufacturedProduction,
                ValueOutputProduction = employeeViewModel.ValueOutputProduction,
                LastName = employeeViewModel.LastName,
                CreationDate = employeeViewModel.CreationDate,
                RenovationNeed = employeeViewModel.RenovationNeed,
                EmployeesNumber = employeeViewModel.EmployeesNumber,
                LastRenovationDate = employeeViewModel.LastRenovationDate,
            });

            GetAllEmployees();
        }

        public void SaveEmployee(IEmployeeWindow window)
        {
            var employeeViewModel = window.ViewModel;
            _service.SaveEmployee(new Employee
            {
                Id = employeeViewModel.Id,
                Name = employeeViewModel.Name,
                ManufacturedProduction = employeeViewModel.ManufacturedProduction,
                ValueOutputProduction = employeeViewModel.ValueOutputProduction,
                LastName = employeeViewModel.LastName,
                CreationDate = employeeViewModel.CreationDate,
                RenovationNeed = employeeViewModel.RenovationNeed,
                EmployeesNumber = employeeViewModel.EmployeesNumber,
                LastRenovationDate = employeeViewModel.LastRenovationDate,
            });

            GetAllEmployees();
        }

        public void EditEmployee(IEmployeeWindow window)
        {
            var employee = SelectedEmployee;
            window.ViewModel = new EmployeeViewModel
            {
                Id = employee.Id,
                Name = employee.Name,
                ManufacturedProduction = employee.ManufacturedProduction,
                ValueOutputProduction = employee.ValueOutputProduction,
                LastName = employee.LastName,
                CreationDate = employee.CreationDate,
                RenovationNeed = employee.RenovationNeed,
                EmployeesNumber = employee.EmployeesNumber,
                LastRenovationDate = employee.LastRenovationDate,
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
