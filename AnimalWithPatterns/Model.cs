using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWithPatterns
{
    class Model
    {
        Repository repository;
        SaverToFormats stf;
        SaverToTXT saveToTXT;
        SaverToXLSX saveToXLSX;

        public Model()
        {
            repository = RepositoryFactory.GetSQLRepository();
            saveToTXT = new SaverToTXT("AnimalsTXT");
            saveToXLSX = new SaverToXLSX("AnimalsXLSX");
            stf = new SaverToFormats(repository);
        }

        public System.ComponentModel.BindingList<Animal> GetBindingList()
        {
            repository.Animals.Load();
            return repository.Animals.Local.ToBindingList();
        }

        public Repository GetRepository()
        {
            return repository;
        }

        public void SaveData(Repository LocalRepository)
        {
            LocalRepository.SaveChanges();
        }

        public void SaveToTXT()
        {
            stf.Mode = saveToTXT;
            stf.Save();
        }

        public void SaveToXLSX()
        {
            stf.Mode = saveToXLSX;
            stf.Save();
        }
    }
}
