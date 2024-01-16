using CardFile.Core.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.DataAccess.File.Repositories
{
    public class FileEmployeeRepositoryFactory
    {
        public IEmployeeRepository CreateRepository(string fileName)
        {
            string fileNameExtension = Path.GetExtension(fileName);
            switch (fileNameExtension)
            {
                case ".crdtxt":
                    return new TextFileEmployeeRepository { FileName = fileName };

                default:
                    return null;
            }
        }
    }
}
