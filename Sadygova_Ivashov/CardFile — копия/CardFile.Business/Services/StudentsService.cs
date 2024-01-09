using CardFile.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.Business.Services
{
    public class StudentsService
    {
        private readonly StudentsStorage _storage = new StudentsStorage();

        public StudentsService() 
        {
            InitializeStorage();
        }

        public IEnumerable<Students> GetAllStudents()
        {
            return _storage.Students;
        }

        private void InitializeStorage()
        {
            _storage.Students.Add(new Students
            {
                Id = 1,
                FirstName = "Андрей",
                MiddleName = "Григорьевич",
                LastName = "Захаров",
                BirthDate = new DateTime(1985, 11, 8),
                Position = "Руководитель проекта",
                Division = "Отдел разработки",
                StudentsDate = new DateTime(2019, 7, 15),
            });
            _storage.Students.Add(new Students
            {
                Id = 2,
                FirstName = "Людмила",
                MiddleName = "Алексеевна",
                LastName = "Фролова",
                BirthDate = new DateTime(1978, 3, 11),
                Position = "Бизнес-аналитик",
                Division = "Отдел анализа",
                StudentsDate = new DateTime(2020, 2, 3),
            });
            _storage.Students.Add(new Students
            {
                Id = 3,
                FirstName = "Вера",
                MiddleName = "Владимировна",
                LastName = "Тищенко",
                BirthDate = new DateTime(1989, 6, 10),
                Position = "Руководитель группы",
                Division = "Отдел тестирования",
                StudentsDate = new DateTime(2021, 11, 18),
            });

            StudentsStorage.MaxId = _storage.Students.Max(e => e.Id);
        }

        public void SaveStudents(Students Students)
        {
            if (Students.Id == 0)
            {
                StudentsStorage.MaxId++;
                Students.Id = StudentsStorage.MaxId;
                _storage.Students.Add(Students);
            }
            else
            {
                var existingStudents = _storage.Students.FirstOrDefault(e => e.Id == Students.Id);
                if (existingStudents == null)
                {
                    throw new IndexOutOfRangeException();
                }

                existingStudents.FirstName = Students.FirstName;
                existingStudents.LastName = Students.LastName;
                existingStudents.MiddleName = Students.MiddleName;
                existingStudents.BirthDate = Students.BirthDate;
                existingStudents.Position = Students.Position;
                existingStudents.Division = Students.Division;
                existingStudents.StudentsDate = Students.StudentsDate;
            }
        }
    }
}
