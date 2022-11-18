using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace AnimalWithPatterns
{
    public class SaverToTXT : ISaverToFormats
    {
        private string NameOfFile { get; set; }

        public SaverToTXT(string nameOfFile)
        {
            NameOfFile = nameOfFile;
        }

        private string CreateTXT(Repository repository)
        {
            repository.Animals.Load();
            var animals = repository.Animals.Local.ToList();
            var txt = new StringBuilder();

            // Заголовки.
            txt.AppendLine($"AnimalId; Название животного; Тип животного; Издаваемый звук;");

            foreach (var animal in animals)
                txt.AppendLine(animal.ToString());

            return txt.ToString();
        }

        public void SaveAnimals(Repository repository)
        {
            using (StreamWriter sw = new StreamWriter($"{NameOfFile}.txt"))
            {
                sw.WriteLine(CreateTXT(repository));
            }
        }
    }
}
