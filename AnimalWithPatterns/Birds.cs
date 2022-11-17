using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWithPatterns
{
    /// <summary>
    /// Птицы
    /// </summary>
    public class Birds : Animal
    {
        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="AnimalId">Идентификатор</param>
        /// <param name="Name">Название животного</param>
        public Birds(string animalId, string name)
        {
            AnimalId = animalId;
            Name = name;
            Type = "Птицы";
            Sound = "Чик-чирик";
        }

        /// <summary>
        /// Конструктор с автоподстановкой GIUD
        /// </summary>
        /// <param name="Name">Название животного</param>
        public Birds(string name) : this (Guid.NewGuid().ToString(), name) =>  Name = name;
        

        /// <summary>
        /// Конструктор без параметров
        /// </summary>       
        public Birds() : this ($"Неизвестная птица {new Random().Next().ToString()}") { }
    }
}
