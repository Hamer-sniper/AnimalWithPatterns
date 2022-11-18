using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalWithPatterns
{
    public class Presenter
    {
        private Model model;
        private IView view;

        public Presenter(IView View)
        {
            this.view = View;
            model = new Model();
        }

        public Repository GetRepository()
        {
            return model.GetRepository();
        }

        public System.ComponentModel.BindingList<Animal> GetBindingList()
        {
            return model.GetBindingList();
        }

        public void AddAnimal()
        {
            model.GetRepository().Animals.Add(AnimalFactory.GetAnimal(view.AnimalType, view.AnimalName));
            SaveData();
        }

        public void AddRandomAnimal()
        {
            model.GetRepository().Animals.Add(AnimalFactory.GetAnimal(view.AnimalType, view.AnimalName));
            SaveData();
        }

        public void RemoveAnimal()
        {
            model.GetRepository().Animals.Remove(view.ConcreteAnimal);
            SaveData();
        }

        public void SaveData()
        {
            model.SaveData(view.LocalRepository);           
        }

        public void SaveToTXT()
        {
            model.SaveToTXT();
        }

        public void SaveToXLSX()
        {
            model.SaveToXLSX();
        }
    }
}
