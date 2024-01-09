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
        private AnimalService _service = new AnimalService();

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<AnimalViewModel> Animals { get; } = new ObservableCollection<AnimalViewModel>();

        public AnimalViewModel SelectedAnimal { get; set; }

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
                Animals.Add(new AnimalViewModel
                {
                    Id = Animal.Id,
                    FirstName = Animal.FirstName,
                    Name = Animal.Name,
                    BirthDate = Animal.BirthDate,
                    personality = Animal.personality,
                    Check_in_date = Animal.Check_in_date,

                });
            }
        }

        public void CreateNewAnimal(IAnimalWindow window)
        {
            var Animal = new AnimalViewModel();
            window.ViewModel = Animal;
        }

        public void SaveAnimal(IAnimalWindow window)
        {
            var AnimalViewModel = window.ViewModel;
            _service.SaveAnimal(new Animal
            {
                Id = AnimalViewModel.Id,
                FirstName = AnimalViewModel.FirstName,
                Name = AnimalViewModel.Name,
                BirthDate = AnimalViewModel.BirthDate,
                personality = AnimalViewModel.personality,
                Check_in_date = AnimalViewModel.Check_in_date,

            });

            GetAllAnimals();
        }

        public void EditAnimal(IAnimalWindow window)
        {
            var Animal = SelectedAnimal;
            window.ViewModel = new AnimalViewModel
            {
                Id = Animal.Id,
                FirstName = Animal.FirstName,
                Name = Animal.Name,
                BirthDate = Animal.BirthDate,
                personality = Animal.personality,
                Check_in_date = Animal.Check_in_date,

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
