using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWithPatterns
{
    /// <summary>
    /// Земноводные
    /// </summary>
    public class Amphibias : Animal
    {
        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="AnimalId">Идентификатор</param>
        /// <param name="Name">Название животного</param>
        public Amphibias(string animalId, string name)
        {
            AnimalId = animalId;
            Name = name;
            Type = "Земноводные";
            Sound = "Фффф";
        }

        /// <summary>
        /// Конструктор с автоподстановкой GIUD
        /// </summary>
        /// <param name="Name">Название животного</param>
        public Amphibias(string name) : this (Guid.NewGuid().ToString(), name) =>  Name = name;
        

        /// <summary>
        /// Конструктор без параметров
        /// </summary>       
        public Amphibias() : this ($"Неизвестное земноводное {new Random().Next().ToString()}") { }
    }
}
