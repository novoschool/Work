using CardFile.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.Business.Services
{
    public class AnimalService
    {
        private readonly AnimalStorage _storage = new AnimalStorage();

        public AnimalService() 
        {
            InitializeStorage();
        }

        public IEnumerable<Animal> GetAllAnimals()
        {
            return _storage.Animals;
        }

        private void InitializeStorage()
        {
            _storage.Animals.Add(new Animal
            {
                Id = 1,
                FirstName = "Андрей",
                Name = "Кот",
                BirthDate = new DateTime(2020, 11, 8),
                personality = "Cпокойный",
                Check_in_date = new DateTime(23, 4, 4)
            });
            _storage.Animals.Add(new Animal
            {
                Id = 2,
                FirstName = "Алиса",
                Name = "Лиса",
                BirthDate = new DateTime(2022, 08, 7),
                personality = "Бурная",
                Check_in_date = new DateTime(22, 09, 5)
            });
            _storage.Animals.Add(new Animal
            {
                Id = 3,
                FirstName = "Сёмя",
                Name = "Мышь",
                BirthDate = new DateTime(2023, 05, 12),
                personality = "Cпокойный",
                Check_in_date = new DateTime(23, 07, 18)
            });

            AnimalStorage.MaxId = _storage.Animals.Max(e => e.Id);
        }

        public void SaveAnimal(Animal animal)
        {
            if (animal.Id == 0)
            {
                AnimalStorage.MaxId++;
                animal.Id = AnimalStorage.MaxId;
                _storage.Animals.Add(animal);
            }
            else
            {
                var existingAnimal = _storage.Animals.FirstOrDefault(e => e.Id == animal.Id);
                if (existingAnimal == null)
                {
                    throw new IndexOutOfRangeException();
                }

                existingAnimal.FirstName = animal.FirstName;
                existingAnimal.Name = animal.Name;
                existingAnimal.BirthDate = animal.BirthDate;
                existingAnimal.personality = animal.personality;
                existingAnimal.Check_in_date = animal.Check_in_date;

            }
        }
    }
}
