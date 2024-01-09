using CardFile.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.Business.Services
{
    public class AnimalsService
    {
        private readonly AnimalsStorage _storage = new AnimalsStorage();

        public AnimalsService() 
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
                FirstName = "Бобик",
                Name = "Собака",
                BirthDate = DateTime.Now

            });
            _storage.Animals.Add(new Animal
            {
                Id = 2,
                FirstName = "Муся",
                Name = "Кошка",
                BirthDate = DateTime.Now
            });
            _storage.Animals.Add(new Animal
            {
                Id = 3,
                FirstName = "Алиса",
                Name = "Лиса",
                BirthDate = DateTime.Now
            });

            AnimalsStorage.MaxId = _storage.Animals.Max(e => e.Id);
        }

        public void SaveAnimals(Animal Animals)
        {
            if (Animals.Id == 0)
            {
                AnimalsStorage.MaxId++;
                Animals.Id = AnimalsStorage.MaxId;
                _storage.Animals.Add(Animals);
            }
            else
            {
                var existingAnimals = _storage.Animals.FirstOrDefault(e => e.Id == Animals.Id);
                if (existingAnimals == null)
                {
                    throw new IndexOutOfRangeException();
                }

                existingAnimals.FirstName = Animals.FirstName;
                existingAnimals.Name = Animals.Name;
                existingAnimals.Name = Animals.BirthDate.ToString();
            }
        }
    }
}
