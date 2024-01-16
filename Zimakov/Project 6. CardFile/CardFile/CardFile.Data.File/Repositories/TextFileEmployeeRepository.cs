using CardFile.Core.Entities;
using CardFile.Core.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.Data.File.Repositories
{
    internal class TextFileEmployeeRepository : IEmployeeRepository
    {
        public string FileName { get; set; }
        public IEnumerable<Employee> GetAll()
        {
            using (var sr = new StreamReader(FileName))
            {
                var result = new List<Employee>();

                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    int id;
                    if(!int.TryParse(line, out id))
                    {
                        break;
                    }

                    var Stamp = sr.ReadLine();
                    var CarModel = sr.ReadLine();
                    var GosNumber = sr.ReadLine();
                    line = sr.ReadLine();
                    DateTime BirthDate;
                    if (!DateTime.TryParse(line, out BirthDate))
                    {
                        break;
                    }
                    line = sr.ReadLine();
                    DateTime DateOfLastUse;
                    if (!DateTime.TryParse(line, out DateOfLastUse))
                    {
                        break;
                    }
                    line = sr.ReadLine();
                    double Millage;
                    if (!double.TryParse(line, out Millage))
                    {
                        break;
                    }
                    line = sr.ReadLine();
                    decimal Price;
                    if (!decimal.TryParse(line, out Price))
                    {
                        break;
                    }

                    result.Add(new Employee
                    {
                        Id = id,
                        Stamp = Stamp,
                        CarModel = CarModel,
                        GosNumber = GosNumber,
                        BirthDate = BirthDate,
                        DateOfLastUse = DateOfLastUse,
                        Mileage = Millage,
                        Price = Price
                    });

                }

                return result;
            }
        }

        public void SaveAll(IEnumerable<Employee> employees)
        {
            using (var sw = new StreamWriter(FileName))
            {
                foreach (var employee in employees)
                {
                    sw.WriteLine(employee.Id);
                    sw.WriteLine(employee.Stamp);
                    sw.WriteLine(employee.CarModel);
                    sw.WriteLine(employee.GosNumber);
                    sw.WriteLine(employee.BirthDate);
                    sw.WriteLine(employee.DateOfLastUse);
                    sw.WriteLine(employee.Mileage);
                    sw.WriteLine(employee.Price);
                }
            }
        }
    }
}
