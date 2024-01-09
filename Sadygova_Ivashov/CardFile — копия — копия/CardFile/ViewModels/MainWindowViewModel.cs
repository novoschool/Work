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
        private AnimalsService _service = new AnimalsService();

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<AnimalsViewModel> Animals { get; } = new ObservableCollection<AnimalsViewModel>();

        public AnimalsViewModel SelectedAnimal { get; set; }

        public bool CanEdit => SelectedAnimal != null;

        public bool CanDelete => SelectedAnimal != null;

        public MainWindowViewModel()
        {
            GetAllAnimals();
        }

        public void GetAllAnimals()
        {
            var allAnimals = _service.GetAllAnimals();
            Animals.Clear();
            foreach (var Animal in allAnimals)
            {
                Animals.Add(new AnimalsViewModel
                {
                    Id = Animal.Id,
                    FirstName = Animal.FirstName,
                    Name = Animal.Name,
                    BirthDate = Animal.BirthDate

                }); 
            }
        }

        public void CreateNewAnimal(IAnimalsWindow window)
        {
            var Animal = new AnimalsViewModel();
            window.ViewModel = Animal;
        }

        public void SaveAnimal(IAnimalsWindow window)
        {
            var AnimalViewModel = window.ViewModel;
            _service.SaveAnimals(new Animal
            {
                Id = AnimalViewModel.Id,
                Name = AnimalViewModel.Name,
                FirstName = AnimalViewModel.FirstName,
                BirthDate = AnimalViewModel.BirthDate

            });

            GetAllAnimals();
        }

        public void EditAnimal(IAnimalsWindow window)
        {
            var Animal = SelectedAnimal;
            window.ViewModel = new AnimalsViewModel
            {
                Id = Animal.Id,
                Name = Animal.Name,
                FirstName = Animal.FirstName,
                BirthDate = Animal.BirthDate
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
