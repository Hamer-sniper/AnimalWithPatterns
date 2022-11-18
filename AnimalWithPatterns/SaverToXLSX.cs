using System.Data.Entity;
using System.Linq;
using ClosedXML.Excel;

namespace AnimalWithPatterns
{
    public class SaverToXLSX : ISaverToFormats
    {
        private string NameOfFile { get; set; }

        public SaverToXLSX(string nameOfFile)
        {
            NameOfFile = nameOfFile;
        }

        private void CreateXLSX(Repository repository)
        {
            repository.Animals.Load();
            var animals = repository.Animals.Local.ToList();

            // Создать XLWorkbook.
            using (var workbook = new XLWorkbook())
            {
                // Добавить название листа в файле .xlsx.
                var worksheet = workbook.Worksheets.Add("Animals");

                // Заголовки.
                worksheet.Cell(1, 1).Value = "AnimalId";
                worksheet.Cell(1, 2).Value = "Название животного";
                worksheet.Cell(1, 3).Value = "Тип животного";
                worksheet.Cell(1, 4).Value = "Издаваемый звук";

                // Записать построчно в лист .xlsx файла.
                var i = 1;
                foreach (var animal in animals)
                {
                    i++;
                    worksheet.Cell(i, 1).Value = animal.AnimalId;
                    worksheet.Cell(i, 2).Value = animal.Name;
                    worksheet.Cell(i, 3).Value = animal.Type;
                    worksheet.Cell(i, 4).Value = animal.Sound;
                }

                // Сохранить.
                workbook.SaveAs($"{NameOfFile}.xlsx");
            }
        }
        public void SaveAnimals(Repository repository)
        {
            CreateXLSX(repository);
        }
    }
}
