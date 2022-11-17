using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWithPatterns
{
    /// <summary>
    /// Млекопитающие
    /// </summary>
    public class Mammals : Animal
    {
        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="AnimalId">Идентификатор</param>
        /// <param name="Name">Название животного</param>
        public Mammals(string animalId, string name)
        {
            AnimalId = animalId;
            Name = name;
            Type = "Млекопитающие";
            Sound = "Рррр";
        }

        /// <summary>
        /// Конструктор с автоподстановкой GIUD
        /// </summary>
        /// <param name="Name">Название животного</param>
        public Mammals(string name) : this (Guid.NewGuid().ToString(), name) =>  Name = name;
        

        /// <summary>
        /// Конструктор без параметров
        /// </summary>       
        public Mammals() : this ($"Неизвестное млекопитающее {new Random().Next().ToString()}") { }
    }
}
